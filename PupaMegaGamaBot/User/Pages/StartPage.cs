using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;

namespace PupaMegaGamaBot.User.Pages
{
    public  class StartPage : IPage
    {
        public PageResult View(Update update, UserState userState)
        {
            var text = "Привет, это начальная страница, выбери одну из двух кнопок";
            var replyMarkyp = GetReplyKeyBoard();

            return new PageResult(text, replyMarkyp)
            {
                UpdatedUserState = new UserState(this, userState.UserData)
            };
        }

        public PageResult Handle(Update update, UserState userState)
        {
            if (update.Message == null)
                return new PageResult("Нажмите на кнопки", GetReplyKeyBoard());

            if (update.Message.Text == "МОЗГОКАЧАЛКА")
            {
                return new MozgokachalkaPage().View(update, userState);
            }

            if (update.Message.Text == "ВОЙТИВАЙТИ")
            {
                return new EnterToITPage().View(update, userState);
            }

            return null;
        }

        private ReplyKeyboardMarkup GetReplyKeyBoard()
        {
            return new ReplyKeyboardMarkup(
                [
                    [
                        new KeyboardButton("МОЗГОКАЧАЛКА")
                    ],
                    [
                        new KeyboardButton("ВОЙТИВАЙТИ")
                    ]
                    ])
            {
                ResizeKeyboard = true
            };
        }
    }
}
