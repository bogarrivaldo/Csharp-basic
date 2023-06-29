using System;

namespace dfault_params
{
    class dflt_params
    {
        static void bogar(string prodi = "informatika") // di dalam parameter in adalah default parameter atau default value
        {
            Console.WriteLine("my prodi : " + prodi);
        }
        static void Main(String[] args)
        {
            bogar("pertanian");
            bogar(); // function di panggil ini di panggil tanpa set valuenya, jadi akan otomatis menjalankan default value.
        }
    }
}