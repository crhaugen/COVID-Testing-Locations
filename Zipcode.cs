using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace COVIDLocationTracker
{
    public class Zipcode
    {
        public int getDistance(string zipcode, string zipcode1)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.zipcodeapi.com/rest/");
                string key = "";
                HttpResponseMessage response = client.GetAsync(key + "/distance.json/" + zipcode + "/" + zipcode1 + "/mile").Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    //Debug.WriteLine(result);
                    //var location = JsonConvert.DeserializeObject<List<Location>>(result);
                    List<LocationInfo> location = JsonConvert.DeserializeObject<List<LocationInfo>>(result);

                    

                    //for (int i = 0; i < location.Count(); i++)
                    //{
                    //    Debug.WriteLine(location[i].name);
                    //}



                }
                else
                {
                    //todo: print out status if hour limt of request was used
                    Debug.WriteLine("Unsuccessful request, Status Code: " + response.StatusCode);
                }
            }

            return null;

        }
    }
}