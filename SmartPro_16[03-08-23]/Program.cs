using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_15_03_08_23_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, stop = 0;

            Console.Clear();
            Console.Write("Start: ");
            sayi = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Stop: ");
            stop = int.Parse(Console.ReadLine());

            Console.Clear();
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= stop);
            Console.ReadKey();
        }
    }
}
