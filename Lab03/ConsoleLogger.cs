using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;   
        }

        public override void Dispose()
        {
            //Nie implementujemy - korzystamy z konsoli systemowej
        }


    }
}
