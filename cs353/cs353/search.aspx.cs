using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cs353
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void searchOnRecipe(object sender, EventArgs e)
        {
            string key = searchRecipe.Value;


            string date1 = Date1.Value;
            string date2 = endDate.Value;

            if (date1 == "" && date2 != "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Enter a valid date')", true);
            }
            else if (date1 != "" && date2 == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Enter a valid date')", true);
            }
            else if (date1 == "" && date2 == "")
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Enter a valid search string')", true);
                }
                else
                    Response.Redirect("/Result.aspx?key=" + key + "&date1=" + date1 + "&date2=" + date2 + "&method=false");
            }
            else
            {
                Response.Redirect("/Result.aspx?key=" + key + "&date1=" + date1 + "&date2=" + date2 + "&method=true");
            }

        }
    }
}