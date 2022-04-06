using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3LabLibrary
{
    public class Product
    {
        //FIELDS
        private int _id;
        private string _name;
        private int _modelNumber;
        private string _description;
        private decimal _price;

        //PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        //CONSTRUCTORS

        public Product(int id, string name, int modelNumber, string description, decimal price)
        {
            Id = id;
            Name = name;
            ModelNumber = modelNumber;
            Description = description;
            Price = price;

        }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Product ID: {Id}\nProduct Name: {Name}\nModel Number: {ModelNumber}\nDescription: {Description}\n" +
                $"Price: {Price:c}");
        }
    }
}