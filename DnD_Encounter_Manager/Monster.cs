using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DnD_Encounter_Manager
{


    public class Monster
    {
        public int MonsterID { get; set; }
        public string? Name { get; set; }        
        public int HP { get; set; }
        public bool isLegendary { get; set; }
        public bool inLair { get; set; }
        public string? size { get; set; }
        public int speedMov { get; set; }
        public int speedFly { get; set; }
        public int speedClimb { get; set; }
        public int speedSwim { get; set; }
        public int speedBurrow { get; set; }
        public int profBonus { get; set; }
        public int challenge { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int AC { get; set; }
        public string? ACType { get; set; }
        public Dictionary<string, bool>? Resistances { get; set; }
        public Dictionary<string, bool>? ConImmun { get; set; }
        public Dictionary<string, int>? Sense { get; set; }
        public List<string>? Language { get; set; }
        public Dictionary<string, string>? Feature { get; set; }
        public Dictionary<string, string>? Action { get; set; }
        public Dictionary<string, int>? saveThrows { get; set; }
        public Dictionary<string, int>? Skills { get; set; }
        public Dictionary<string, string>? LegendaryAct { get; set; }
        public Dictionary<string, string>? LairAction { get; set; }
        public int LegendaryCount { get; set; }
        public string? MonNotes { get; set; }
        public string? Type { get; set; }
        public string? Alignment { get; set; }
        public int PassPerception { get; set; }

    }
}
