using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Dispose()
        {
            foreach(ILogger l in loggers)
            {
                l.Dispose();
            }
        }

        public void Log(params string[] messages)
        {
            foreach (ILogger l in loggers)
            {
                string messageStd = "";
                DateTime time = DateTime.Now;
                DateTime utcTime = DateTime.UtcNow;

                // when we want local time with offset
                messageStd = time.ToString("yyyy-MM-ddTHH:mm:sszzz");

                messageStd += " ... ";

                
                for (int i = 1; i < messages.Length; i++)
                {
                    messageStd += messages[i] + " ";
                }

                
                l.Log(messageStd);
            }
        }
    }
}
