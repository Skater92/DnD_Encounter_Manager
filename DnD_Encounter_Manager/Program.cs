using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using DnD_Encounter_Manager.Functions;
using DnD_Encounter_Manager.MonsterBuilders;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.Windows.Forms;



namespace DnD_Encounter_Manager
{
    class Program
    {
        
        private static readonly string PATH = System.Environment.CurrentDirectory;
        private static readonly string SCHEMA = PATH + "\\..\\..\\Debug\\net6.0\\MOB_SCHEMA.json";
        private static readonly string DATA_FILE = PATH + "\\..\\..\\Debug\\net6.0\\Saved_Files";
        private static readonly string BACKUP = PATH + "\\..\\..\\Debug\\net6.0\\BACK_UP_FILES";
        private static List<Monster> m_ = new List<Monster>();


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string jsonSCHEMA = File.ReadAllText(SCHEMA);
            IList<string> messages;
            SaveFiles sFile = new SaveFiles();            
            ExtraFunct funct = new ExtraFunct();
            RunMenus menus = new RunMenus();

            funct.PrintHeader();
            sFile.PrintSaveMenu();
            string chosenFile = sFile.RunSaveMenu(DATA_FILE, BACKUP);
            string json = "";
            try
            {
                json = File.ReadAllText(chosenFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            m_ = ReadJsonFileToMonster(chosenFile);
            try
            {
                if (funct.ValidateData(json, jsonSCHEMA, out messages))
                {

                    menus.runMainMenu(DATA_FILE, BACKUP, m_);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Issue with JSON File");
                Console.WriteLine(ex.Message);
            }
        }

         static List<Monster> ReadJsonFileToMonster(string DATA_FILE)
        {
            string json = File.ReadAllText(DATA_FILE);
            return JsonConvert.DeserializeObject<List<Monster>>(json);
            
        }

    }
}
