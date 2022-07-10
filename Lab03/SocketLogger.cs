using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class SocketLogger : ILogger
    {
        private bool disposed;
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        public void Log(params string[] messages)
        {


            foreach (var message in messages)
            {
                byte[] requestBytes = Encoding.UTF8.GetBytes(message);
                clientSocket.Send(requestBytes);

                /*  Write response to console ?
                byte[] responseBuffer = new byte[1024];
                int responseSize = clientSocket.Receive(responseBuffer);

                string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize);
                */
            }
               
            }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.clientSocket.Dispose();

                this.disposed = true;
            }
        }
    }
}
