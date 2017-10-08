using Newtonsoft.Json.Linq;

namespace WebTest {
    public static class Items {
        static Item[] items;

        public static void Init() {

            MyHttpRequest request;
            string jSonData = string.Empty;
            string itemsUrl = @"https://api.steampowered.com/IEconDOTA2_570/GetGameItems/V001/?key=94BF38B3239F45B17C42ABC130F9BDBD&language=en_gb";
            //get item data
            request = new MyHttpRequest(itemsUrl);
            jSonData = request.makeRequest();
            items = JObject.Parse(jSonData).SelectToken("result.items").ToObject<Item[]>();
        }

        public static Item getItemById(int id) {
            return items[id];
        }
        public static Item getItemByName(string name) {
            int i = 0;
            while (items[i].name != name) {
                i++;
            }

            return items[i];
        }
        public static Item getItemByLocalizedName(string localized_name) {
            int i = 0;
            while (items[i].localized_name != localized_name) {
                i++;
            }
            return items[i];
        }
    }

    public class Item {
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public bool secret_shop { get; set; }
        public bool side_shop { get; set; }
        public bool recipe { get; set; }
        public string localized_name { get; set; }
        public string image_address { get; set; }

        public Item(int id, string name, int cost, bool secret_shop, bool side_shop, bool recipe, string localized_name) {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.secret_shop = secret_shop;
            this.side_shop = side_shop;
            this.recipe = recipe;
            this.localized_name = localized_name;
            image_address = "@http://cdn.dota2.com/apps/dota2/images/items/" + name.Replace("item_", "") + "_lg.png";
        }
    }
}