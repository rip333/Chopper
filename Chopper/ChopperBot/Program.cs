using Telegram;

Console.WriteLine("CHOPPER BOT ONLINE.");

var token = await Utility.ConfigUtility.GetToken();

var httpClient = new HttpClient();
var pollingService = new PollingService(
        new MessageService(token, httpClient)
    );

while (true)
{
    await pollingService.PollForUpdatesAsync();
    await Task.Delay(250);
}
