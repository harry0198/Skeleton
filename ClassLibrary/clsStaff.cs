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
            //set the private data members to teh test data value
            mStaffID = 21;
            mUsername = "Username";
            mPassword = "Password";
            mRole = "Role";
            mAdmin = true;
            mStartDate = Convert.ToDateTime("16/09/2015");
            //always retrun true
            return true;
            
        }
    }


}