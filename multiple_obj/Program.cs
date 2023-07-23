using System;
using bogarclass;
namespace multiobj
{
    class testing
    {
        public string myname = "Bogar rivaldo";
        static void Main(string[] args)
        {
            Console.Clear();
            // valdo obj2 = new valdo();
            testing obj1 = new testing();
            Console.WriteLine(obj1.myname);
            // Console.WriteLine(obj2.myname); //untuk percobaan membaca variabel dari class berbeda belum jadi 
            // dikarenakan bisa jadi vscode tidak realtime read directori, percobaan bisa dari unity atau microsoft visual studio

        }
    }

}