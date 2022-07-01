using System;


namespace DnD_Encounter_Manager
{
    class Program
    {
        static void Main()
        {
            ExtraFunct funct = new ExtraFunct();
            Console.WriteLine("DnD Encounter Manager v0.1 \n(c) DeadPeopleLabs 2022");
            funct.PrintMenu();
        }
    }
}
