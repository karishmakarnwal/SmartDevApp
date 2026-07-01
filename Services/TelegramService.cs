using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class TelegramService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Sending Telegram");
        }
    }
}
