using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab03
{
    
    
        public abstract class WriterLogger : ILogger
        {
            protected TextWriter writer;

            public virtual void Log(params string[] messages)
            {

            foreach (string message in messages)
            {
                writer.Write(message + System.Environment.NewLine);
                writer.Flush();
            }
        }

            public abstract void Dispose();
        }
    
}
