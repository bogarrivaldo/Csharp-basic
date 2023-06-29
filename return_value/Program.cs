using System;
namespace return_value
{
    class bck_value
    {
        static int myfunction(int test = 5)
        {
            return test + 10;
        }
        static void Main(String[] args)
        {
            Console.WriteLine(myfunction(10));  // set value di arguments
            Console.WriteLine(myfunction());    // tanpa set value, jadi akan menjalankan default value
        }
    }
}