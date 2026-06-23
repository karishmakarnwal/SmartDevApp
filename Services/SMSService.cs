using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class SMSService : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS");
        }
    }
}
