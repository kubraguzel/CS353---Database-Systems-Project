using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs353
{
    public partial class Result : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        private MysqlDatabase db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new MysqlDatabase();
            string date1 = Request.QueryString["date1"];
            string date2 = Request.QueryString["date2"];
            string check = Request.QueryString["method"];
            if (check == "false")
            {
                db.getResultKeyOnly(Request.QueryString["key"]);
                table.Append("<section>  <h1> Search Results </h1> <div class=\"tbl-header\"> <table cellpadding = \"0\" cellspacing=\"0\" border=\"0\"> <thead> <tr> <th>Title</th> <th>Date</th> <th>Username</th><th>Catagory</th> </tr> </thead> </table> </div>");

                table.Append("<div class=\"tbl - content\"> <table cellpadding = \"0\" cellspacing = \"0\" border = \"0\" ><tbody>");

                for (int i = 0; i < db.i1.Length; i = i + 4)
                {
                    table.Append("<tr>");
                    table.Append("<td>" + db.i1[i] + "</td>");
                    table.Append("<td>" + db.i1[i + 1] + "</td>");
                    table.Append("<td>" + db.i1[i + 2] + "</td>");
                    table.Append("<td>" + db.i1[i + 3] + "</td>");
                    table.Append("</tr>");
                }
                table.Append("</tbody > </table > </div > </section > ");
                TableHolder.Controls.Add(new Literal { Text = table.ToString() });
            }
            else
            {
                db.getResultwithDate(Request.QueryString["key"], Request.QueryString["date1"], Request.QueryString["date2"]);
                table.Append("<section>  <h1> Search Results </h1> <div class=\"tbl-header\"> <table cellpadding = \"0\" cellspacing=\"0\" border=\"0\"> <thead> <tr> <th>Title</th> <th>Date</th> <th>Username</th><th>Catagory</th> </tr> </thead> </table> </div>");

                table.Append("<div class=\"tbl - content\"> <table cellpadding = \"0\" cellspacing = \"0\" border = \"0\" ><tbody>");

                for (int i = 0; i < db.i1.Length; i = i + 4)
                {
                    table.Append("<tr>");
                    table.Append("<td>" + db.i2[i] + "</td>");
                    table.Append("<td>" + db.i2[i + 1] + "</td>");
                    table.Append("<td>" + db.i2[i + 2] + "</td>");
                    table.Append("<td>" + db.i2[i + 3] + "</td>");
                    table.Append("</tr>");
                }
                table.Append("</tbody > </table > </div > </section > ");
                TableHolder.Controls.Add(new Literal { Text = table.ToString() });
            }


        }
    }
}