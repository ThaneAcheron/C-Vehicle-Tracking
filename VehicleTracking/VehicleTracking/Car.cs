using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleTracking
{
    class Car: Vehicle 
    {
        public Car () : base() 
    { 
    } 
        //constructor
 
      
        public int mpassangercapacity
       {
            get
            {
                return mpassangercapacity;
            }
            set
            {
                mpassangercapacity = value; 
            }
        }

        public Car(string make, string modle , int condition, double price , int PassangerCapacity ) 
            :base (make,modle,condition,price)
        {
            mpassangercapacity = PassangerCapacity;  
        }
    }
}
