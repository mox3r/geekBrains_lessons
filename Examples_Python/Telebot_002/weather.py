import math
import datetime
import requests
from aiogram import Bot, types, executor
from aiogram.dispatcher import Dispatcher

bot = Bot(token='5963911681:AAHj6TbJBCqPcWWzEGzYrEs5DX-SQOKHQyA')
dp = Dispatcher(bot)


@dp.message_handler(commands=["start"])
async def start_command(message: types.message):
    await message.reply(
        "Привет! Напиши мне название города и я пришлю сводку погоды")


@dp.message_handler()
async def get_weather(message: types.Message):
    pass


@dp.message_handler()
async def get_weather(message: types.Message):
    try:
        response = requests.get(
            f"http://api.openweathermap.org/data/2.5/weather?q=минск&lang=ru&units=metric&appid=17945826ed512f8638bbc169d93e23ff"
        )
        data = response.json()

        city = data["name"]
        cur_temp = data["main"]["temp"]
        humidity = data["main"]["humidity"]
        pressure = data["main"]["pressure"]
        wind = data["wind"]["speed"]

        # получаем время рассвета и преобразуем его в читабельный формат
        sunrise_timestamp = datetime.datetime.fromtimestamp(
            data["sys"]["sunrise"])

        # то же самое проделаем со временем заката
        sunset_timestamp = datetime.datetime.fromtimestamp(
            data["sys"]["sunset"])
        # продолжительность дня
        length_of_the_day = datetime.datetime.fromtimestamp(
            data["sys"]["sunset"]) - datetime.datetime.fromtimestamp(
                data["sys"]["sunrise"])

        code_to_smile = {
            "Clear": "Ясно \U00002600",
            "Clouds": "Облачно \U00002601",
            "Rain": "Дождь \U00002614",
            "Drizzle": "Дождь \U00002614",
            "Thunderstorm": "Гроза \U000026A1",
            "Snow": "Снег \U0001F328",
            "Mist": "Туман \U0001F32B"
        }
        # получаем значение погоды
        weather_description = data["weather"][0]["main"]

        if weather_description in code_to_smile:
            wd = code_to_smile[weather_description]
        else:
            # если эмодзи для погоды нет, выводим другое сообщение
            wd = "Посмотри в окно, я не понимаю, что там за погода..."

        await message.reply(
            f"{datetime.datetime.now().strftime('%Y-%m-%d %H:%M')} \n"
            f"Погода в городе: {city}\nТемпература: {cur_temp}°C {wd}\n"
            f"Влажность: {humidity}%\nДавление: {math.ceil(pressure/1.333)} мм.рт.ст\nВетер: {wind} м/с \n"
            f"Восход солнца: {sunrise_timestamp}\nЗакат солнца: {sunset_timestamp}\nПродолжительность дня: {length_of_the_day}\n"
            f"Хорошего дня!")

    except:
        await message.reply("Проверьте название города!!")


if __name__ == "__main__":
    # С помощью метода executor.start_polling опрашиваем
    # Dispatcher: ожидаем команду /start
    executor.start_polling(dp)