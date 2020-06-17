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
            getLocations(state, zip);
        }

        protected void getLocations(string state, string userZipCode)
        {
            COVIDLocations locations = new COVIDLocations();
            Zipcode zipcode = new Zipcode();
            Dictionary<int, LocationInfo> locationDistance = new Dictionary<int, LocationInfo>();
            var locationsList = locations.getLocations(state);

            //for every location in state
            //find distance from given zip
            //sort based on nearest distance
            for(int i = 0; i < locationsList.Count; i++)
            {
                int distance = zipcode.getDistance(userZipCode, locationsList[i].physical_address[0].postal_code);
                locationDistance.Add(distance, locationsList[i]);

            }

            var list = locationDistance.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Debug.WriteLine(locationDistance[key]);
            }


        }

    
    }
}