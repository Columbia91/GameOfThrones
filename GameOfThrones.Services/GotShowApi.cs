using GameOfThrones.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace GameOfThrones.Services
{
    public class GotShowApi
    {
        public static Information GetInformation()
        {
            string url = "https://api.got.show/api/general/characters";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }

            using (StreamWriter writer = new StreamWriter("file.json", false, System.Text.Encoding.Default))
            {
                writer.WriteLine(response);
            }

            return JsonConvert.DeserializeObject<Information>(response);
        }
    }
}