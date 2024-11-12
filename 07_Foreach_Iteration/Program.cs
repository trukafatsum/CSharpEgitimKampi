using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Iterasyonu
            //Foreach(1 2 3 4);
            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4: Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //        Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>() { 1,2,3,4,5,8};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult  = 0;

            //    //Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            
            ////Sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("-----------------------------");
            //}

            #endregion


            Console.Read();
        }
    }
}

//Foreach Döngüsü olarak sıkça kullanılsa da aslında bu tanım yanlıştır.

//Döngü : Belirli bir kombinasyon eşliğinde çalışan ve belirli bir şarta bağlı olan periyodik işlemler gerçekleştiren yapılanmadır.
//İterasyon : Iterasyon mantığında ise ne kombinasyon, ne de şart vardır. Iterasyonda sonraki veri, öteki veri anlamına gelen itere etme fiili vardır. Veri kümesi üzerinde işlem yapmamızı, yani verileri elde etmemizi sağlayan yapılanmadır.

//Döngülerde herhangi bir bağımlılık yoktur, foreach ise veri kümesine bağımlıdır.
//Veri kümesi değiştiği taktirde foreach patlar.

/******************************************************\
 * Bu eğitim kampına sıfırdan başlayan arkadaşların aklında çok fazla soru olacaktır. Bu ders için örneğin şu sorularla karşılaşılması mümkündür:
 * string değişken üzerinde foreach nasıl kullanılıyor?
 * string değişken üzerinde foreach kullanabiliyorsak, diğer değişkenlerde de kullanabilir miyiz?
 * 
 * Değişkenler konusunda teorik bilgi anlatımını yetersiz buluyorum, primitive variables, reference variables.. tarzı bir anlatım ve her birinin kullanımına ilişkin daha ayrıntılı bilgi verilmesi gerekirdi.
 * Bunu söylememin sebebi, öğrenmeye yeni başlayan veya henüz öğrenememiş, aklında sürekli soru işareti kalan arkadaşları aydınlatmak açısından ele alınmalıydı.
 * 
 * Eleştirirken objektif olarak yaklaşmaya çalışıyorum, elbette Murat Yücedağ hocamız teorik konulara derinlemesine girmesede, yeterli bilgi seviyesine sahip ve pratikte bunları güzel bir şekilde ele almaktadır, samimi bir anlatıma ve yaklaşıma sahiptir.
 * Şunu da unutmamak gerekir ki, eyleme geçmeyen hiçbir düşüncenin ne kadar iyi olduğunun bir önemi yoktur.
 * 
 * Gelelim sorulara, string değişkenler üzerinde foreach kullanılabiliyor, bunun sebebi string'in özünde bir char dizisi olmasından kaynaklanıyor.
 * Diğer değişkenlerde ise foreach doğrudan kullanılamaz, ayrıca primitive variables konusuna göz atmanızı öneririm.
 * 
 * string referans türlü bir değişkendir, referans konusu OOP'de yer alır.
 * 
 */