using System;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Readers *****\n");
            //Создать, сконфигурировать и открыть объект подключения
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=DESKTOP-LHPGC3M; Initial Catalog=AutoLot;Integrated Security=True";
                connection.Open();
                //Создать и сконфигурировать объект комманды, указав объект подключения в аргументе конструктора
                string sql = "Select * from Inventory";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                //Получить объект чтения данных с помощью ExecuteReader()
                using(SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    //Читаем базу данных построчно.
                    while(myDataReader.Read())
                    {
                        Console.WriteLine($"-> Make:{myDataReader["Make"]}, PetName:{myDataReader["PetName"]}, Color:{myDataReader["Color"]}.");
                    }
                }
            }
        }
    }
}
