using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace WebTest {
    public static class Heroes {
        static Hero[] heroes;

        public static void Init() {

            MyHttpRequest request;
            string jSonData = string.Empty;
            string heroesUrl = @"https://api.steampowered.com/IEconDOTA2_570/GetHeroes/v0001/?key=94BF38B3239F45B17C42ABC130F9BDBD&language=en_gb";
            //get hero data
            request = new MyHttpRequest(heroesUrl);
            jSonData = request.makeRequest();
            heroes = JObject.Parse(jSonData).SelectToken("result.heroes").ToObject<Hero[]>();
        }

        public static Hero getHeroById(int id) {
            return heroes[id];
        }
        public static Hero getHeroByName(string name) {
            int i = 0;
            while (heroes[i].name != name) {
                i++;
            }

            return heroes[i];
        }
        public static Hero getHeroByShortName(string short_name) {
            int i = 0;
            while (heroes[i].short_name != short_name) {
                i++;
            }
            return heroes[i];
        }
        public static Hero getHeroByLocalizedName(string localized_name) {
            int i = 0;
            while (heroes[i].localized_name != localized_name) {
                i++;
            }
            return heroes[i];
        }
    }

    public class Hero {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string localized_name { get; set; }

        public Hero(int id, string name, string localized_name) {
            this.id = id;
            this.name = name;
            this.localized_name = localized_name;
            this.short_name = name.Replace("npc_dota_hero_", "");
        }
    }
    
    struct image_suffix {
        public static string small = "_sb.png";
        public static string lage = "_lb.png";
        public static string full = "_full.png";
        public static string vert = "_vert.png";
    }

    struct image_prefix {
        public static string hero = @"http://cdn.dota2.com/apps/dota2/images/heroes/";
    }
}