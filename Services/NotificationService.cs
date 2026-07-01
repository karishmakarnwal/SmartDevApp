using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class NotificationService : INotificationService
    {
        private readonly EmailService _emailService;
        private readonly SMSService _sMSService;
        private readonly WhatsAppService _whatsAppService;
        private readonly TelegramService _telegramService;
        public NotificationService(EmailService emailService,
            SMSService sMSService,
            WhatsAppService whatsAppService,
            TelegramService telegramService)
        {
            _emailService = emailService;
            _sMSService = sMSService;
            _whatsAppService = whatsAppService;
            _telegramService = telegramService;
        }
        public void Send()
        {
            _emailService.Send();
            _sMSService.Send();
            _whatsAppService.Send();
            _telegramService.Send();
        }
    }
}
