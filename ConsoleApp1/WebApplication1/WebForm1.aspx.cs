using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "AAAAAA";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string temp = this.TextBox1.Text;
            //this.Labell.Text="AAAAA"
            this.Label1.Text = temp + "--";
        }
    }
}