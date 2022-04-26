using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //GET THE NUMBER OF THE ADDRESS TO BE PROCESSED
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        //create an instance of the address book
        clsStaffCollection AllStaff = new clsStaffCollection();
        //find the record to update
        AllStaff.ThisStaff.Find(StaffID);
        //display teh data for this record
        txtStaffID.Text = AllStaff.ThisStaff.StaffID.ToString();
        txtUsername.Text = AllStaff.ThisStaff.Username;
        txtPassword.Text = AllStaff.ThisStaff.Password;
        txtRole.Text = AllStaff.ThisStaff.Role;
        txtStartDate.Text = AllStaff.ThisStaff.StartDate.ToString();
        chkAdmin.Checked = AllStaff.ThisStaff.Admin;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the username
        string Username = txtUsername.Text;
        //capture the password
        string Password = txtPassword.Text;
        //capture the role
        string Role = txtRole.Text;
        //capture the start date
        string StartDate = txtStartDate.Text;
        //capture staff ID
        string StaffID = txtStartDate.Text;
        //capture the admin
        string Admin = chkAdmin.Checked.ToString();
        //variable to store error message
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(StaffID, Username, Password, Role, Admin, StartDate);
        if (Error == "")
        {
            //capture the ID
            AnStaff.StaffID = Convert.ToInt32(StaffID);
            //capture the username
            AnStaff.Username = Username;
            //capture the password
            AnStaff.Password = Password;
            //capture the role
            AnStaff.Role = Role;
            //capture the start date
            AnStaff.StartDate = Convert.ToDateTime(StartDate);
            //capture the admin
            AnStaff.Admin = Convert.ToBoolean(Admin);
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. Addressno = -1 then add the data
            if (Convert.ToInt32(StaffID) == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(Convert.ToInt32(StaffID));
                //set the ThisStaff Property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");
     

        } else
        {
            lblError.Text = Error;
        }

        
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