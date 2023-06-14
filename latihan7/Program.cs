using System;

namespace MultipleVar
{       // Multiple variabel test
    class testvariabel
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\n\nHi...Valdo_GameDev");
            // Percobaan multiple variabel declarasi dan menampilkan
            int a = 5, b = 5, c = 5;
            int total = a + b + c;
            Console.WriteLine(total);

            int f, g, x;
            f = g = x = 10;
            Console.WriteLine(f + g + x);
        }
    }
}