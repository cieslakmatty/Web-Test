//[JsonProperty(PropertyName = "Id")]

using System.Collections.Generic;

namespace WebTest {
    class Player {
        public uint match_id { get; set; }
        public int player_slot { get; set; }
        public int[] ability_upgrades_arr { get; set; }
        public Dictionary<string,int> ability_uses { get; set; }
        public int? account_id { get; set; }//STRING???
        public Dictionary<int,int> actions { get; set; }
        public AdditionalUnits[] additional_units { get; set; }
        public int assists { get; set; }
        public Item backpack_0 { get; set; }
        public Item backpack_1 { get; set; }
        public Item backpack_2 { get; set; }
        public Log[] buyback_log { get; set; }
        public int? camps_stacked { get; set; }
        public int? creeps_stacked { get; set; }
        public Dictionary<string,int> damage { get; set; }
        public Dictionary<string, int> damage_inflictor { get; set; }
        public Dictionary<string, int> damage_inflictor_received { get; set; }
        public Dictionary<string, int> damage_taken { get; set; }
        public int deaths { get; set; }
        public int denies { get; set; }
        //public int[] dn_t { get; set; }//WHAT denies_towers?
        public bool? firstblood_claimed { get; set; }
        public int gold { get; set; }
        public int gold_per_min { get; set; }
        public Dictionary<int, int> gold_reasons { get; set; }
        public int gold_spent { get; set; }
        //public int[] gold_t { get; set; }//WHAT
        public int hero_damage { get; set; }
        public int hero_healing { get; set; }
        public Dictionary<string, int> hero_hits { get; set; }
        public Hero hero { get; set; } //Minght expand into class
        public Item item_0 { get; set; }//class?
        public Item item_1 { get; set; }
        public Item item_2 { get; set; }
        public Item item_3 { get; set; }
        public Item item_4 { get; set; }
        public Item item_5 { get; set; }
        public Dictionary<string, int> item_uses { get; set; }
        //<multikill,longest streak>
        public Dictionary<int, int> kill_streaks { get; set; }
        public Dictionary<string, int> killed { get; set; }
        public Dictionary<string, int> killed_by { get; set; }
        public int kills { get; set; }
        public Log[] kills_log { get; set; }
        //public int lane_pos { get; set; }//positions for heatmaps
        public int last_hits { get; set; }
        public bool leaver_status { get; set; }
        public int level { get; set; }
        public int[] lh_t { get; set; }//lasthits_towers?
        public Dictionary<int,int> life_state { get; set; }
        public MaxHeroHit max_hero_hit { get; set; }
        public Dictionary<int, int> multi_kills { get; set; }//<amount_kills,count>
        //public Dictionary<int,Dictionary<int,int>> obs { get; set; }//observers? WHAT EVEN IS THAT?
        //public Log[] obs_left_log { get; set; }//obs positions etc
        //public int obs_log { get; set; }//--"--
        public int obs_placed { get; set; }
        public int? party_id { get; set; }
        public int? party_size { get; set; }
        //public string performance_others { get; set; }//null everywhere
        public PermanentBuffs[] permanent_buffs { get; set; }
        public int pings { get; set; }
        public bool predict_vict { get; set; }
        public Dictionary<string,int?> purchase { get; set; }//<name,amount>*/
        public Log[] purchase_log { get; set; }
        public bool randomed { get; set; }
        public string repicked { get; set; }//might need a fix
        public int roshans_killed { get; set; }
        public int rune_pickups { get; set; }
        public Dictionary<int,int> runes { get; set; }//assume its <position,count>
        public Log[] runes_log { get; set; }
        //public KeyValuePair<int, KeyValuePair<int, int>> sen { get; set; }//sentries fuck that noise
        //public int sen_left_log { get; set; }
        //public int sen_log { get; set; }
        public int sen_placed { get; set; }
        //total stun time on enemy_team
        public float stuns { get; set; }
        public float teamfight_participation { get; set; }//% of teamfights participated in
        //public int times { get; set; }//no clue
        public int tower_damage { get; set; }
        public int towers_killed { get; set; }
        public int xp_per_min { get; set; }
        //public int xp_reasons { get; set; }//TODO
        //public int xp_t { get; set; }//TODO
        public bool radiant_win { get; set; }
        public uint start_time { get; set; }
        public long duration { get; set; }//in sec
        public bool is_radiant { get; set; }
        public bool win { get; set; }
        public bool lose { get; set; }
        public int total_gold { get; set; }
        public int total_xp { get; set; }
        public float kills_per_min { get; set; }
        public int kda { get; set; } //KDA ratio
        public int abandons { get; set; }
        public int neutral_kills { get; set; }
        public int tower_kills { get; set; }
        public int courier_kills { get; set; }
        public int lane_kills { get; set; }
        public int hero_kills { get; set; }
        public int observer_kills { get; set; }
        public int sentry_kills { get; set; }
        public int roshan_kills { get; set; }
        public int necronomicon_kills { get; set; }
        public int ancient_kills { get; set; }
        public int buyback_count { get; set; }
        public int observer_uses { get; set; }
        public float lane_efficiency { get; set; }
        public int lance_efficiency_pct { get; set; }//lane efficiency %
        public int lane { get; set; }//which is which
        public int lane_role { get; set; } //which is which
        public bool is_roaming { get; set; }
        public Dictionary<string,int> purchase_time { get; set; }//<item,time>
        public Dictionary<string, int> first_purchase_time { get; set; }
        //public int item_win { get; set; }//useless, per match
        //public int item_usage { get; set; }//seems broken
        public int purchase_ward_observer { get; set; }
        public int purchase_ward_sentry { get; set; }
        public int purchase_tpscroll { get; set; }
        public int actions_per_min { get; set; }
        //total sec dead
        public int life_state_dead { get; set; }
        public int solo_competetive_rank { get; set; }


        public Player(int backpack_0, int backpack_1, int backpack_2,int hero_id, int item_0, int item_1, int item_2, int item_3, int item_4, int item_5) {
            this.backpack_0 = Items.getItemById(backpack_0);
            this.backpack_1 = Items.getItemById(backpack_1);
            this.backpack_2 = Items.getItemById(backpack_2);
            this.buyback_log = buyback_log;
            this.hero = Heroes.getHeroById(hero_id);
            this.item_0 = Items.getItemById(item_0);
            this.item_1 = Items.getItemById(item_1);
            this.item_2 = Items.getItemById(item_2);
            this.item_3 = Items.getItemById(item_3);
            this.item_4 = Items.getItemById(item_4);
            this.item_5 = Items.getItemById(item_5);
        }
    }
}


