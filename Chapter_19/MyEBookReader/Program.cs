using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net; // для WebClient
using System.Threading;
using System.Threading.Tasks;

namespace MyEBookReader
{
    class Program
    {
        static string theEBook;
        static void Main(string[] args)
        {
            GetBook();
            Console.ReadLine();
        }
        static void GetBook()
        {
            WebClient wc = new WebClient(); //для получение данных по url
            wc.DownloadStringCompleted += (s, eArgs) =>     //DownloadStringCompleted - событие которое инициируется при завершении получения данных 
            {
                theEBook = eArgs.Result;
                Console.WriteLine("Download complete");
                GetStats();
            };
            //закачка книги Дикинсона "История двух городов" ассинхронным методом
            //возможно потребуется посетить сайт 2 раза так как первый раз выскочит окно
            wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-8.txt"));
        }
        //извлечение индивидуальных слов содержащихся в переменной theEBook, и передачи строкового массива на обработку нескольким вспомогательным методам
        static void GetStats()
        {
            //получить слова из электронной книги
            string[] words = theEBook.Split(new char[]
                { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/'}, StringSplitOptions.RemoveEmptyEntries);//разбивка текста на слова

            string[] tenMostCommon = null;
            string longestWord = string.Empty;
            //вызов параллельных задач? TPL будет использовать все доступные процессоры машины для вызова каждого метода параллельно.
            Parallel.Invoke(
                () =>
                {
                    //Найти 10 наиболее встречающихся слов
                    tenMostCommon = FindTenMostCommon(words);
                },
                () =>
                {
                    //получить самое длинное слово
                    longestWord = FindLongestWord(words);
                });
            //когда все задачи завершены, построить строку, показывающую всю статистику в окне сообщений
            StringBuilder bookStats = new StringBuilder("Ten Most Common Words are:\n");
            foreach (string s in tenMostCommon)
                bookStats.AppendLine(s);
            bookStats.AppendFormat($"Longest word is: {longestWord}");
            bookStats.AppendLine();
            Console.WriteLine(bookStats.ToString(), "Book info");
        }
        //используем LINQ Для получения списка из 10 наиболее часто встречающихся слов
        static string[] FindTenMostCommon(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            string[] commonWords = (frequencyOrder.Take(10)).ToArray();
            return commonWords;
        }
        //используем LINQ Для получения самого длинного слова
        static string FindLongestWord(string[] words)
        {
            return (from w in words orderby w.Length descending select w).FirstOrDefault();
        }

    }


}
