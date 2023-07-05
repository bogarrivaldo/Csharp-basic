using System;

namespace memberclass
{
    class class_member
    {
        string myname = "Valdo_GameDeveloper"; // assigment operator
        int age = 21; // assigment operator
        string level = "Legend";
        void assignvalue()
        {
            Console.WriteLine("Hello i'm : " + myname + "\n my age : " + age);
        }


        static void Main(String[] args)
        {

            class_member npc1 = new class_member();
            class_member npc2 = new class_member();
            npc1.level = "Mythic"; // Passing value
            npc2.level = "Bronze";  // Passing value
            npc1.assignvalue();
            Console.WriteLine(npc1.level); // Show in the console
            Console.WriteLine(npc2.level);  // Show in the console
        }
    }
}