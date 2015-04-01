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



namespace TwitterGateConsumer
{
    public partial class _ApiConsumer : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCallWEBApi_Click(object sender, EventArgs e)
        {
            CAllWebAPI(ddlApi.SelectedValue);
        }

        private void CAllWebAPI( string requestUri)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1699/");

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            //try { 
                    HttpResponseMessage response = client.GetAsync(requestUri).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var lstTweets = response.Content.ReadAsAsync<List<entTweetView>>().Result;

                        if (requestUri != "api/getTweets")
                        { 
                            GridView1.DataSource = lstTweets;
                            GridView1.DataBind();
                        }
                        lblNote.Text = "Calling " + requestUri + " Successfully."; 
                    }
                    else
                    {
                        lblNote.Text = "Sorry, Something has gone wrong.";
                    }
            //    }
            //catch (Exception e)
            //{
            //    lblNote.Text = e.Message; 
            //}

        }
    }
}