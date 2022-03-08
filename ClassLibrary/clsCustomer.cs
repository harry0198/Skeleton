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
            mID = 21;
            mUsername = "harry0198";
            mPassword = "password";
            mActive = true;
            mAddress = "dmu";
            mDateAdded = Convert.ToDateTime("16/9/2015");
            
            return true;
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