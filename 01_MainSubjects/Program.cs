// Bu satır (using ...;), C# dilinde kullanılan kütüphaneleri (library) projeye dahil eder.
// Kütüphaneler, programın bazı işlevlerini yerine getirmesi için gerekli olan hazır kodları içerir.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects  // Bu, projenin (programın) adıdır. Projeyi tanımlamak için kullanılan bir isimdir.
{
    // "internal" erişim belirleyici, bu sınıfın yalnızca bu projede (assembly) erişilebilir olmasını sağlar.
    internal class Program  // "Program" adlı bir sınıf oluşturuluyor. Sınıf, bir nesne ya da işlem tanımını içerir.
    {
        // "static" anahtar kelimesi, bu metodun sınıfın bir örneği oluşturulmadan doğrudan çağrılabileceğini belirtir.
        // "void", metodun herhangi bir değer döndürmediğini ifade eder.
        // "Main", programın çalışmaya başladığı yer. Bu metodun içindeki kodlar ilk çalıştırılır.
        // "string[] args", komut satırından alınan parametreleri tutan bir dizidir. 
        static void Main(string[] args)
        {
            // Program çalışmaya başladığında burada yapılacak işlemler yazılır.

            // Konsola bir mesaj yazdırmak için Console.WriteLine() kullanılır.
            // Bu fonksiyon, ekranın üzerine yazı yazmanıza olanak sağlar.
            //Console.WriteLine("Merhaba, Dünya!");  // Ekrana "Merhaba, Dünya!" yazdırılır.
            //Console.Write("Selam");

            #region Yazdırma Komutları

            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Ara Soğuklar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri ******");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            //string customerName, customerSurname, customerPhone, customerEmail, disctrict, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@mail.com";
            //disctrict = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + disctrict + "/" + city);
            //Console.WriteLine("---------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@mail.com";
            //disctrict = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + disctrict + "/" + city);
            //Console.WriteLine("---------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger: " + hamburgerPrice + '₺');
            //Console.WriteLine("-----Pizza: " + pizzaPrice + '₺');
            //Console.WriteLine("-----Kola: " + cokePrice + '₺');
            //Console.WriteLine("-----Su: " + waterPrice + '₺');
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı ****");

            //Console.WriteLine();
            
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + '₺');
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + '₺');
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + '₺');
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + '₺');
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + '₺');
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + '₺');

            //Console.WriteLine();

            //int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;

            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + '₺');

            #endregion


            /*
             * Burada, program daha karmaşık işlemler yapabilir.
             * Örneğin kullanıcıdan giriş alabilir, veritabanına veri gönderebilir 
             * ya da bir dosya okuma yazma işlemi gerçekleştirebilir.
             */
            // Programın burada sonlanmasını beklemek için bir tuşa basılmasını bekleyebiliriz:
            Console.ReadKey();  // Kullanıcı bir tuşa bastığında program sonlanır.
            
        }
    }
}

///Kullanılan metotlar
/*
 * Console.WriteLine(); Konsol ekranına mantıksal, metinsel veya sayısal ifade yazdırır ve sonraki işlem için alt satıra iner.
 * Console.Write(); Konsol ekranına mantıksal, metinsel veya sayısal ifade yazdırır.
 * Console.Read(); Konsol ekranına girilen karakterleri string olarak alır.
 * Console.ReadKey(); Konsol ekranına girilen tek karakteri char olarak alır.
 */

///Kategorize etmek için kullanılan #region RegionName ...  #endregion

/// İncelenen değişkenler (variables)
/*
 * string : metinsel/alfabetik olarak anlatılsada aslında karakter barındıran bir değişken türüdür.
 * int : sayısal değişken türüdür. İçerisinde sadece -2.147.483.648 ~ 2.147.483.647 arası tam sayı barındırabilir.
*/

//İsimlendirme standartlarından biri 'Camel Case' : Değişken isimlendirmede örnek: customerName, metot isimlendirmede örnek: CustomerGetName.
//Tek satırda aynı türde birden fazla değişken tanımlanabilir. örnek: string customerName, customerSurname, customerPhone;

