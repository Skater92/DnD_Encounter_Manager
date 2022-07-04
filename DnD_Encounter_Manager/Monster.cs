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
        public int speedMov { get; set; }
        public int speedFly { get; set; }
        public int speedClimb { get; set; }
        public int speedSwim { get; set; }

        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public List<string>? DamImmun { get; set; }
        public List<string>? ConImmun { get; set; }
        public List<string>? Sense { get; set; }
        public List<string>? Language { get; set; }
        public List<string>? Feature { get; set; }
        public List<string>? Action { get; set; }
        public int LegendaryAct { get; set; }
        public string? MonNotes { get; set; }
        public string? Type { get; set; }
        public string? Alignment { get; set; }

    }
}
