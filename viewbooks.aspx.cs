using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Text.Json;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace WebApplication3
{
    public class PaperLinks
    {
        public List<string> title;
        public List<string> link;

        public void addLink(string q)
        {
            link.Add(q);

        }

        public void addTitle(string q)
        {
            title.Add(q);
        }
    }
    public partial class viewbooks : System.Web.UI.Page
    {
        string url;
        PaperLinks p = new PaperLinks();
        
        public List<string> links = new List<string>();
        public List<string> titles = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //var lis = links;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = TextBox1.Text.Trim();
            string s = "hello"; 
            Response.Write("<script> window.alert(" + s + ");</script>");
            Getpapers(q);
            

            Response.Write("<script> window.alert("+ s +");</script>");
        }

        public async void Getpapers(string q)
        {
            try
            {

                HttpClient client = new HttpClient();

                string baseUrl = "http://api.springernature.com/openaccess/json?api_key=1fa67c2b3227499ff5ce1a7f05b2fa21&p=20&q=Keyword:";
                //string a = "Maths";

                baseUrl = baseUrl + q;

                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage response = client.GetAsync("").Result;  // Blocking call!  

                string responseBody = await response.Content.ReadAsStringAsync();

                

                JObject json = JObject.Parse(responseBody);
                int i = 0;

                //recordCount = (int)json["results"][0]["recordsDisplayed"];

                if (response.IsSuccessStatusCode)
                {

                    //url = json["records"][0]["url"][0]["value"].ToString();
                    
                    while (json["records"][i]["url"][0]["value"]!=null)
                    {
                        links.Add(json["records"][i]["url"][0]["value"].ToString());
                        titles.Add(json["records"][i]["title"].ToString());
                        i++;
                    }
                    
                }

                else
                {
                    Response.Write("<script> window.alert(\" No results found, try other keywords \");</script>");
                }
                
            }
            catch (Exception ex)
            {
                Response.Write("<script> window.alert(" + ex.Message + ");</script>");
            }
        }

    }
}
