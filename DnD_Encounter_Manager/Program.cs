using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using DnD_Encounter_Manager.Functions;
using DnD_Encounter_Manager.MonsterBuilders;
//using Newtonsoft.Json;


namespace DnD_Encounter_Manager
{
    class Program
    {
       
        private static readonly string PATH = System.Environment.CurrentDirectory;
        private static readonly string DATA_FILE = PATH + "\\..\\..\\SavedData.json";
        private static List<Monster> m_ = new List<Monster>();
        static void Main()
        {

            m_ = ReadJsonFile(DATA_FILE);

            ExtraFunct funct = new ExtraFunct();
            RunMenus menus = new RunMenus();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DnD Encounter Manager v0.1 (c) DeadPeopleLabs 2022");
            Console.ResetColor();
            funct.PrintMenu();
            int inputVal = menus.runMainMenu();
            menus.menuSelection(inputVal);
        }

        private static List<Monster> ReadJsonFile(string DATA_FILE)
        {
            string json = File.ReadAllText(DATA_FILE);
            //return JsonConvert.DeserializeObject<List<Monster>>(json);
            return null;
        }

    }
}
