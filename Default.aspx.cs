using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COVIDLocationTracker
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int zipcode = 0;
            string zip = ZipCode.Text;
            try
            {
                zipcode = Int32.Parse(ZipCode.Text);
            }
            catch (Exception)
            {
                Output.Text = "Invalid zip code. Please try again.";
            }

            string state = StateSelect.SelectedValue;
           

            Output.Text = getLocations(state, zip);
        }

        protected string getLocations(string state, string userZipCode)
        {
            COVIDLocations locations = new COVIDLocations();
            Zipcode zipcode = new Zipcode();
            //Dictionary<int, LocationInfo> locationDistance = new Dictionary<int, LocationInfo>();
            List<KeyValuePair<int, LocationInfo>> locationDistance = new List<KeyValuePair<int, LocationInfo>>();
            var locationsList = locations.getLocations(state);

            //for every location in state
            //find distance from given zip
            //sort based on nearest distance
            for(int i = 0; i < locationsList.Count; i++)
            {
                int distance = zipcode.getDistance(userZipCode, locationsList[i].physical_address[0].postal_code);
                KeyValuePair<int, LocationInfo> item = new KeyValuePair<int, LocationInfo>(distance, locationsList[i]);
                locationDistance.Add(item);

            }

            locationDistance.Sort((k, v) => (k.Key.CompareTo(v.Key)));

            foreach (var pair in locationDistance)
            {
                Debug.WriteLine(pair.Key);
            }

            return displayInformation(locationDistance);

        }

        protected string displayInformation(List<KeyValuePair<int, LocationInfo>> locationDistance)
        {
            string output = "<br><br>";

            foreach (var pair in locationDistance)
            {
                string name = "Name: " + pair.Value.name;
                string description = "Information: " + pair.Value.description;
                string distance = "Distance from your location: " + pair.Key + " miles";
                output += name + "<br>" + description + "<br>" + distance + "<br><br>";
            }


            return output;
        }

    
    }
}