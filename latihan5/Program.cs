using System;

namespace valdo_gameDev
{
    class constant_traning
    {
        static void Main(String[] args)
        {
            const int newVariabel = 5;
            // newVariabel = 10; Jika kita menggunakan const nilai dari variabel tidak bisa diubah ubah seperti pada sebelah ini
            // jika mengubah variabel 5 diatas,...program ini akan error
            Console.WriteLine("nilai yang ditampilkan adalah " + newVariabel);
        }
    }
}