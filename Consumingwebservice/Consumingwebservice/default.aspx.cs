using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumingwebservice
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void GreetingBtn_Click(object sender, EventArgs e)
        {
            //example of web service
            //localhost.WebService age = new localhost.WebService();

            //example of WCF
            ServiceReference1.Service1Client age = new ServiceReference1.Service1Client(); 

            int day = int.Parse(TextBox1.Text);
            int month = int.Parse(TextBox2.Text);
            int year = int.Parse(TextBox3.Text);

            int finalage = age.CalulateDays(day, month, year);

            Label1.Text = finalage.ToString();
        }

    }
}