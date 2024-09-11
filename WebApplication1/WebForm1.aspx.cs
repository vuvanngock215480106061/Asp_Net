using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, h;
            string errorMessage = "";

            if (!double.TryParse(cao.Text, out a) || a <= 0)
            {
                errorMessage += "Chiều cao phải là số dương. ";
            }
            if (!double.TryParse(huyen.Text, out b) || b <= 0)
            {
                errorMessage += "Cạnh huyền phải là số dương. ";
            }

            if (errorMessage != "")
            {
                lblResult.Text = "Lỗi: " + errorMessage;
            }
            else
            {
                double area = Class1.DienTich(a, b);
                lblResult.Text = $"Diện tích hình tam giác vuông là: {area}";
            }
        }
    }
}