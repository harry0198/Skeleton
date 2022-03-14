using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // CustomerID private member variable
        private Int32 mID;
        private DateTime mDateAdded;
        private bool mActive;
        private string mUsername;
        private string mPassword;
        private string mAddress;
        public clsCustomer()
        {
        }

        public bool Find(int customerNo)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add param for customer id
            DB.AddParameter("@CustomerID", customerNo);
            // execute stored proc
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // If one record is found
            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                // Return true indicating everything worked ok
                return true;
            }
            else
            {
                // return false indicating a proble
                return false;
            }
        }

        // CustomerID public property
        public Int32 ID
        {
            get
            {
                // this line of code sends data out of the property
                return mID;
            }
            set
            {
                // this line of code allows data into the property
                mID = value;
            }
        }

        public bool Active 
        { 
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }
       
        public string Username 
        { 
            get
            {
                return mUsername;
            } 
            set 
            {
                mUsername = value;
            } 
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Address
        { 
            get
            {
                return mAddress;
            }
            set 
            {
                mAddress = value;
            }
        }
    }
}