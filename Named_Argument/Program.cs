using System;

namespace named_argument
{
    public class namedargument
    {
        static void Named_argument(string param1, string param2, string param3)
        {
            Console.Clear();
            Console.WriteLine("Hello gamedev");
            Console.WriteLine("param2 : " + param3);
        }
        static void Main(String[] args)
        {
            Named_argument(param1: "bogar", param2: "Bogar GameDev", param3: "test");
        }
    }
}