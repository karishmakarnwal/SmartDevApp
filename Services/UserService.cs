using SmartDevApp.Interface;
using System.ComponentModel.DataAnnotations;

namespace SmartDevApp.Services
{
    public class UserService
    {
        private readonly IEmailService _emailService;
        private readonly IValidatorService _validatorService;
        private readonly ILoggerService _loggerService;

        public UserService(IEmailService emailService,
            IValidatorService validatorService,
            ILoggerService loggerService)
        {
            _emailService = emailService;
            _validatorService = validatorService;
            _loggerService = loggerService; 
        }

        public void RegisterUser()
        {
            _validatorService.ValidateUser();

            // Save User

            _emailService.SendWelcomeEmail();
        }
    }
}
