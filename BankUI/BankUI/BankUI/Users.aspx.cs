using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankUI.tUsers;

namespace BankUI
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<tUserData> UObj = null;
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44388/api/tUser");
                var consumeapi = hc.GetAsync("tUser");
                consumeapi.Wait();
                var ReadData = consumeapi.Result;
                if (ReadData.IsSuccessStatusCode)
                {
                    var DispalyCrop = ReadData.Content.ReadAsAsync<List<tUserData>>();

                    DispalyCrop.Wait();
                    UObj = DispalyCrop.Result;
                    CropsData.DataSource = UObj;
                    CropsData.DataBind();
                }
                else
                {
                    ErrorMsg.Text = "Please Check API is Running or Not !";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.Text = "An error occurred while fetching data from the API: " + ex.Message;
            }
        }
    }
}
