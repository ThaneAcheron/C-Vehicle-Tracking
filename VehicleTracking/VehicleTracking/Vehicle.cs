using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleTracking
{
    class Vehicle
    {
      
   
        public enum VehicleCondition 
        {
        Good,
        Bad,
        Ugly,
        }

    
             public Vehicle()
        {
        } 

        public Vehicle (string newmake , string newmodle , int newcondition , double newprice) 
        {
            Make = newmake;
            modle = newmodle;
            Price = newprice; 
        } 

        #region proporties 

        //MAKE PROPORTY 
        private string mMake;
        public  string Make
        {
        get 
           {
            //returns the value sent 
            return mMake; 
           }
        set   
           {
            //assigns the value set to mMake
            mMake = value;
           }
        }
        
        //MODLE PROPORTY 
        private string mModle = ""; 
        public  string modle 
        {
        get 
        {
            return  mModle; 
        }
        set
        {
            mModle = value; 
        }
        }

        //CONDITION PROPORTY 
        private VehicleCondition mCondition;
        public VehicleCondition condition
        {
            get
            {
                return mCondition; 
            }

            set
            {
                mCondition = value;
            }
        }

        //PRICE PROPORTY 
        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if (value > 0)
                {
                    mPrice = value;
                }
                else
                {
                    mPrice = 0;
                }
            }
        }

        #endregion 

    }
}