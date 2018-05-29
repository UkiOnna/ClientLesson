using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        private const int SERVER_PORT = 3535;
        static void Main(string[] args)
        {
            Socket remoteServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), SERVER_PORT);

            try
            {
                Console.WriteLine("Соединяемся с сервером");
                remoteServerSocket.Connect(endPoint);
                Console.WriteLine("Соединено..");
                Console.WriteLine("Отправка...");
                remoteServerSocket.Send(Encoding.Default.GetBytes("ЛЕХА ВРЫЫЫЫЫЫВАЕТЕСЯЯЯЯ"));
                Console.WriteLine("Данные отправлены");
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                remoteServerSocket.Close();
                Console.WriteLine("Сеанс завершен.");
            }
            Console.ReadLine();
        }
    }
}
