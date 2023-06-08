#Внимание, код устаре и не работает надо разбираться почему
from __future__ import unicode_literals
import os
import re
import logging
from unicodedata import normalize

import requests
import youtube_dl
from bs4 import BeautifulSoup
from telegram.ext import Updater, CommandHandler, MessageHandler, filters

#Вывод и запись лога работы с помощью logging
logging.basicConfig(
    filename="sample.log",
    format='%(asctime)s - %(name)s -%(levelname)s - %(message)s',
    level=logging.INFO)


#Ф-ция для преобразования имени файла
def normalize_special_char(txt):
    return normalize('NFKD', txt).encode('ASCII', 'ignore').decode('ASCII')


#Ф-ция ищет видео по запросу
def search_youtube(text):
    url = 'https://youtube.com'
    r = requests.get(url + '/results', params={'search_query': text})
    soup = BeautifulSoup(r.content, 'html_parser')
    for tag in soup.find_all('a', {'rel': 'spf-prefetch'}):
        title, video_url = tag.text, url + tag['href']
        if 'googleads' not in video_url:
            return normalize_special_char(title), video_url


#Непосредственное скачивание
def download(title, video_url):
    ydl_opts = {
        'outtmpl':
        '{}, %(ext)s'.format(title),
        'format':
        'bestaudio/best',
        'postprocessors': [{
            'key': 'FFmpegExtractAudio',
            'prefferedcodec': 'mp3',
            'prefferedquality': '192',
        }],
    }
    with youtube_dl.YoutubeDL(ydl_opts) as ydl:
        ydl.download([video_url])
    return {
        'audio': open(title + '.mp3', 'rb'),
        'title': title,
    }


#Описание ф-ции Старт
def start(bot, update):
    update.message.reply_text("YT2mp3")


#Отправляем пользователю сообщение
def music(bot, update):
    title, video_url = search_youtube(update.message.text)
    update.message.reply_text("Start download " + title)
    music_dict = download(title, video_url)
    update.message.reply_text("Convert 2 mp3 " + title)
    update.message.reply_audio(**music_dict, timeout=9999)
    os.remove(title + '.mp3')


#Главная функция
def main():
    TOKEN_NAME = 'your_token_name'
    u = Updater(TOKEN_NAME)
    dp = u.dispatcher
    dp.add_handler(CommandHandler("start", start))
    dp.add_handler(MessageHandler(filters.Text, music))
    u.start_polling()
    u.idle()

    #Функция, которая не даёт скрипту завершится
    if __name__ == '__main__':
        main()