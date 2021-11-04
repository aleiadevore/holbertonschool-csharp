using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        public string id { get; set; }
        public DateTime date_created;
        public DateTime date_updated;

        public BaseClass()
        {
            this.id = System.Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
