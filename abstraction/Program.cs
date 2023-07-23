
using System;

namespace abstraction
{
    abstract class Mobil
    {

        public abstract void runplayer();


    }
    class Rush : Mobil
    {
        public override void runplayer()
        {
            Console.WriteLine("ini adalah Rush");
        }
    }
    class Expander : Mobil
    {
        public override void runplayer()
        {
            Console.WriteLine("ini adalah expander");
        }

    }
    class Update
    {

        static void Main(String[] args)
        {

            Mobil user1 = new Rush();
            Mobil user2 = new Expander();

            user1.runplayer();
            user2.runplayer();
        }
    }
}