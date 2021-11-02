using System;
using System.Collections.Generic;
namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string name { get; set; }
        public string description;
        public float? price;
        public List<string> tags;

        public Item(string name, string description=null, List<string> tags=null, float? price)
        {
            this.name = name;
            this.description = description;
            // TODO: Go back and limit to 2 decimal places
            this.price = price;
        }
    }
}
