using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XuMengyun1203SkySharkWebApplication
{
    public partial class MonthsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IstMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IstMonth.Items.Add("January");
            IstMonth.Items.Add("February");
            IstMonth.Items.Add("March");
            IstMonth.Items.Add("April");
            IstMonth.Items.Add("May");
            IstMonth.Items.Add("Jun");

            IstMonth.Items.Add("July");
            IstMonth.Items.Add("August");
            IstMonth.Items.Add("October");
            IstMonth.Items.Add("November");
            IstMonth.Items.Add("December");
        }
    }
}