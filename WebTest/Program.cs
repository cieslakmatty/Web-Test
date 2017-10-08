using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace WebTest {
    class Program {
        static void Main(string[] args) {

            Heroes.Init();
            Items.Init();

            MyHttpRequest request;
            string jSonMatchData = string.Empty;
            //LD[9], pudge[6]
            //string matchUrl = @"https://api.opendota.com/api/matches/3435926569";
            //Silencer[9]
            //string matchUrl = @"https://api.opendota.com/api/matches/3431919866";
            //LC[1], Silencer[8]
            string matchUrl = @"https://api.opendota.com/api/matches/3430165459";
            //chat_test
            //string matchUrl = @"https://api.opendota.com/api/matches/3434156771";

            //get match data
            request = new MyHttpRequest(matchUrl);
            jSonMatchData = request.makeRequest();

            //process data
            Match match = JsonConvert.DeserializeObject<Match>(jSonMatchData);

            Console.ReadKey();
        }
    }
}