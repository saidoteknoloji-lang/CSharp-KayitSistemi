using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Adınızı girin :");
        string ad = Console.ReadLine();

        Console.WriteLine("Soyadınızı girin :");
        string soyad = Console.ReadLine();

        Console.WriteLine("Yaşınızı girin :");
        int yas = Convert.ToInt32(Console.ReadLine());

        int bek = 18 - yas;

        if (yas > 18)
        {
            Console.WriteLine("Merhaba " + ad + " " + soyad + " yaşınız  " + yas + " buyrun içeri gelin");
        }
        else
        {
            Console.WriteLine("Merhaba " + ad + " " + soyad + " yaşınız  " + yas + " içeri girmek için "+bek+" yıl kadar beklemelisin"); 
        }


    } 
    }