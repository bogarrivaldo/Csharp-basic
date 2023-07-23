using System;
namespace properti
{
    class traningProperti
    {
        private string Myname;


        public string Name
        {
            set
            {
                Myname = "Bogar";
            }
            get
            {
                return Myname;
            }

        }
    }

    class Update : traningProperti
    {
        static void Main(String[] args)
        {
            Update obj1 = new Update();

            Console.WriteLine(obj1.Name);
        }
    }
}