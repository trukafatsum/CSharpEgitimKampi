using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.Net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");

            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------");

            SqlConnection connection = new SqlConnection("Data Source=.\\SQLExpress; initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from tblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
/*
SQL Veritabanı Oluşturma
SQL Tablo Oluşturma
SQL Veri Türleri (bit, char, date, datetime, decimal, int, nvarchar, varchar, tiny int)

PrimaryKey - Identity Spesification

DML Komutları - Select Kullanımı

-------------------------------------
SqlConnection ile sql bağlantısı oluşturduk,
SqlCommand ile instance oluşturarak sorgumuzu yazdık,
SqlDataAdapter ile instance oluşturarak bu köprü görevi görecek yapıya komutumuzu verdik,
DataTable insantce oluşturduk,
dataTable içerisini adapter aracılığıyla doldurduk, yani komut ile çektiğimiz verileri, datatable'a aktarmış olduk,

var değişkeni : biliyorsunuz, var nedir ..

 */