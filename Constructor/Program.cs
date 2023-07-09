using System;

namespace constructor
{   // Kegunaan dari constructor akan dipanggil diawal ketika program di jalankan
    class learnconstruct
    {
        string myname, school;
        int age;

        learnconstruct(string paraname, string paraschool, int paraage) // Constructor
        {
            myname = paraname;
            school = paraschool;
            age = paraage;
        }
        void covervalue()
        {
            Console.WriteLine("My name : " + myname);
            Console.WriteLine("My name : " + school);
            Console.WriteLine("My name : " + age);
        }
        static void Main(String[] args)
        {
            learnconstruct myobj = new learnconstruct("BogarDev", "UniversitasKlabat", 21);
            myobj.covervalue();
            Console.WriteLine(myobj.myname); // just testing code

        }
    }
}