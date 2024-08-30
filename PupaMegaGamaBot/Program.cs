using PupaMegaGamaBot.Storage;
using PupaMegaGamaBot.User;
using PupaMegaGamaBot.User.Pages;
using Telegram.Bot;
using Telegram.Bot.Types;

UserStateStorage storage = new UserStateStorage();

var telegramApiClient = new TelegramBotClient("");

telegramApiClient.StartReceiving(updateHandler: HandleUpdate, pollingErrorHandler: HandlePoolingError);

var user = await telegramApiClient.GetMeAsync();
Console.WriteLine($"Начали слушать апдейты с {user.Username}");
Console.ReadLine();

async Task HandlePoolingError(ITelegramBotClient client, Exception exception, CancellationToken token)
{
    Console.WriteLine(exception.Message);
}

async Task HandleUpdate(ITelegramBotClient client, Update update, CancellationToken token)
{
    if (update.Message?.Text == null)
    {
        return;
    }

    var telegramUserId = update.Message.From.Id;
    Console.WriteLine($"update_id={update.Id}, telegramUserId={telegramUserId}");

    var isExistUserState = storage.TryGet(telegramUserId, out var userState);
    if (!isExistUserState)
    {
        userState =new UserState(new NotStartedPage(), new UserData());
    }
    Console.WriteLine($"update_id={update.Id}, CURRENT_userState={userState}");

    var result = userState!.Page.Handle(update, userState);
    Console.WriteLine($"update_id={update.Id}, send_text={result.Text}, UPDATED_UserState={result.UpdatedUserState}");

    await client.SendTextMessageAsync(
        chatId: telegramUserId,
        text: result.Text,
        replyMarkup: result.ReplyMarkup);

    storage.AddOrUpdate(telegramUserId, result.UpdatedUserState);
}