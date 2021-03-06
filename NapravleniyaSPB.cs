﻿using System.IO;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Text.Json;

namespace TelegramBotHSE
{
    public static class NapravleniyaSPB
    {
        /// <summary>
        /// Основное меню по направлениям в Питере
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SPBFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("SPBFacultetiSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Ниже представлены все доступные направления:", replyMarkup: KeyBoard);
        }
    }
}
