using Telegram.Bot.Types;

namespace PupaMegaGamaBot.User.Pages
{
    public class EnterToITPage : IPage
    {
        public EnterToITPage()
        {
        }

        public PageResult Handle(Update update, UserState userState)
        {
            throw new NotImplementedException();
        }

        public PageResult View(Update update, UserState userState)
        {
            var text = "СТРАНИЦА ВОЙТИ В АЙТИ";

            return new PageResult(text);
        }
    }
}