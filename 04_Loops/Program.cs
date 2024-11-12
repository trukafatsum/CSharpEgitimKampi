using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0)
            //        Console.WriteLine(i);
            //}



            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);




            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);




            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //        count++;
            //}

            //Console.WriteLine(count);



            //1-2-4-8-16-...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundereds;
            //int sum;

            //ones = number % 10;
            //tens = number % 100 / 10;
            //hundereds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundereds);

            //sum = ones + tens + hundereds;

            //Console.WriteLine(sum);

            #endregion


            Console.Read();
        }
    }
}

//Döngüler
//For Döngüsü
/*
 * Anlatılan:
for(x;y;z;)
x: başlangıç
y: bitiş
z: artış-azalış

Sıfırdan öğrenenler için anlaşılması zor bir anlatım.

*Tavsiye edilen anlatım:
*
*for(x;y;z;)
*x: for scope aralığında kullanılacak olan değişken çağırımı veya değişken tanımlanması ve başlangıç değeri atanması gereken alan
*y: döngünün devamlılığı için true olması gereken şartın/şartların tanımlandığı alan
*z: döngünün akışına yön verebilecek işlemlerin gerçekleştirileceği alan
*
*y false olduğu anda döngüden çıkar, veya şart scope aralığında tanımlanır ve break; ile çıkılabilir.
*
*Tavsiyenin gerekçesi olarak şunu söyleyebilirim ki, for döngüsünde herhangi bir parametre tanımlanmaksızın scope aralığında da bu bilgiler belirtilebilir. Örneğin;
*
* int i = 0; // Değişken tanımı
*for(;;)
*{
*
* if (i == 10) // Şart
*       break;
*       
* i++; // Gerçekleştirilecek olan işlem
*}
*/

//Aynı şekilde while ve do while içinde parametreler boş bırakılsa da şart ve işlemler içeride tanımlanabilir.

//While Döngüsü
/*
while (şart)
{
    işlemler
}
*/