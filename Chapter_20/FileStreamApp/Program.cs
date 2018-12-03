using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fin with FileStream *****\n");

            //создаем объект FileStream
            using (FileStream fStream = File.Open(@"myMessage.dat", FileMode.Create)) //использование using позволяет высвободить все используемые ресурсы при завершении блока
            {
                //кодирование строки в массив байтов
                string msg = "Hello!";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                //Записываем массив байтов в файл
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                //сброс внутренней позиции потока
                fStream.Position = 0;

                //чтения данных из файла и отображение данных на экране консоли
                Console.WriteLine("You message as an array of bytes: ");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for(int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.WriteLine(bytesFromFile[i]);
                }
                //отображение декодированного сообщения
                Console.Write("\nDecoded Message: ");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
        }
    }
}
