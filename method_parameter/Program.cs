using System;
namespace mthod_params
{
    class traning_method
    {
        static void ontrigger(string myname) // method with parameter
        {
            Console.WriteLine("I'm begining developer : " + myname);
        }
        static void Main(String[] args)
        {
            ontrigger("valdoDev"); // Arguments
        }
    }
}