using System.IO;
using System.Net;

namespace WebTest {
    class MyHttpRequest {

        private string url = string.Empty;

        public MyHttpRequest(string url) {
            this.url = url;
        }

        public string makeRequest() {

            string jSonData = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream)) {
                jSonData = reader.ReadToEnd();
            }
            return jSonData;
        }
    }
}
