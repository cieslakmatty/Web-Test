using System;

namespace WebTest {

    [Flags]
    enum BarracksStatus {
        TOP_RANGED = 0,
        TOP_MELEE = 1,
        MID_RANGED = 2,
        MID_MELEE = 4,
        BOT_RANGED = 8,
        BOT_MELEE = 16
    }

    class Match {
        public long match_id { get; set; }
        public BarracksStatus barracks_status_dire { get; set; }
        public BarracksStatus barracks_status_radiant { get; set; }
        public int dire_score { get; set; }
        public int radiant_score { get; set; }
        public int duration { get; set; }
        public int first_blood_time { get; set; }
        public bool radiant_win { get; set; }
        public int start_time { get; set; }
        public int tower_status_dire { get; set; }
        public int tower_status_radiant { get; set; }
        public int[] radiant_gold_adv { get; set; }
        public int[] radiant_xp_adv { get; set; }
        public Objective[] objectives { get; set; }
        public Chat[] chat { get; set; }
        public Player[] players { get; set; }
        public Teamfight[] teamfights { get; set; }

        public Match(long match_id, int barracks_status_dire, int barracks_status_radiant, int dire_score, int radiant_score, int duration, int first_blood_time, bool radiant_win, int start_time, int tower_status_dire, int tower_status_radiant, int[] radiant_gold_adv, int[] radiant_xp_adv, Objective[] objectives, Chat[] chat, Player[] players, Teamfight[] teamfights) {
            this.match_id = match_id;
            this.barracks_status_dire = (BarracksStatus)barracks_status_dire;
            this.barracks_status_radiant = (BarracksStatus)barracks_status_radiant;
            this.dire_score = dire_score;
            this.radiant_score = radiant_score;
            this.duration = duration;
            this.first_blood_time = first_blood_time;
            this.radiant_win = radiant_win;
            this.start_time = start_time;
            this.tower_status_dire = tower_status_dire;
            this.tower_status_radiant = tower_status_radiant;
            this.radiant_gold_adv = radiant_gold_adv;
            this.radiant_xp_adv = radiant_xp_adv;
            this.objectives = objectives;
            this.chat = chat;
            this.players = players;
            this.teamfights = teamfights;
        }
    }
}
