using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary

{
    public class clsStaffCollection
    {
        //private member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();
       public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff detail
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.Username = Convert.ToString(DB.DataTable.Rows[Index]["StaffUsername"]);
                AnStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AnStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AnStaff.Admin = Convert.ToBoolean(DB.DataTable.Rows[Index]["Admin"]);
                AnStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //add the records to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
                
            }
        }



        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //come back to this
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data 
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Username", mThisStaff.Username);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Admin", mThisStaff.Admin);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Username", mThisStaff.Username);
            DB.AddParameter("@Password", mThisStaff.Password);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Admin", mThisStaff.Admin);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}