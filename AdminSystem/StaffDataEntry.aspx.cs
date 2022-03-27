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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //creaate an instance of the address Class
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffID.Text = AnStaff.StaffID.ToString();
            txtUsername.Text = AnStaff.Username;
            txtPassword.Text = AnStaff.Password;
            txtRole.Text = AnStaff.Role;
            txtStartDate.Text = AnStaff.StartDate.ToString();
            chkAdmin.Checked = AnStaff.Admin;
        }
    }
}