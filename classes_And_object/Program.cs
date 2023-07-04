using System;

namespace objandclass
{ // pada topic ini kita belajar bagaimana membuat object dan class pada Csharp
    class hacker
    {
        string color = "white";
        static void Main(String[] args)
        {
            hacker whitehat = new hacker(); // pembuatan object baru
            Console.WriteLine(whitehat.color); // pemanggilan obj baru
        }
    }
}