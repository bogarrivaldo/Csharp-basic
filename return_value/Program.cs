using System;
namespace return_value
{
    class bck_value
    {
        static int myfunction(int test = 5) // Membuat default value
        {
            return test + 10; // return value
        }
        static void Main(String[] args)
        {
            Console.WriteLine(myfunction(10));  // set value di arguments
            Console.WriteLine(myfunction());    // tanpa set value, jadi akan menjalankan default value
        }
    }
}