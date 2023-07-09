using System;

namespace Inheritance
{
    class class1
    {
        public int speed;
    }
    class class2 : class1
    {
        public void killthat()
        {
            Console.WriteLine("Kill Enemy that");
        }
    }
    class Start
    {
        static void Main(String[] args)
        {
            class2 kls2 = new class2();
            Console.Clear();
            Console.WriteLine(kls2.speed);
            kls2.killthat();
        }
    }
}