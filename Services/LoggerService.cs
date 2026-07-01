using SmartDevApp.Interface;

namespace SmartDevApp.Services
{
    public class LoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logging data");
        }
    }
}
