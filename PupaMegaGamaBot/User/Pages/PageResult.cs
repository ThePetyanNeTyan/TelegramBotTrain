using Telegram.Bot.Types.ReplyMarkups;

namespace PupaMegaGamaBot.User.Pages
{
    public class PageResult
    {
        public string Text { get; }
        public ReplyMarkupBase ReplyMarkup { get; }
        public UserState UpdatedUserState { get; set; }

        public PageResult(string text, ReplyMarkupBase replyMarkup)
        {
            Text = text;
            ReplyMarkup = replyMarkup;
        }

        public PageResult(string text)
        {
            Text = text;
        }

    }
}