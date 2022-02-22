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
        // Create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        // Capture the customer values
        Customer.Username = txtCustomerUsername.Text;
        Customer.Password = txtCustomerPassword.Text;
        //Customer.DateAdded = txtCustomerDateAdded.Text;
        Customer.Active = cbxCustomerActive.Checked;
        //Customer.ID = txtCustomerNo.Text;
        Customer.Address = txtCustomerAddress.Text;
        // Store ID in session object
        Session["Customer"] = Customer;
        // Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}