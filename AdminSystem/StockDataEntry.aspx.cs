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

        //capture the game id
        string GameID = txtGameID.Text;
        //capture the game name
        string GameName = txtGameName.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the availability
        string Availability = chkAvailability.Text;
        //capture the release date
        string ReleaseDate = txtReleaseDate.Text;
        //capture the age rating
        string AgeRating = txtAgeRating.Text;
        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnStock.Valid(GameName, ReleaseDate);
        if (Error == "")
        {
            //capture the game id
            AnStock.GameID = Convert.ToInt32(txtGameID.Text);
            //capture the game name
            AnStock.GameName = txtGameName.Text;
            //capture the price
            AnStock.Price = Convert.ToInt32(txtPrice.Text);
            //capture the availability
            AnStock.Availability = chkAvailability.Checked;
            //capture the release date
            AnStock.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            //capture the age rating
            AnStock.AgeRating = Convert.ToInt32(txtAgeRating.Text);
            //create a new instance of the address collection
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisStock property
            StockList.ThisStock = AnStock;
            //add the new record
            StockList.Add();
            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


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