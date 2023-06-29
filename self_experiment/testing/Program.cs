using System;

namespace testing
{
    class test      // dotnet new console -o namedirectory == untuk membuat project menggunakan dotnet
    {
        static void Main(String[] args)
        {
            int var1 = 2, var2 = 1, hasil;
            hasil = (var1 + var2) * 5; // Jika tidak menggunakan dalam kurung, akan di proses perkalian terlebih dahulu sesuai 
            Console.Clear(); // Untuk membersihkan console.
            Console.WriteLine("Welcome valdo");
            Console.WriteLine("Hasilnya = " + hasil + "\n");

        }
    }
}