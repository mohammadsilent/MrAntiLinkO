using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Helpers;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.Payments;
using Newtonsoft.Json;

namespace AntiLink
{
    class Program
    {

       static void Main(string[] args)
        {
            int offset = 0;
            Update temp = null;
            TelegramBotClient bot = new TelegramBotClient("563786465:AAHLu52kTPzVuhI5SGRrjhmi8DWAzZLi8uY");
            try
            {
                while (true)
                {
                    var x = Task.Run(async () => bot.GetUpdatesAsync(offset, 10)).Result;
                    foreach (var u in x.Result)
                    {
                        switch (u.Type)
                        {
                            case UpdateType.Message:
                                temp = u;
                                bot.SendTextMessageAsync(temp.Message.Chat.Id, "Hi");
                                break;
                        }

                        offset = u.Id + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                { }

            }

        }
    }
}