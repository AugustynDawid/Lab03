using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    interface ILogger : IDisposable
    {
        void Log(params String[] messages);
    }
}
