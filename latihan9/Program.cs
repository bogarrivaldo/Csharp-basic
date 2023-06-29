using System;

namespace get_input_user
{
    class get_input
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Masukan nama : ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nNama saya : " + name + " " + name.GetType());



            Console.WriteLine("\nMasukan sesuatu yang ingin di covert : ");
            string convert1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nNama saya : " + convert1 + " " + convert1.GetType());
        }
    }
}