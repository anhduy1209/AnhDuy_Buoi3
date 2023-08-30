using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            HTamGiac tg1 = new HTamGiac(2,3,7);
            HTamGiac tg2 = new HTamGiac(3, 6, 11);
            HTamGiac tg3 = new HTamGiac(2, 3, 4);
            HTamGiac tg4 = new HTamGiac(3, 3, 5);
            HTamGiac tg5 = new HTamGiac(3, 3, 3);
            Console.WriteLine("Tam giac 1 : ");
            tg1.Xuat();
            Console.WriteLine("Tam giac 2 : ");
            tg2.Xuat();
            Console.WriteLine("Tam giac 3 : ");
            tg3.Xuat();
            Console.WriteLine("Tam giac 4 : ");
            tg4.Xuat();
            Console.WriteLine("Tam giac 5 : ");
            tg5.Xuat();
        }
    }
}
