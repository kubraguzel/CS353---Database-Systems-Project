using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs353
{
    public partial class LoginProfile : System.Web.UI.Page
    {
        MysqlDatabase i1;
        protected void Page_Load(object sender, EventArgs e)
        {
            i1 = new MysqlDatabase();
        }
        protected void login_Click(object sender, EventArgs e)
        {

            Response.Redirect("www.google.com.tr");
            string uname = username.Value;
            string pass = password.Value;


        }
    }
}