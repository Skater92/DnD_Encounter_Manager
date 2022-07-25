using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.MonsterBuilders
{
    public class MonsterManager
    {
        ExtraFunct funct = new ExtraFunct();
        int ID = 0000;
        private List<string> LangList = new List<string>();
        
        private Monster monster = new Monster();
        public List<Monster> monsters = new List<Monster>();        

               
        public int setID()
        {
            return ID++;
        }
       
        public void addMon()
        {
            monsters.Add(monster);
        }


        
        public void Add_Monster()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DnD Encounter Manager v0.1 (c) DeadPeopleLabs 2022");
            Console.ResetColor();
            Console.WriteLine("\n\n\tNew Monster Selected!!\n\n");

            
            //set AC and Armor type
            Dictionary<string, int> AC = new Dictionary<string, int> { { "NONE", 0 }, { "LIGHT", 0 }, { "MEDIUM", 0 }, { "HEAVY", 0 }, { "SHIELD", 0 }, { "NATURAL", 0 }, { "MAGIC", 0 } };
            string userInput = "";

            //BOILER PLATE
            Console.WriteLine("Monster Name: ");
            string name = Console.ReadLine();
            monster.Name = name;
            Console.WriteLine("Size: ");
            string size = Console.ReadLine();
            monster.size = size;
            Console.WriteLine("Type: ");
            string Type = Console.ReadLine();
            monster.Type = Type;
            Console.WriteLine("Alignment");
            string align = Console.ReadLine();
            monster.Alignment = align;

            //Select AC
            bool tempInput = false;
            
            while (userInput != "Y")
            {
                string armorType = "";
                while(tempInput == false)
                {
                    Console.WriteLine("Select Armor Type: ");
                    funct.PrintArmorTypes();
                    armorType = Console.ReadLine().ToUpper();


                    if (!AC.ContainsKey(armorType))
                    {
                        Console.WriteLine("Invalid Armor Type");

                    }
                    else
                    {
                        tempInput = true;

                    }
                }             
                
                
                
                Console.WriteLine("Input Armor Class: ");
                string armorClass = Console.ReadLine();
                AC[armorType] = Int32.Parse(armorClass);
                //print out Dictionary entry that matches user input
                if (AC.ContainsKey(armorType))
                {
                    Console.WriteLine($"{armorType} - {AC[armorType]}");
                }
                Console.WriteLine("\n\n\tIs this Correct? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }


            Console.WriteLine("Hit Points: ");
            int HP = Int32.Parse(Console.ReadLine());
            monster.HP = HP;

            //SPEED
            Console.WriteLine("Speed(On Foot): ");
            int speedMov = Int32.Parse(Console.ReadLine());
            monster.speedMov = speedMov;
            Console.WriteLine("Speed(Climb): ");
            int speedClimb = Int32.Parse(Console.ReadLine());
            monster.speedClimb = speedClimb;
            Console.WriteLine("Speed(Fly): ");
            int speedFly = Int32.Parse(Console.ReadLine());
            monster.speedFly = speedFly;
            Console.WriteLine("Speed(Swim): ");
            int speedSwim = Int32.Parse(Console.ReadLine());
            monster.speedSwim = speedSwim;

            //ATTRIBUTES
            Console.WriteLine("Strength: ");
            int str = Int32.Parse(Console.ReadLine());
            monster.Str = str;
            Console.WriteLine("Dexterity: ");
            int dex = Int32.Parse(Console.ReadLine());
            monster.Dex = dex;
            Console.WriteLine("Constitution: ");
            int con = Int32.Parse(Console.ReadLine());
            monster.Con = con;
            Console.WriteLine("Intelligence: ");
            int intl = Int32.Parse(Console.ReadLine());
            monster.Int = intl;
            Console.WriteLine("Wisdom: ");
            int wis = Int32.Parse(Console.ReadLine());
            monster.Wis = wis;
            Console.WriteLine("Charisma: ");
            int cha = Int32.Parse(Console.ReadLine());
            monster.Cha = cha;

            //SAVING THROWS
            userInput = "";
            Dictionary<string, int> userSaves = new Dictionary<string, int> { { "STRENGTH", 0 }, { "DEXTERITY", 0 }, { "CONSTITUTION", 0 }, { "INTELLIGENCE", 0 }, { "WISDOM", 0 }, { "CHARISMA", 0 } };
            Console.WriteLine("Saving Throws");
            funct.SaveThrowMenu();


            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Saving Throw Skill");
                string saveThrow = Console.ReadLine().ToUpper();
                //switch
                Console.WriteLine($"Skill Selected: {userSaves[saveThrow]}");
                Console.WriteLine("Enter the Saving Throw Value");
                int saveValue = Int32.Parse(Console.ReadLine());
                userSaves[saveThrow] = saveValue;
                Console.WriteLine("Enter More Saving throws? [Y/N]");
                userInput = Console.ReadLine().ToUpper();

            }
            userInput = "";
            monster.saveThrows = userSaves;


            //SKILLS
            Dictionary<string, int> userSkills = new Dictionary<string, int> { { "acrobatics", 0 }, { "animal handling", 0 }, { "arcana", 0 }, { "athletics", 0 }, { "deception", 0 }, { "history", 0 }, { "insight", 0 }, { "Intimidation", 0 }, { "investigation", 0 }, { "medicine", 0 }, { "nature", 0 }, { "perception", 0 }, { "performance", 0 }, { "persuasion", 0 }, { "religion", 0 }, { "sleight of hand", 0 }, { "stealth", 0 } };
            funct.SkillTreeMenu();
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Skill");
                string skill = Console.ReadLine().ToLower();
                Console.WriteLine("Enter the Skill Value");
                int skillValue = Int32.Parse(Console.ReadLine());
                userSkills[skill] = skillValue;
                Console.WriteLine("Enter More Skills? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Skills = userSkills;

            //RESISTANCES
            Dictionary<string, bool> userResistances = new Dictionary<string, bool> { { "acid", false }, { "bludgeoning", false }, { "cold", false }, { "fire", false }, { "force", false }, { "lightning", false }, { "necrotic", false }, { "piercing", false }, { "poison", false }, { "psychic", false }, { "radiant", false }, { "slashing", false }, { "thunder", false } };
            funct.PrintDammageResistance();
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Damage Resistance");
                string resistance = Console.ReadLine().ToLower();
                Console.WriteLine($"Set Value of {resistance} to true? [Y/N]");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    userResistances[resistance] = true;
                }
                Console.WriteLine("Enter More Damage Resistances? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Resistances = userResistances;

            //CONDITION IMMUNITIES
            Dictionary<string, bool> userConditionImmunities = new Dictionary<string, bool> { { "blinded", false }, { "charmed", false }, { "deafened", false }, { "frightened", false }, { "grappled", false }, { "incapacitated", false }, { "invisible", false }, { "paralyzed", false }, { "petrified", false }, { "poisoned", false }, { "prone", false }, { "restrained", false }, { "stunned", false } };
            funct.PrintConditionImmunities();
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Condition Immunity");
                string immunity = Console.ReadLine().ToLower();
                Console.WriteLine($"Set Value of {immunity} to true? [Y/N]");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    userConditionImmunities[immunity] = true;
                }
                Console.WriteLine("Enter More Condition Immunities? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.ConImmun = userConditionImmunities;

            //SENSES
            Dictionary<string, int> userSenses = new Dictionary<string, int> { { "blindsight", 0 }, { "darkvision", 0 }, { "tremorsense", 0 }, { "truesight", 0 } };
            funct.PrintSenses();
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Sense");
                string sense = Console.ReadLine().ToLower();
                Console.WriteLine("Enter the Sense Distance");
                int senseValue = Int32.Parse(Console.ReadLine());
                userSenses[sense] = senseValue;
                Console.WriteLine("Enter More Senses? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Sense = userSenses;

            //LANGUAGES
            List<string> userLanguages = new List<string>();
            Console.WriteLine("\n\n\t//\tLanguages Known\\\\\n\n");
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Language");
                string language = Console.ReadLine();
                userLanguages.Add(language);
                Console.WriteLine("Enter More Languages? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Language = userLanguages;

            //FEATURES
            Dictionary<string, string> FeatureList = new Dictionary<string, string>();
            Console.WriteLine("\n\n\t//\tFeatures\\\\\n\n");
            while (userInput != "N")
            {

                Console.WriteLine("Enter Name of Feature");
                string featureTitle = Console.ReadLine();
                Console.WriteLine("Enter the Feature Description");
                string featureDesc = Console.ReadLine();
                if (FeatureList.ContainsKey(featureTitle))
                {
                    Console.WriteLine("Feature Already Exists");
                }
                else
                {
                    FeatureList.Add(featureTitle, featureDesc);
                }
                Console.WriteLine("Enter More Features? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Feature = FeatureList;

            //ACTIONS
            Dictionary<string, string> userActions = new Dictionary<string, string>();
            Console.WriteLine("\n\n\t//\tActions\\\\\n\n");
            while (userInput != "N")
            {
                Console.WriteLine("Enter Name of Action");
                string actionTitle = Console.ReadLine();
                Console.WriteLine("Enter the Action Description");
                string actionDesc = Console.ReadLine();
                if (userActions.ContainsKey(actionTitle))
                {
                    Console.WriteLine("Action Already Exists");
                }
                else
                {
                    userActions.Add(actionTitle, actionDesc);
                }
                Console.WriteLine("Enter More Actions? [Y/N]");
                userInput = Console.ReadLine().ToUpper();
            }
            userInput = "";
            monster.Action = userActions;

            //LEGENDARY
            //bool legendary = false;
            //Console.WriteLine("\n\n\tIs this a Legendary Monster? [Y/N]");
            //if (Console.ReadLine().ToUpper() == "Y")
            //{
            //    legendary = true;
            //    monster.isLegendary = legendary;
            //}
            //if (monster.isLegendary)
            //{
            //    int legendaryActions = 0;
            //    bool validFlag = false;
            //    while (!validFlag)
            //    {
            //        Console.WriteLine("\n\n\tHow Many Legendary Actions does this Monster have? [0/1/2/3]");
            //        legendaryActions = Int32.Parse(Console.ReadLine());
            //        if (legendaryActions < 0 || legendaryActions > 3)
            //        {
            //            Console.WriteLine("\n\n\tInvalid Number of Legendary Actions");
            //        }
            //        else
            //        {
            //            validFlag = true;
            //        }
            //    }
            //    monster.LegendaryCount = legendaryActions;
            //    Dictionary<string, string> LegendaryAct = new Dictionary<string, string>();
            //    for (int i = 0; i < monster.LegendaryCount; i++)
            //    {
            //        Console.WriteLine("Enter Name of Legendary Action");
            //        string legendaryAction = Console.ReadLine();
            //        Console.WriteLine("Enter the Action Description");
            //        string legendaryDesc = Console.ReadLine();
            //        if (monster.LegendaryAct.ContainsKey(legendaryAction))
            //        {
            //            Console.WriteLine("Legendary Action Already Exists");
            //        }
            //        else
            //        {
            //            LegendaryAct.Add(legendaryAction, legendaryDesc);
            //        }
            //    }
            //    monster.LegendaryAct = LegendaryAct;

            //    //IN LAIR?
            //    Console.WriteLine("\n\n\tIs this Monster in it's Lair? [Y/N]");
            //    if (Console.ReadLine().ToUpper() == "Y")
            //    {
            //        monster.inLair = true;
            //    }
            //    else
            //    {
            //        monster.inLair = false;
            //    }
            //    if (monster.inLair)
            //    {
            //        Dictionary<string, string> lairAct = new Dictionary<string, string>();
            //        while (userInput != "N")
            //        {
            //            Console.WriteLine("Enter Name of Lair Action");
            //            string lairAction = Console.ReadLine();
            //            Console.WriteLine("Enter the Action Description");
            //            string lairDesc = Console.ReadLine();
            //            if (lairAct.ContainsKey(lairAction))
            //            {
            //                Console.WriteLine("Lair Action Already Exists");
            //            }
            //            else
            //            {
            //                lairAct.Add(lairAction, lairDesc);
            //            }
            //            Console.WriteLine("Enter More Lair Actions? [Y/N]");
            //            userInput = Console.ReadLine().ToUpper();
            //        }
            //        userInput = "";
            //        monster.LairAction = lairAct;
            //    }

            //}

            monsters.Add(monster);


        }



        
        public void PrintMonster(Monster mon)
        {
            //Print Monster
            Console.WriteLine("\n\n\t//\tMonster Information\\\\\n\n");
            Console.WriteLine($"Name: {mon.Name}");
            Console.WriteLine($"{mon.size} {mon.Type}, {mon.Alignment}");

            //SEPARATOR BARS
            for (int i = 0; i < 15; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, int> ArmorClass in mon.AC)
            {
                //find the key with the value of greater than 0
                if (ArmorClass.Value > 0)
                {
                    Console.WriteLine($"Armor Class: {ArmorClass.Value} ({ArmorClass.Key.ToLower()})");                    
                }
            }
            
            Console.WriteLine($"Hit Points: {mon.HP}");
            if(mon.speedMov > 0)
            {
                Console.Write($"Speed: {mon.speedMov} ft");
            }
            if(mon.speedClimb > 0)
            {
                Console.Write($", climb {mon.speedClimb} ft");
            }
           
            if (mon.speedSwim > 0)
            {
                Console.Write($", swim {mon.speedSwim} ft");
            }
            if (mon.speedFly > 0)
            {
                Console.Write($", fly {mon.speedFly} ft");
            }
            Console.WriteLine();

            //SEPARATOR BARS
            for (int i = 0; i < 15; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();


            Console.WriteLine("\tSTR\tDEX\tCON\tINT\tWIS\tCHA");
            Console.WriteLine($"{mon.Str}\t{mon.Dex}\t{mon.Con}\t{mon.Int}\t{mon.Wis}\t{mon.Cha}");

            //SEPARATOR BARS
            for (int i = 0; i < 15; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            Console.Write("Saving Throws ");
            foreach (KeyValuePair<string,int> save in mon.saveThrows)
            {
                if (save.Value > 0)
                {
                    Console.Write($"{save.Key.ToUpper()} ");
                    if (save.Value >= 0)
                    {
                        Console.Write($"+{save.Value} ");
                    }
                    else
                    {
                        Console.Write($"-{save.Value} ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Skills ");
            foreach (KeyValuePair<string, int> skill in mon.Skills)
            {
                if (skill.Value > 0)
                {
                    Console.Write($"{skill.Key} ");
                    if (skill.Value >= 0)
                    {
                        Console.Write($"+{skill.Value} ");
                    }
                    else
                    {
                        Console.Write($"-{skill.Value} ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write($"Damage Resistances: ");
            foreach (KeyValuePair<string, bool> res in mon.Resistances)
            {
                if (res.Value)
                {
                    Console.Write($"{res.Key} ");
                }
            }
            Console.WriteLine();

            Console.Write("Senses: ");
            foreach(KeyValuePair<string, int> sense in mon.Sense)
            {
                if(sense.Value > 0)
                {
                    Console.Write($"{sense.Key} {sense.Value} ft");
                }
            }
            Console.Write($"Passive Perception {mon.PassPerception}");
            Console.WriteLine();

            Console.Write("Languages: ");
            foreach(string i in mon.Language)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write($"Challenge: {mon.challenge}\tProficiency Bonus: ");
            if(mon.challenge >= 0)
            {
                Console.Write($"+{mon.profBonus}");
            }
            else
            {
                Console.Write($"-{mon.profBonus}");
            }
            Console.WriteLine();

            //SEPARATOR BARS
            for (int i = 0; i < 15; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            //FEATS

            foreach(KeyValuePair<string, string> feat in mon.Feature)
            {
                Console.WriteLine($"{feat.Key}\n{feat.Value}");
            }

            //ACTIONS

            Console.WriteLine("Actions");
            //SEPARATOR BARS
            for (int i = 0; i < 15; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            foreach(KeyValuePair<string, string> action in mon.Action)
            {
                Console.WriteLine($"{action.Key}\n{action.Value}");
            }

            if(mon.isLegendary)
            {
                Console.WriteLine("Legendary Actions");
                //SEPARATOR BARS
                for (int i = 0; i < 15; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                foreach(var thing in mon.LegendaryAct)
                {
                    Console.WriteLine($"{thing.Key}\n{thing.Value}");
                }
            }

        }
        public void Display_All_Monsters()
        {
            string userInput = "";
            while (userInput != "Q")
            {
                //Print Monster List
                Console.WriteLine("\n\n\t//\tMonster List\\\\\n\n");
                int count = 0;
                foreach (Monster mon in monsters)
                {                    
                    Console.WriteLine($"{count+1})\t{mon.Name}");
                    count++;
                }
                Console.WriteLine("Select Menu Option by Number, press 'Q' to Quit");
                userInput = Console.ReadLine().ToUpper();
                
                if(userInput != "Q")
                {
                    count = 0;
                    foreach (Monster mon in monsters)
                    {
                        if(int.Parse(userInput) == count)
                        {
                            PrintMonster(mon);
                        }
                        count++;
                    }
                }

            }
            
            
        }




    }
}
