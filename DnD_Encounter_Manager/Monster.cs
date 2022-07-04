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
        public int AC { get; set; }
        public int HP { get; set; }
        public bool isLegendary { get; set; }
        public bool inLair { get; set; }
        public string? size { get; set; }
        public int speed { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public string? DamImmun { get; set; }
        public string? ConImmun { get; set; }
        public string? Sense { get; set; }
        public string? Language { get; set; }
        public List<string>? Feature { get; set; }
        public List<string>? Action { get; set; }
        public int LegendaryAct { get; set; }


    }
}
