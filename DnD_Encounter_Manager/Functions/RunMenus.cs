using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.Functions
{
    public class RunMenus
    {

        public int runMainMenu()
        {
            string inputVar = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlease Select an Option");
            Console.ForegroundColor = ConsoleColor.Green;
            inputVar = Console.ReadLine();
            if(inputVar == null)
            {
                return -1;
            }
            else
            {
                return Int32.Parse(inputVar);
            }
            
        }

        public void menuSelection(int input)
        {

            try
            {
                switch (input)
                {
                    case 1:
                        Add_Monster();
                        break;
                    case 2:
                        //TODO Display Monsters
                        break;
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }

        public void Add_Monster()
        {            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DnD Encounter Manager v0.1 (c) DeadPeopleLabs 2022");
            Console.ResetColor();
            Console.WriteLine("\n\n\tNew Monster Selected!!\n\n");

            Console.WriteLine("Monster Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Size: ");
            string size = Console.ReadLine();
            Console.WriteLine("Type: ");
            string Type = Console.ReadLine();
            Console.WriteLine("Alignment");
            string align = Console.ReadLine();
            Console.WriteLine("Armor Class: ");
            int AC = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hit Points: ");
            int HP = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Speed(On Foot): ");
            int speedMov = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Speed(Climb): ");
            int speedClimb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Speed(Fly): ");
            int speedFly = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Speed(Swim): ");
            int speedSwim = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Strength(Total): ");
            int strength = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dex(Total): ");
            int dexterity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Constitution(Total): ");
            int con = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Intelligence(Total): ");
            int Intel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Wisdom(Total): ");
            int Wis = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Charisma(Total): ");
            int Cha = Int32.Parse(Console.ReadLine());


        }

    }
}
