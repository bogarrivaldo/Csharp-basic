using System;
namespace Displayvariabel   // Menampilkan display variables
{
    class displaysomething
    {
        static void Main(String[] args)
        {
            int var1 = 15, var2 = 2, hasil;

            Console.WriteLine("\n\nhasil dari" + var1 + " + " + " var2 " + " = " + var1 + var2); // Akan dibaca sebagai string
            hasil = var1 + var2;
            Console.WriteLine("hasil dari" + var1 + " + " + " var2 " + " = " + hasil); // Dimanipulasi

            int jum1 = 5, jum2 = 6;
            Console.WriteLine(jum1 + jum2); // Akan langsung dijumlahkan

            string frontName = "Rivaldo", backName = "Bogar";
            Console.WriteLine(frontName + backName); // Penggabungan kedua string

            string lab1 = "game", lab2 = "Dev", gabungkan;
            gabungkan = lab1 + lab2; // Buat variabel baru untuk menggabungkan variabel1 dan variabel2
            Console.WriteLine(gabungkan); // tampilkan
        }
    }
}
