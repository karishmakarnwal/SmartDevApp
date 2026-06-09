using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class UserService
    {
        public readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            _emailService = emailService; 
        }

        public void SendEmailToUser()
        {
            _emailService.SendEmail();
        }
    }
}
