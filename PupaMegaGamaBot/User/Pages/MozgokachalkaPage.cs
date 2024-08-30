using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace PupaMegaGamaBot.User.Pages
{
    public class MozgokachalkaPage : IPage
    {
        public PageResult Handle(Update update, UserState userState)
        {
            throw new NotImplementedException();
        }

        public PageResult View(Update update, UserState userState)
        {
            var text = "СТРАНИЦА МОЗГОКАЧАЛКИ";

            var replyMarkup = GetReplyMarkup();

            return new PageResult(text, replyMarkup)
            {
                UpdatedUserState = new UserState(this, userState.UserData)
            };
        }

        private ReplyMarkupBase GetReplyMarkup()
        {
            return new ReplyKeyboardMarkup(
                [
                    [
                        new KeyboardButton("ПОДРОБНЕЕ"),
                        new KeyboardButton("СМОТРЕТЬ ЭЖФИР")
                    ],
                    [
                        new KeyboardButton("ВСТУПИТЬ")
                    ],
                    [
                        new KeyboardButton("НАЗАД")
                        ]
                    ])
            {
                ResizeKeyboard = true
            };
        }
    }
}