﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_Lab_5.hafta._1
{
    class Program
    {
        static float Fonksiyon(float x) {
            return 2 * x + 5; }
        static float TersFonksiyon(float x)
        {
            return (x - 5) / 2;
        }
        static void Main(string[] args)
        {
            float x = 10;
            Console.WriteLine(Fonksiyon(x));
            Console.WriteLine(TersFonksiyon(x));
            Console.WriteLine(Fonksiyon(TersFonksiyon(x)));
            Console.ReadKey();

            // program çalıştı
            //sırasıyla:
            //25
            //2,5
            //10
            //sayılarını yazdırdı.
        }
    }
}
