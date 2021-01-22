using System;

namespace OOP3
{
    partial class DatabaseLoggerService
    {
        class FileLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya Loglandı");
            }
        }
}
