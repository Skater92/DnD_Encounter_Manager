using DnD_Encounter_Manager.MonsterBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.Functions
{
    public class RunMenus
    {
        ExtraFunct funct = new ExtraFunct();
        SaveFiles sf = new SaveFiles();
        MonsterManager monster = new MonsterManager();
        
        public void runMainMenu(string PATH, string BACKUP, List<Monster> m_)
        {
            monster.monsters = m_;
            int returnVal;
            funct.PrintHeader();
            funct.PrintMenu();         
            string inputVar = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlease Select an Option");
            Console.ForegroundColor = ConsoleColor.Green;
            inputVar = Console.ReadLine();
            if(inputVar == null)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = Int32.Parse(inputVar);
            }
            menuSelection(returnVal, PATH, BACKUP);
            
        }

        public void menuSelection(int input, string PATH, string BACKUP)
        {

            try
            {
                switch (input)
                {
                    case 1:
                        try
                        {
                            funct.PrintHeader();
                            sf.PrintSaveMenu();
                            sf.RunSaveMenu(PATH, BACKUP);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Thread.Sleep(2000);
                            Console.Clear();
                            runMainMenu(PATH, BACKUP, monster.monsters);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            runMainMenu(PATH, BACKUP, monster.monsters);
                        }
                        break;
                    case 2:
                        try { monster.Add_Monster();
                            Console.WriteLine("Monster ADDED!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            runMainMenu(PATH, BACKUP, monster.monsters);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        try {
                            Console.Clear();
                            funct.PrintHeader();
                            monster.Display_All_Monsters();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            Thread.Sleep(2000);
                            runMainMenu(PATH, BACKUP, monster.monsters);
                        } catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }

       

       

    }
}
