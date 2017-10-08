using System.Collections.Generic;

namespace WebTest {
    public class TeamfightPlayer {
        public Dictionary<string, int> ability_uses { get; set; }
        public Dictionary<string, int> item_uses { get; set; }
        public Dictionary<string, int?> killed { get; set; }
        public int deaths { get; set; }
        public int buybacks { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
        public int gold_delta { get; set; }
        public int xp_delta { get; set; }
        public int xp_start { get; set; }
        public int xp_end { get; set; }
        //public Dictionary<string,string> deaths_pos { get; set; }//cant be bothered now
    }
    }
