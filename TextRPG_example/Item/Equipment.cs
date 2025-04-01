using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public interface IEquiptable
    {
        public void Equip();
    }
    public abstract class Equipment : Item, IEquiptable
    {
        protected string name;
        public string Name {  get { return name; } set { name = value; } }
        protected int power;
        protected int defence;
        protected 
        public abstract void Equip();
    }
}
