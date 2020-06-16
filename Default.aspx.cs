using System;
using System.Collections.Generic;
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

            

        }

        protected void getLocations(string state, string userZipCode)
        {
            COVIDLocations locations = new COVIDLocations();
            Zipcode zipcode = new Zipcode();

            var locationsList = locations.getLocations(state);

            //for every location in state
            //find distance from given zip
            //sort based on nearest distance
        }
    }
}