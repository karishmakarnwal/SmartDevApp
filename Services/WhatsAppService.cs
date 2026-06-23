using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class WhatsAppService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Sending WhatsApp message");
        }
    }
}
