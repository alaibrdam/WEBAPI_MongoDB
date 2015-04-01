using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using TwitterGate.DAL;


namespace AlaaDamiri
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1699/");

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getTopFollowers").Result;
            if (response.IsSuccessStatusCode)
            {
                var lstTweets = response.Content.ReadAsAsync<List<entTweetView>>().Result;


                GridView1.DataSource = lstTweets;
                GridView1.DataBind();
            }
            else
            {
                //Something has gone wrong, handle it here
            }





        }
    }
}