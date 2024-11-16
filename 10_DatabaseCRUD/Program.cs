using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data source= .\\SQLExpress; initial catalog=EgitimKampiDb; integrated security=true";

            //connection.Open();
            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "insert into tblCategory (CategoryName) values (@p1)";
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Data source= .\\SQLExpress; initial catalog= EgitimKampiDb; integrated security=true;";

            //connection.Open();
            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "insert into tblProduct (ProductName,ProductPrice,ProductStatus) values (@name,@price,@status)";
            //command.Parameters.AddWithValue("@name",productName);
            //command.Parameters.AddWithValue("@price", productPrice);
            //command.Parameters.AddWithValue("@status", true);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı!");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection conn = new SqlConnection("Data source= .\\SQLExpress; initial catalog= EgitimKampiDb; integrated security=true");

            //conn.Open();

            //SqlCommand command = new SqlCommand("Select * From tblProduct",conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();

            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //conn.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün ID: ");
            //int ProductID = int.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data source= .\\SQLExpress; initial catalog= EgitimKampiDb; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Delete from tblProduct where ProductId=@productId",conn);
            //cmd.Parameters.AddWithValue("@productId", ProductID);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Ürün silme işlemi başarılı!");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Ürün satışa devam ediyor mu? Evet/Hayır");
            //Console.Write("Ürün Durumu: ");
            //bool productStatus = Console.ReadLine().ToLower() == "evet";

            //SqlConnection conn = new SqlConnection("Data source= .\\SQLExpress; initial catalog= EgitimKampiDb; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Update tblProduct Set ProductName=@productName,ProductPrice=@productPrice,ProductStatus=productStatus Where ProductId=@productId", conn);
            //cmd.Parameters.AddWithValue("@productId",productId);
            //cmd.Parameters.AddWithValue("@productName",productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", productStatus);
            //cmd.ExecuteNonQuery();

            //conn.Close();

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine($"Ürün adı {productName}, fiyatı {productPrice}₺ ve durumu {(productStatus ? "satışa açık" : "satış dışı")} olarak güncellenmiştir!");

            #endregion


            Console.Read();
        }
    }
}

//CRUD : Create Read Update Delete