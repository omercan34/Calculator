using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk sayıyı giriniz");
            string sayi1s = Console.ReadLine();
            Console.WriteLine("ikici sayiyi giriniz");
            string sayi2s = Console.ReadLine();
            Console.WriteLine("hangi işlemiyapmak istiyorsunuz(+,-,*,/)");
            string islem = Console.ReadLine();
            int sayi1 = Convert.ToInt32(sayi1s);
            int sayi2 = Convert.ToInt32(sayi2s);

            if (islem == "+")
            {
                Console.WriteLine("Sonuç:" + topla(sayi1, sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("Sonuç:" + cikartma(sayi1, sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Sonuç:" + carpma(sayi1, sayi2));
            }
            else if (islem == "/")
            {
                Console.WriteLine("Sonuç:" + bolme(sayi1, sayi2));
            }
            else
            {
                Console.WriteLine("sınır dışı");
            }

            Console.ReadLine();


        }
        static double topla(double sayi1, double sayi2)
        {
            double result = sayi1 + sayi2;
            return result;
        }
        static double cikartma(double sayi1, double sayi2)
        {

            double result = sayi1 - sayi2;
            return result;
        }
        static double carpma(double sayi1, double sayi2)
        {
            double result = sayi1 * sayi2;
            return result;
        }

        static double bolme(double sayi1, double sayi2)
        {

            double result = sayi1 / sayi2;
            return result;
        }

    }
}
