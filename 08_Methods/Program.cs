using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer ---> Listele, ekle, sil, güncelle
            //void : geriye değer döndürmeyeceği anlamına gelen tanım

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen string Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldız");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Yıldız");
            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    Console.WriteLine(number1 + number2 + number3);
            //}

            //Sum(5, 6, 7);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string CountryCard(string counteryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke: {counteryName} - Başkent: {capital} - Bayrak Rengi: {flagColor}";
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    return number1 + number2;
            //}

            //Console.WriteLine(Sum(56,74));
            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    return result >= 50 ? $"{student} sınavı geçti \nOrtalama: {result}" : $"{student} sınavı geçemedi \nOrtalama: {result}";
            //}
            //Console.Write("Öğrenci adını giriniz: ");
            //string studentName = Console.ReadLine();
            //Console.Write("1.Sınav notunu giriniz: ");
            //int _exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sınav notunu giriniz: ");
            //int _exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3.Sınav notunu giriniz: ");
            //int _exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(ExamResult(studentName, _exam1, _exam2, _exam3));
            #endregion

            Console.Read();
        }
    }
}

