using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace MicrosoftExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //List содержит 2 счета
            var bankAccounts = new List<Account>
            {
                new Account
                {
                    ID = 345678,
                    Balance = 541.27,
                },
                new Account
                {
                    ID = 1230221,
                    Balance = 127.44,
                }
            };

            //Добавляем счета в новый файл Excel
            DisplayInExcel(bankAccounts);
        }

       //Создаем лист книги
       static void DisplayInExcel(IEnumerable<Account> accounts)
        {
            //создаем объект приложения и делаем его видимым
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            //создаем новую рабочую книгу - она автоматически становится активной
            excelApp.Workbooks.Add();
            //этот пример использует только одну таблицу
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            //вставляем значения в первые два столбца первой строки (заголовок)
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";

            //помещаем данные о счетах в таблицу
            var row = 1;
            foreach(var acct in accounts)
            {
                row++;
                workSheet.Cells[row, "A"] = acct.ID;
                workSheet.Cells[row, "B"] = acct.Balance;
            }

            //Вычисляем сумму по всем счетам
            Excel.Range rng = workSheet.Range["B4"]; // указываем ячейку где будет прописанна сумма
            rng.Formula = "=СУММ(B2:B3)";
            rng.FormulaHidden = false;

            //форматирование таблицы - выделяем границы у ячейки суммы
            Excel.Borders border = rng.Borders;
            border.LineStyle = Excel.XlLineStyle.xlContinuous;


            //чтобы ширина столбца изменилась в соответствии с содержимым
            //workSheet.Columns.AutoFit();
            ((Excel.Range)workSheet.Columns[1]).AutoFit();
            ((Excel.Range)workSheet.Columns[2]).AutoFit();

            //строим круговую диаграмму
            Excel.ChartObjects chartObjs = (Excel.ChartObjects)workSheet.ChartObjects();
            Excel.ChartObject chartObj = chartObjs.Add(50, 100, 300, 300);
            Excel.Chart xlChart = chartObj.Chart;
            Excel.Range rng2 = workSheet.Range["B1:B3"];
            //Устанавливаем тип диаграммы
            xlChart.ChartType = Excel.XlChartType.xlColumnClustered;

            //устанавливаем источник даных
            xlChart.SetSourceData(rng2);
        }
    }

    //Создание банковских счетов
    public class Account
    {
        public int ID { get; set; }
        public double Balance { get; set; }
    }
}
