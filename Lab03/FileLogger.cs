using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab03
{
    class FileLogger : WriterLogger
    {
        //protected TextWriter writer;
        private bool disposed;

        public override void Dispose()
        {
            writer.Dispose();
            disposed = true;
        }

        public FileLogger(string path)
        {
            this.writer = new StreamWriter(path, true);
            disposed = false;
        }

         ~FileLogger()
        {
            this.Dispose();
        }
    }
}
