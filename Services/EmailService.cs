using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class EmailService : IEmailService, INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Sending Email");
        }

        public void SendWelcomeEmail()
        {
            Console.WriteLine("Sending Welcome Email");
        }
    }
}
