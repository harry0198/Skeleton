using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Staff Values
        AnStaff.Username = txtUsername.Text;
        AnStaff.Password = txtPassword.Text;
        AnStaff.Role = txtRole.Text;
        AnStaff.StartDate = Convert.ToDateTime(txtStartDate.Text);
        AnStaff.Admin = chkAdmin.Checked;
        AnStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        //store the Username in the Session Object
        Session["AnStaff"] = AnStaff;
        //naviage to the viewer page
        Response.Redirect("StaffViewer.aspx");

        
    }
}