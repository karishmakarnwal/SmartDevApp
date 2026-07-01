using SmartDevApp.Interface;
using System.ComponentModel.DataAnnotations;

namespace SmartDevApp.Services
{
    public class UserService
    {
        private readonly IEmailService _emailService;
        private readonly IValidatorService _validatorService;
        private readonly ILoggerService _loggerService;
        private readonly IEnumerable<INotificationService> _notificationServices;

        public UserService(IEmailService emailService,
            IValidatorService validatorService,
            ILoggerService loggerService,
            IEnumerable<INotificationService> notificationServices) // Dear DI Container, Give me ALL the notification services you know about.
        {
            _emailService = emailService;
            _validatorService = validatorService;
            _loggerService = loggerService;

            _notificationServices = notificationServices; //DI Container thinks: "Ah, I know 3 services!" EmailService SmsService WhatsAppService So it injects: [EmailService,  SmsService,  WhatsAppService ] 
        }

        public void RegisterUser()
        {
            // Validate user
             
            _validatorService.ValidateUser();

            // Save User

            // .......

            // Send Welcome Email

            _emailService.SendWelcomeEmail();

            // Send Notifications

            foreach (var notification in _notificationServices) {
                notification.Send();        // send all three email, sms and whatsapp with single line
                                            // LSP also implemented. added telegram service too but no changes were made to UserService
            }

        }
    }
}
