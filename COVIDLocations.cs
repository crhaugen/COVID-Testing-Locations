﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;



namespace COVIDLocationTracker
{
    public class COVIDLocations
    {
        public List<LocationInfo> getLocations(string state)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://covid-19-testing.github.io/locations/");
                HttpResponseMessage response = client.GetAsync(state + "/complete.json").Result;

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    Debug.WriteLine(result);
                    //var location = JsonConvert.DeserializeObject<List<Location>>(result);
                    List<LocationInfo> location = JsonConvert.DeserializeObject<List<LocationInfo>>(result);

                    return location;
                    
                    //for (int i = 0; i < location.Count(); i++)
                    //{
                    //    Debug.WriteLine(location[i].name);
                    //}



                }
                else
                {
                    Debug.WriteLine("Unsuccessful request, Status Code: " + response.StatusCode);
                }
            }

            return null;
           
        }
    }


    public class Location
    {
        public LocationInfo[] Property1 { get; set; }
    }

    public class LocationInfo
    {
        public string id { get; set; }
        public string organization_id { get; set; }
        public string name { get; set; }
        public string alternate_name { get; set; }
        public string description { get; set; }
        public string transportation { get; set; }
        public string updated { get; set; }
        public string featured { get; set; }
        public Physical_Address[] physical_address { get; set; }
        public Phone[] phones { get; set; }
        public Regular_Schedule[] regular_schedule { get; set; }
    }

    public class Physical_Address
    {
        public string id { get; set; }
        public string location_id { get; set; }
        public string address_1 { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string state_province { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }

    public class Phone
    {
        public string id { get; set; }
        public string location_id { get; set; }
        public string number { get; set; }
        public string extension { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public string description { get; set; }
    }

    public class Regular_Schedule
    {
        public string id { get; set; }
        public string location_id { get; set; }
        public string weekday { get; set; }
        public string opens_at { get; set; }
        public string closes_at { get; set; }
    }

}