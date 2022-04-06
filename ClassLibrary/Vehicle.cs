using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Vehicle
    {
        //Fields
        private string _make;
        private string _model;
        private int _year;
        private decimal _weight;


        //Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }


        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }

        }
        public decimal Weight
        { 
        get { return _weight; }
            set { _weight = value; }

        }
        //Constructors
        public Vehicle(string make, string model, int year, decimal weight)
        {
            Make = make;
            Model = model;  
            Year = year;
            Weight = weight;

        }
        

        public Vehicle()
        {
        }

        public override string ToString()
        {
            return string.Format($"Vehicle make: {Make}\nVehicle Model: {Model}\n Vehicle Year: {Year}\n Total Weight:  {Weight},");
        }
        //Methods


    }//End class main 
}
