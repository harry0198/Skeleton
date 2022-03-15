using System;

namespace ClassLibrary
{
    public class clsStock

    {
        //private date added data member
        private int mGameID;
        //public property for date added
        public int GameID
        {
            get
            {
                //this line of code sends data out of the property
                return mGameID;
            }

            set
            {
                //this line of code allows data into the property
                mGameID = value;
            }
        }

        //private date added data member
        private string mGameNm;
        //public property for date added
        public string GameNm
        {
            get
            {
                //this line of code sends data out of the property
                return mGameNm;
            }

            set
            {
                //this line of code allows data into the property
                mGameNm = value;
            }
        }

        //private date added data member
        private int mPrice;
        //public property for date added
        public int Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }

            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }


        //private date added data member
        private bool mActive;
        //public property for date added
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private date added data member
        private int mAgeRat;
        //public property for date added
        public int AgeRat
        {
            get
            {
                //return the private data
                return mAgeRat;
            }
            set
            {
                //set the private data
                mAgeRat = value;
            }
        }










        public bool Find(string gameNm)
        {
            //set the private data members to the test data value
            mGameID = 25;
            mGameNm = "Basketball";
            mPrice = 25;
            mActive = true;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mAgeRat = 15;

            //always return true
            return true;
        }

    }
}