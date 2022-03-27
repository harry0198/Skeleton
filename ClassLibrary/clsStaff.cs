using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //PRIVATE DATA member for the Staff ID property
        private Int32 mStaffID;
        private DateTime mStartDate;
        private String mUsername;
        private String mPassword;
        private String mRole;
        private Boolean mAdmin;

        public clsStaff() { }

        public bool Admin
        {
            get
            {
                return mAdmin;
            }
            set
            {
                mAdmin = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        public string Valid(string staffID, string staffUsername, string staffPassword, string role, string admin, string startDate)
        {
            return "";
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
            } }
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
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }

        public bool Find(int staffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterbyStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["StaffUsername"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                //return that everything worked OK
                return true;

            }
            //if no else was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }


}