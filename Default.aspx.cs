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
                return;
            }

            string state = StateSelect.SelectedValue;

            if(state.Length == 0)
            {
                Output.Text = "Please select state and try again";
            }
           

            Output.Text = getLocations(state, zip);
        }

        protected string getLocations(string state, string userZipCode)
        {
            COVIDLocations locations = new COVIDLocations();
            Zipcode zipcode = new Zipcode();
           
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
                string name = "<b>Name:</b> " + pair.Value.name;
                string description = "<b>Information:</b> " + pair.Value.description;
                string distance = "<b>Distance from your location:</b> " + pair.Key + " miles";
                string phone = "<b>Phone Number:</b> " + pair.Value.phones[0].number;
                string address = "<b>Address:</b> " + pair.Value.physical_address[0].address_1 + " " + pair.Value.physical_address[0].city;
                output += name + "<br>" + description + "<br><br>" + phone + "<br>" + address + "<br>" + distance + "<br><br><br>";
            }


            return output;
        }

    
    }
}