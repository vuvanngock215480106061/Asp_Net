using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ClassLibrary1;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                try
                {
                    string jsonString = new System.IO.StreamReader(Request.InputStream).ReadToEnd();

                    var data = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonString);

                    double a = data["soa"];
                    double b = data["sob"];
                    double result = Class1.DienTich(a, b);
                    Response.ContentType = "application/json";
                    Response.Write(JsonConvert.SerializeObject(result));
                }
                catch (Exception ex)
                {
                    Response.Write("Lỗi: " + ex.Message);
                }
            }
        }
    }
}