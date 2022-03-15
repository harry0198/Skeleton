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
        AnStock.GameNm = txtGameName.Text;
        AnStock.Price = Convert.ToInt32(txtPrice.Text);
        AnStock.Active = Convert.ToBoolean(chkAvailability.Checked);
        AnStock.DateAdded = Convert.ToDateTime(txtlReleaseDate.Text);
        AnStock.AgeRat = Convert.ToInt32(txtAgeRating.Text);

        //store the address in the session object
        Session["AnStock"] = AnStock;

        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");

    }
}