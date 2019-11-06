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

        public string[] getBrand(List<Bike> bikes)
        {
            string[] str = new string[bikes.Count];
            int i = 0;
            while(i > bikes.Count)
            {
                str[i] = bikes[i].brands;
                i++;
            }
            return str;
        }
    }
    class Bike
    {
        public string color;
        public int wheelSize;
        public string brands;
        public int price; 
    }
}
