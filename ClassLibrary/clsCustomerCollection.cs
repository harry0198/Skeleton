﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mthisCustomer = new clsCustomer();
        
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActive"]);
                ACustomer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);

                mCustomerList.Add(ACustomer);

                Index++;
            }

        }
        
        public List<clsCustomer> CustomerList 
        { 
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer { 
            get
            {
                return mthisCustomer;
            }
            set
            {
                mthisCustomer = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            } 
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", mthisCustomer.Username);
            DB.AddParameter("@Password", mthisCustomer.Password);
            DB.AddParameter("@Address", mthisCustomer.Address);
            DB.AddParameter("@DateAdded", mthisCustomer.DateAdded);
            DB.AddParameter("@Active", mthisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mthisCustomer.ID);
            DB.AddParameter("@Username", mthisCustomer.Username);
            DB.AddParameter("@Password", mthisCustomer.Password);
            DB.AddParameter("@Address", mthisCustomer.Address);
            DB.AddParameter("@DateAdded", mthisCustomer.DateAdded);
            DB.AddParameter("@Active", mthisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}