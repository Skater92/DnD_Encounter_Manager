using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using DnD_Encounter_Manager.Functions;
using DnD_Encounter_Manager.MonsterBuilders;
using Newtonsoft.Json;



namespace DnD_Encounter_Manager
{
    class Program
    {

        private static readonly string PATH = System.Environment.CurrentDirectory;       
        private static readonly string DATA_FILE = PATH + "\\..\\..\\Debug\\net6.0\\Saved_Files";
        private static readonly string BACKUP = PATH + "\\..\\..\\Debug\\net6.0\\BACK_UP_FILES";
        private static List<Monster> m_ = new List<Monster>();
        
        
       
        static void Main()
        {
            SaveFiles sFile = new SaveFiles();            
            //ExtraFunct funct = new ExtraFunct();
            RunMenus menus = new RunMenus();
            sFile.PrintSaveMenu();
            string chosenFile = sFile.RunSaveMenu(DATA_FILE, BACKUP);
            m_ = ReadJsonFileToMonster(chosenFile);
                menus.runMainMenu(DATA_FILE, BACKUP);
        }

         static List<Monster> ReadJsonFileToMonster(string DATA_FILE)
        {
            string json = File.ReadAllText(DATA_FILE);
            return JsonConvert.DeserializeObject<List<Monster>>(json);
            
        }

    }
}
