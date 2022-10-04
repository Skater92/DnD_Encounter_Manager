using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager
{
    public class ExtraFunct
    {

        public void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DnD Encounter Manager v0.1 (c) DeadPeopleLabs 2022");
            Console.ResetColor();
            Console.WriteLine("\n\n\t//\tMain Menu\t\\\\\n\n" +
                "1)\tSave Files\n\n" +
                "2)\tAdd Monster\n\n" +
                "3)\tDisplay Monster");

        }

        public void SaveThrowMenu()
        {
            Console.WriteLine("\n\n\t//\tSave Throw Menu\t\\\\" +
                "\n\n  1)\tStrength\n" +
                    "  2)\tDexterity\n" +
                    "  3)\tConstitution\n" +
                    "  4)\tIntelligence\n" +
                    "  5)\tWisdom\n" +
                    "  6)\tCharisma\n");
        }

        public void SkillTreeMenu()
        {
            
            Console.WriteLine("\n\n\t//\tSkills\t\\\\" +
                "\n\n  1)\tAcrobatics\n" +
                    "  2)\tAnimal Handling\n" +
                    "  3)\tArcana\n" +
                    "  4)\tAthletics\n" +
                    "  5)\tDeception\n" +
                    "  6)\tHistory\n" +
                    "  7)\tInsight\n" +
                    "  8)\tIntimidation\n" +
                    "  9)\tInvestigator\n" +
                    " 10)\tMedicine\n" +
                    " 11)\tNature\n" +
                    " 12)\tPerception\n" +
                    " 13)\tPerformance\n" +
                    " 14)\tPersuasion\n" +
                    " 15)\tReligeon\n" +
                    " 16)\tSleight of Hand\n" +
                    " 17)\tStealth\n" +
                    " 18)\tSurvival\n");
        }
        //lkjh
        public void PrintDammageResistance()
        {
            Console.WriteLine("\n\n\t//\tDamage Resistance\t\\\\" +
                "\n\n  1)\tBludgeoning\n" +
                    "  2)\tPiercing\n" +
                    "  3)\tSlashing\n" +
                    "  4)\tFire\n" +
                    "  5)\tCold\n" +
                    "  6)\tLightning\n" +
                    "  7)\tAcid\n" +
                    "  8)\tNecrotic\n" +
                    "  9)\tPoison\n" +
                    " 10)\tPsychic\n" +
                    " 11)\tRadiant\n" +
                    " 12)\tThunder\n" +
                    " 13)\tBludgeoning\n" +
                    " 14)\tPiercing\n" +
                    " 15)\tSlashing\n" +
                    " 16)\tFire\n" +
                    " 17)\tCold\n" +
                    " 18)\tLightning\n" +
                    " 19)\tAcid\n" +
                    " 20)\tNecrotic\n" +
                    " 21)\tPoison\n" +
                    " 22)\tPsychic\n" +
                    " 23)\tRadiant\n" +
                    " 24)\tThunder\n");
        }

        public void PrintConditionImmunities()
        {
            Console.WriteLine("\n\n\t//\tCondition Immunites\t\\\\" +
                "\n\n  1)\tBlinded\n" +
                    "  2)\tCharmed\n" +
                    "  3)\tDeafened\n" +
                    "  4)\tFrightened\n" +
                    "  5)\tGrappled\n" +
                    "  6)\tIncapacitated\n" +
                    "  7)\tInvisible\n" +
                    "  8)\tParalyzed\n" +
                    "  9)\tPetrified\n" +
                    " 10)\tPoisoned\n" +
                    " 11)\tProne\n" +
                    " 12)\tRestrained\n" +
                    " 13)\tStunned\n" +
                    " 14)\tUnconscious\n");
            
        }

        public void PrintSenses()
        {
            Console.WriteLine("\n\n\t//\tSenses\t\\\\" +
                "\n\n  1)\tBlindsight\n" +
                    "  2)\tDarkvision\n" +
                    "  3)\tTremorsense\n" +
                    "  4)\tTruesight\n");
        }
        
        public void PrintArmorTypes()
        {
            Console.WriteLine("\n\n\t//\tArmor Types\t\\\\" +
                "\n\n  1)\tNone\n" +
                    "  2)\tLight\n" +
                    "  3)\tMedium\n" +
                    "  4)\tHeavy\n" +
                    "  5)\tShield\n" +
                    "  6)\tNatural\n" +
                    "  7)\tMagic\n");
        }

       
        
    }
}
