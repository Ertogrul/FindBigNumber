using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Giriniz:");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz:");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayıyı Giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>sayi2&&sayi1>sayi3)
            {
                Console.WriteLine("En Büyük Sayı:");
                Console.WriteLine(sayi1);
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("En Büyük Sayı:");
                Console.WriteLine(sayi2);
            }
            else
            {
                Console.WriteLine("En Büyük Sayı:");
                Console.WriteLine(sayi3);
            }
            
            Console.ReadLine();
        }
    }
}
