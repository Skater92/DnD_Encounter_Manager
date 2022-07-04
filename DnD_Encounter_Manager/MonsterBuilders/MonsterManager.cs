using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Encounter_Manager.MonsterBuilders
{
    public class MonsterManager
    {
        private Monster newMon = new Monster();
        public List<Monster> monsters = new List<Monster>();

        public void addFeatures(List<string> inputList)
        {
            newMon.Feature = inputList;           
        }

        public void addAction(List<string> actionList)
        {
            newMon.Action = actionList;
        }

        public void buildMon(int id, int AC, int HP, string Name, bool isLegendary, bool inLair, string size, int speed, int str, int dex,
            int con, int Int, int Wis, int Cha)
        {
            newMon.MonsterID = id;
            newMon.AC = AC;
            newMon.HP = HP;
            newMon.Name = Name;
            newMon.size = size;
            newMon.speed = speed;
            newMon.Str = str;
            newMon.Dex = dex;
            newMon.Con = con;
            newMon.Int = Int;
            newMon.Wis = Wis;
            newMon.Cha = Cha;

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
