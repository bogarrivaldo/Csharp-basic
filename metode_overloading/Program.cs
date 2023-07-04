using System;
// method_overloding adalah fungsi dengan nama yang sama tapi parameter berbeda seperti kita lihat dibawah ini ada beberapa fungsi yang sama dengan
// nilai atau type data dari para meternya berbeda beda.
namespace mthd_ovrldng
{
    public class overloading
    {
        static double myfunction(int nil1, int nil2)
        {

            Console.WriteLine("Hello Myname : Valdo_GameDeveloper");
            Console.WriteLine(nil1 + nil2);
            return nil1 + nil2;
        }

        static double myfunction(double nil1, double nil2)
        {

            Console.WriteLine("Hello Myname : Valdo_GameDeveloper");
            Console.WriteLine(nil1 + nil2);
            return nil1 + nil2;
        }
        static void Main(String[] args)
        {
            Console.Clear();
            myfunction(10, 10);
            myfunction(15.55, 15.55);
        }
    }
}
