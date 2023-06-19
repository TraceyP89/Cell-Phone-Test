using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneTest
{
     class Cellphone
    {
        //Constructor
        public Cellphone()
        {
            //Constructors will store the value from the properties
            Brand = "";
            Model = "";
            Price = 0m;
        }
        //properties will retrieve the data and sends the data to the constructor to be stored
        public string Brand { get; set; }  
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
