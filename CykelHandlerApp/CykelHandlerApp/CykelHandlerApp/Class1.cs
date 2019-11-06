using System;
using System.Collections.Generic;
using System.Text;

namespace CykelHandlerApp
{
    class Group 
    {
        public string name; 
        public List<Shop> shops;
    }
    class Shop
    {
        public string name;
        public List<Bike> bikes;
    }
    class Bike
    {
        public string color;
        public int wheelSize;
        public string brands;
        public int price; 
    }
}
