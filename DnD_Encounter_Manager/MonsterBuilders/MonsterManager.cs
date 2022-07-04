using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.MonsterBuilders
{
    public class MonsterManager
    {
        int ID = 0000;
        private List<string> LangList = new List<string>();
        
        private Monster newMon = new Monster();
        public List<Monster> monsters = new List<Monster>();

        public void addFeatures(List<string> inputList)
        {
            newMon.Feature = inputList;           
        }

        public void DamImm(List<string> immunityList)
        {
            newMon.DamImmun = immunityList;
        }
        public void ConImm(List<string> immunityList)
        {
            newMon.ConImmun = immunityList;
        }

        public void setSenses(List<string> senseList)
        {
            newMon.Sense = senseList;
        }

        public void addAction(List<string> actionList)
        {
            newMon.Action = actionList;
        }
        public void setLang()
        {
            LangList.Clear();
            LangList.Add("Common");
        }
        public void addLang(string input)
        {
            LangList.Add(input);
            newMon.Language = LangList;
        }
        public int setID()
        {
            return ID++;
        }
        public void buildMon(int id, int AC, int HP, string Name, bool isLegendary, bool inLair, string size, int speed, int str, int dex,
            int con, int Int, int Wis, int Cha, string Type, string align, int fly, int climb, int swim)
        {
            newMon.MonsterID = id;
            newMon.AC = AC;
            newMon.HP = HP;
            newMon.Name = Name;
            newMon.size = size;
            newMon.speedMov = speed;
            newMon.speedClimb = climb;
            newMon.speedFly = fly;
            newMon.speedSwim = swim;
            newMon.Str = str;
            newMon.Dex = dex;
            newMon.Con = con;
            newMon.Int = Int;
            newMon.Wis = Wis;
            newMon.Cha = Cha;
            newMon.Type = Type;
            newMon.Alignment = align;
            

            if(isLegendary)
            {
                newMon.isLegendary = true;
                newMon.LegendaryAct = 3;
                if(inLair)
                {
                    newMon.inLair = true;
                }
            }

        }

        public void addMon()
        {
            monsters.Add(newMon);
        }

    }
}
