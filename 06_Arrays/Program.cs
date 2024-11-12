using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);



            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);



            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    {
            //        if (numbers[i] % 3 == 0)
            //        {
            //            Console.WriteLine(numbers[i]);
            //        }
            //    }
            //}



            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 45, 75, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != 0)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(numbers[i]);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i != 0)
            //        Console.Write(" ");
            //    Console.Write(numbers[i]);
            //}



            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "ayşegül");
            //Console.WriteLine(index);


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    if (i != 0)
            //        Console.Write(" ");
            //    Console.Write(cities[i]);
            //}


            #endregion

            #region Dizideki Tek ve Çift Sayıları Yazdırma
            //int[] numbers = { 101, 212, 513, 884, 945, 456, 337, 488, 89, 910 };

            //Console.Write("Çift Sayılar:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.Write(" " + numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("Tek Sayılar:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.Write(" " + numbers[i]);
            //    }
            //}
            #endregion


            Console.Read();

        }
    }
}

//Dizi anlatımı yüzeysel olacak, array sınıfından bahsedilmeyeceği söylendi.
//Index hakkında bilgi verilmedi, pratikte anlaşılması bekleniyor. Bilmeyenler için c#'ta index değer default olarak 0 ile başlar. Yani 4 elemanlı bir dizinin ilk elemanı 0. indexte yer alır. Haliyle 4.index çağırılırsa, runtime da hata ile karşılaşırız.
//Dizi tanımlandıktan sonra değer verilmeyen eleman çağırılırsa, değişken türünün default değeri yazdırılır.
//String interpolation kullanılıyor ancak bunun ile ilgili bilgi verilmiyor. C# 6.0 ile gelen bir özelliktir, bu özellik sayesinde string içerisine süslü parantezler aracılığıyla değişken çağırılabilmektedir. örn. string ad = "Ahmet"; Console.Write($"Adınız: {ad}");

//Dizi metotları
/* 
 * Length metodu kullanıldı, dizinin uzunluğunu bize getirir
 * Sort (şort değil :) dizideki elemanları alfa-numerik olarak sıralar // Array sınıfından Sort metodu çağırılarak parametreye tanımladığımız dizi verildi.
 * Reverse dizideki elemanların sıralarını tersine çevirir { 1, 2, 3, 4, 5} => { 5, 4, 3, 2, 1}
 * IndexOf dizideki x elemanın index değerini getirir, IndexOf(diziAdi,eşleşecek/aranacak değer);
 * Max dizinin en büyük elemanını getirir
 * Min dizinin en küçük elemanını getirir
 */
