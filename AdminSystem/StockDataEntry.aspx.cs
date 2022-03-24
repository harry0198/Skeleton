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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //capture the game name
        AnStock.GameID = Convert.ToInt32(txtGameID.Text);
        AnStock.GameName = txtGameName.Text;
        AnStock.Price = Convert.ToInt32(txtPrice.Text);
        AnStock.Availability = Convert.ToBoolean(chkAvailability.Checked);
        AnStock.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        AnStock.AgeRating = Convert.ToInt32(txtAgeRating.Text);

        //store the address in the session object
        Session["AnStock"] = AnStock;

        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 GameID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        GameID = Convert.ToInt32(txtGameID.Text);
        //find the record
        Found = AnStock.Find(GameID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtGameID.Text = Convert.ToString(AnStock.GameID);
            txtGameName.Text = AnStock.GameName;
            txtPrice.Text = Convert.ToString(AnStock.Price);
            chkAvailability.Checked = AnStock.Availability;
            txtReleaseDate.Text = Convert.ToString(AnStock.ReleaseDate);
            txtAgeRating.Text = Convert.ToString(AnStock.AgeRating);
        }
    }
}