
namespace WebTest {
    class MaxHeroHit {
        public string type { get; set; }
        public int time { get; set; }
        public bool max { get; set; }
        //the spell
        public string inflictor { get; set; }
        //dealer
        public Hero unit { get; set; }
        //receiver
        public Hero key { get; set; }
        //Damage done
        public int value { get; set; }
        public int player_slot { get; set; }

        public MaxHeroHit(string type, int time, bool max, string inflictor, string unit, string key, int value, int player_slot) {
            this.type = type;
            this.time = time;
            this.max = max;
            this.inflictor = inflictor;
            this.unit = Heroes.getHeroByName(unit);
            this.key = Heroes.getHeroByName(key);
            this.value = value;
            this.player_slot = player_slot;
        }
    }
}
