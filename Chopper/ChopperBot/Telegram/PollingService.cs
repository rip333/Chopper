
namespace Telegram;
public class PollingService
{
    private readonly IMessageService _messageService;
    private static int _lastUpdateId = 0;

    public PollingService(IMessageService messageService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
    }

    public async Task PollForUpdatesAsync()
    {
        try
        {
            var updates = await _messageService.GetUpdates(_lastUpdateId);

            if (updates?.result == null) return;
            foreach (var result in updates.result)
            {
                _lastUpdateId = result.update_id;
                Console.WriteLine(result.message.text ?? "");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}. {e.StackTrace}");
        }
    }

}