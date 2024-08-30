using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace PupaMegaGamaBot.User.Pages
{
    public class NotStartedPage : IPage
    {
        public PageResult Handle(Update update, UserState userState)
        {
            return new StartPage().View(update, userState);
        }

        public PageResult View(Update update, UserState userState)
        {
            return null;
        }
    }
}
