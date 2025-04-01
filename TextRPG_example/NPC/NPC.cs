using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.NPC
{
    public interface IConversation
    {
        public void Conversation();
    }

    public abstract class NPC : IConversation
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        protected List<Item.Item> items;
        public List<Item.Item> Items { get { return items; } set { items = value; } }
        public abstract void Conversation();
        public NPC()
        {
            Items = new List<Item.Item>();
        }
    }
}
