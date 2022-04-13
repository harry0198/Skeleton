using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();

        public clsStockCollection()
        {

            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {

                clsStock AnStock = new clsStock();

                AnStock.GameID = Convert.ToInt32(DB.DataTable.Rows[0]["GameID"]);
                AnStock.GameName = Convert.ToString(DB.DataTable.Rows[0]["GameName"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                AnStock.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                AnStock.AgeRating = Convert.ToInt32(DB.DataTable.Rows[0]["AgeRating"]);

                mStockList.Add(AnStock);

                Index++;
            }
        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        
        
        public clsStock ThisStock { get; set; }
    }

      
}