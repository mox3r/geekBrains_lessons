import time
import logging

from aiogram import Bot, Dispatcher, executor, types

TOKEN = "" #insert your token here
MSG = "{}, занимайся, блеать!"

bot = Bot(token=TOKEN)
dp = Dispatcher(bot=bot)


@dp.message_handler(commands=['start'])             #ветка обработки команды "старт"
async def start_handler(message: types.message):
    user_id = message.from_user.id
    user_name = message.from_user.first_name
    user_full_name = message.from_user.fullname
    logging.info(f'{user_id=} {user_full_name=}, {time.asctime()}') #лог данных о пользователях
    await message.replay(f"Привет, {user_full_name}")

    for i in range(7):                  # напоминалка о том, что надо кодить
        time.sleep(2)

        await bot.send_message(user_id, MSG.format(user_name))


if __name__ == '__main__':          #эта часть не даёт боту завершить роаботу по выполнении
    executor.start_polling(dp)
