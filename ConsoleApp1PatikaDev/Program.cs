using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1PatikaDev
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ekrana bastırma
            Console.WriteLine("Hello World!");

            //Klavyeden giriş yapma
            Console.WriteLine("Lütfen adınızı girin: ");
            string name = Console.ReadLine();

            //Klavyeden aldığımız veriyi ekrana bastırma 
            Console.WriteLine("Hoşgeldin " + name);

            //Değişkenleri tanımlama ve ekrana bastırma
            byte a = 1;
            Console.WriteLine(a);
            sbyte b = 2;
            Console.WriteLine(b);
            short c = 14;
            Console.WriteLine(c);
            ushort d = 12;
            Console.WriteLine(d);
            int i = 1548;
            Console.WriteLine(i);
            long l = 8;
            Console.WriteLine(l);
            float f = 25;
            Console.WriteLine(f);
            double e = 84;
            System.Console.WriteLine(e);
            string str = "Zehra Çakır";
            Console.WriteLine(str);
            bool b1 = true;
            Console.WriteLine(b1);
            bool b2 = false;
            Console.WriteLine(b2);

            //Datetime Kullanımı
            DateTime dt = DateTime.Now;
            Console.WriteLine("Şu anın tarihi: " + dt);

            //object
            object x = 12;
            Console.WriteLine(x);
            object y = "zehracakir";
            Console.WriteLine(y);
            object z = 4.3;
            Console.WriteLine(z);

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Zehra";
            Console.WriteLine(str1);

            //integer ifadeler
            int t = 2;
            int r = 4;
            //toplama işlemi
            Console.WriteLine(t + r);
            //çıkarma işlemi 
            Console.WriteLine(t - r);
            //çarpma işlemi
            Console.WriteLine(t * r);
            //bölme işlemi
            Console.WriteLine(t / r);

            //boolean ifadeler
            bool bool1 = 10 > 5;
            Console.WriteLine(bool1);

            //Değişken dönüşümleri
            string number = "123";
            int number1 = 456;
            string newStringNumber = number + number1.ToString();
            Console.WriteLine("string->new number= " + newStringNumber);
            int newIntNumber = Convert.ToInt32(number) + number1;
            Console.WriteLine("int->new number= " + newIntNumber);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Date: " + datetime);

            //Hour
            string hour = DateTime.Now.ToString("HH/mm");
            Console.WriteLine("Hour: " + hour);


            /*OPERRATÖRLER DERSİ
             * ATAMA VE İŞLEMLİ ATAMA */

            int m = 3;
            int n = 3;
            int k = k + 2;
            Console.WriteLine(k);
            k += 2;
            Console.WriteLine(y);
            k /= 1;
            Console.WriteLine(y);
            m *= 2;
            Console.WriteLine(m);


            // MANTIKSAL OPERETÖRLER
            // && , || !

            bool isSucces = true;
            bool isCompleted = false;

            if (isSucces && isCompleted)
                Console.WriteLine("Perfesct!");

            if (isSucces || isCompleted)
                Console.WriteLine("Great!");

            if (isSucces && isCompleted)
                Console.WriteLine("Fine!");


            //İLİŞKİSEL OPERATÖRLER
            // <, >, <=, >=, ==, !=

            int a1 = 3;
            int b3 = 4;
            bool sonuc = a1 < b3;

            Console.WriteLine(sonuc);
            sonuc = a1 > b3;
            Console.WriteLine(sonuc);
            sonuc = a1 >= b3;
            Console.WriteLine(sonuc);
            sonuc = a1 <= b3;
            Console.WriteLine(sonuc);
            sonuc = a1 == b3;
            Console.WriteLine(sonuc);
            sonuc = a1 != b3;
            Console.WriteLine(sonuc);

            //ARİTMETİK OPERATÖRLER
            // /,*,+,- İFADELERİDİR

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sayi1);
            sonuc1 = sayi1++;

            // % mod almak için kullanılan ifade kalanı getiren ifade


            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

        }
    }
}


