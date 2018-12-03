using System.Drawing;
using System.Threading;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Shapes;

namespace DataParallelismWithForEach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource cancelToken = new CancellationTokenSource();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //используется для сообщениявсем рабочим потокам о необходимости остановки
            cancelToken.Cancel();
        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            //Запустить новую задачу для обработки файлов
            Task.Factory.StartNew(() => ProcessFiles());
        }

        private void ProcessFiles()
        {
            //настройка параллельности
            //использовать экземпляр ParallelOptions для хранения CancellationToken
            ParallelOptions parOpts = new ParallelOptions();
            parOpts.CancellationToken = cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            //Закгружаем все вайлы *.jpg, и делаем новую директорию для модицированных фото
            string[] files = Directory.GetFiles(@"d:\progs\pro-csharp-7-master\pro-csharp-7-master\Chapter_19\TestPictures\", "*.jpg", SearchOption.AllDirectories);
            string newDir = @".\ModifiedPictures";
            Directory.CreateDirectory(newDir);

            try
            {
                //обработка изображений в параллельной манере
                Parallel.ForEach(files, parOpts, currentFile =>
                {
                    parOpts.CancellationToken.ThrowIfCancellationRequested();

                    string filename = Path.GetFileName(currentFile);
                    using (Bitmap bitmap = new Bitmap(currentFile)) //когда выйдем из блока ресурс будет высвобожден, путем фонового вызова Dispose()
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone); // поворачиваем изображение на 180 градусов
                        bitmap.Save(Path.Combine(newDir, filename)); // сохраняем изображение при этом абсолютный путь получаем путем комбинирования новой директории и имени файла

                        // чтобы из вторичных потоков получить доступ к элементам управления (UI)
                        // воспользуемся методом Dispatcher.Invoke которому в конструктор передадим анонимный делегат
                        this.Dispatcher.Invoke((Action)delegate
                            {
                                this.Title = $"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}";
                            }
                        );
                    }
                }
                );
                this.Dispatcher.Invoke((Action)delegate {
                    this.Title = "Done!";
                });
            }
            catch(OperationCanceledException ex)
            {
                this.Dispatcher.Invoke((Action)delegate {
                    this.Title = ex.Message;
                });
            }
        }
    }
}
