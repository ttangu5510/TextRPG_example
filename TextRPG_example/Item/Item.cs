using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public interface IUsable
    {
        public int ItemUse();
        
    }
    public class Item
    {
        protected string name;
        protected string description;
        protected int itemNumber;
        protected int itemId;
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int ItemNumber { get { return itemNumber; } set { itemNumber = value; } }
        public int ItemId { get { return itemId; } set { itemNumber = value; } }
        public Item()
        {
            Name = "";
            Description = "";
            ItemNumber = 1;
            ItemId = 0;
        }

    }
}
