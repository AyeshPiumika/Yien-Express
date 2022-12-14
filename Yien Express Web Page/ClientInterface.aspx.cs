using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yien_Express_Web_Page
{
    public partial class ClientInterface : System.Web.UI.Page
    {

        YienExpressWebService ye = new YienExpressWebService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string TID = txtTrackingNumber.Text;
            if (txtTrackingNumber.Text.Length > 0) {

                SqlDataSource1.SelectCommand = "SELECT  * FROM tbl_Items WHERE itemid LIKE CONCAT('%', '" + TID + "', '%')";
                SqlDataSource1.DataBind();
                GridView1.DataBind();
                GridView1.Visible = true;
            }

        else{
            Label1.Text = "Please Insert your Tracking Number";
            }

               
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}