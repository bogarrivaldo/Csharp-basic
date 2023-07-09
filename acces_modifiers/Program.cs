using System;
namespace acces_modifiers
{
    class run
    {

        public double cepat = 13.55; // Jika tidak dibuat public tidak bisa mengakses langsung dari class lain.
                                     // harus dicover nilainya dari function seperti dibawah ini.
        public void no_touch()
        {
            Console.WriteLine("Player run : " + cepat); // ini nilainya dicover menggunakan function
        }
    }
    class update
    {
        static void Main(String[] args)
        {
            run obj1 = new run();
            Console.Clear();
            obj1.no_touch();    // memanggil function
            Console.WriteLine(obj1.cepat); // Menampilkan value langsung
        }
    }
}