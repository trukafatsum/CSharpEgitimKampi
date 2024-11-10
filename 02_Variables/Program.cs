using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler mantıksal, metinsel, sayısal olarak ayrılır. Bunun yanı sıra sayısal ise tam sayı ve ondalıklı sayı olarak ayrılır.
            //Ondalıklı sayılar için double, decimal, float değişken türleri kullanılmaktadır.

            /*Önemli!*/
            //double number = 4.85; olarak girdiğimiz değer konsol ekranında bizi 4,85 olarak karşılar.
            //Yani ondalıklı kısımlar için kod ekranımızda '.' nokta kullanmaktayız.
            //Ekranda yazdırılan ise ',' virgül olmaktadır. Ayrıca konsoldan ondalıklı değer alırken ',' virgül kullanılmalıdır.

            #region Double Değişkenler
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            Console.OutputEncoding = Encoding.UTF8; // System.Text kütüphanesi içerisinde bulunan Encoding sınıfından UTF8'i dahil eder. '₺' ifadesini konsola yazdırmamızı sağlar.
                                                    //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + '₺');
                                                    //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + '₺');
                                                    //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + '₺');
                                                    //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + '₺');
                                                    //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + '₺');
                                                    //Console.WriteLine();
                                                    //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: "+ applePrice + '₺' + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + '₺');
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: "+ orangePrice + '₺' + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + '₺');
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: "+ strawberryPrice + '₺' + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + '₺');
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: "+ potatoPrice + '₺' + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + '₺');
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: "+ tomatoPrice + '₺' + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + '₺');
            //Console.WriteLine();
            //Console.WriteLine();
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + '₺');

            //// Scope kavramı süslü parantezlerin arasıdır {}

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //string değişkenler " ile tanımlanırken, char değişkenler ' ile tanımlanır.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri - String Değişkenler

            //Console.WriteLine("***** CSharp Havayolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, televisionPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //televisionPrice = 12000;

            //int shoeCount, computerCount, chairCount, televisionCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //televisionCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + televisionCount * televisionPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + '₺');

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümler

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion


            Console.Read();

        }
    }
}

//Char değişkenlerde Sezar şifreleme hakkında bilgi verildi.

//Kullanılan metotlar
/*
 * int.Parse
 * 
 */