using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//для работы с Excel
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ExcelExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //название файла
            string fileName = @"./Телефонная книга.xlsx";

            //данные для справочника
            List<PhonebookStruct> Phonebook = new List<PhonebookStruct>
            {
                new PhonebookStruct{ObjName = "Рабочий",
                    Address = "Краснодарский край, г. Краснодар, ул. Ставропольская 1",
                    PhoneNumber = 8611236547},
                new PhonebookStruct{ObjName = "Менеджер",
                    Address = "Краснодарский край, г. Краснодар, Игнатова 23",
                    PhoneNumber = 8612358564},
                new PhonebookStruct{ObjName = "Директор",
                    Address = "Краснодарский край, г. Краснодар, Красная 159",
                    PhoneNumber = 8613658445},
            };

            //создаем Документы xlsx
            using (ExcelPackage excelFile = new ExcelPackage())
            {
                excelFile.Workbook.Properties.Author = "Zakhar Bushuev";
                excelFile.Workbook.Properties.Title = "Phonebook";
                excelFile.Workbook.Properties.Company = "ООО \"Компания рога и копыта\"";

                //добавляем лист
                ExcelWorksheet sheet = excelFile.Workbook.Worksheets.Add("Телефонный справочник");

                //делаем заголовок sheet.Cells[row,col]
                int row = 1;
                int col = 1;
                sheet.Cells[row, col].Value = "№, п/п";
                sheet.Cells[row, col+1].Value = "Наименование объекта";
                sheet.Cells[row, col+2].Value = "Адрес объекта";
                sheet.Cells[row, col+3].Value = "Номер телефона";

                //Наполняем таблицу записями
                foreach(var item in Phonebook)
                {
                    row++;
                    sheet.Cells[row, col].Value = row - 1;
                    sheet.Cells[row, col + 1].Value = item.ObjName;
                    sheet.Cells[row, col + 2].Value = item.Address;
                    sheet.Cells[row, col + 3].Value = item.PhoneNumber;
                    //форматируем ячейку номера "(861) 238-89-20"
                    sheet.Cells[row, col + 3].Style.Numberformat.Format = @"[<=9999999]###-##-##;(###) ###-##-##";
                }

                //ячейки-стиляги
                using(ExcelRange cells = sheet.Cells[sheet.Dimension.Address])
                {
                    //можно создать стиль и потом применять его к какому-то определенному диапазону
                    //var namedSytle = excelFile.Workbook.Styles.CreateNamedStyle("styleName");
                    //namedSytle.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    //namedSytle.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    //namedSytle.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    //namedSytle.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    //cells.StyleName = "styleName";

                    //можно вручную
                    cells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    cells.AutoFitColumns();
                }

                //сохраняем файл
                var bin = excelFile.GetAsByteArray();
                File.WriteAllBytes(fileName, bin);
            }
        }
        // Структура данных одной записи в стравочнике
        public struct PhonebookStruct
        {
            public string ObjName { get; set; }
            public string Address { get; set; }
            public long PhoneNumber { get; set; }
        }
    }
}
