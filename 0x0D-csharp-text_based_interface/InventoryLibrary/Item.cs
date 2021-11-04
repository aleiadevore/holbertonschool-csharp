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

        public Item(string name, float? price, string description = null, List<string> tags = null)
        {
            this.name = name;
            this.description = description;
            this.tags = tags;
            // TODO: Go back and limit to 2 decimal places
            this.price = price;
        }
    }
}
