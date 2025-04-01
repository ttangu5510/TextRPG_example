using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_example.Item;

namespace TextRPG_example
{
    public class Player
    {
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int exp;
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }
        private int defence;
        public int Defence
        {
            get { return defence; }
            set {  defence = value; }
        }
        private List<Item.Item> inventory;
        public List<Item.Item> Inventory { get { return inventory; } set { inventory = value; } }
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }

        }
        private int gold;
        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        public Player()
        {
            Inventory = new List<Item.Item>();
            Level = 1;
            Exp = 0;
            Power = 5;
            Defence = 3;
            Speed = 5;
            Gold = 1000;
        }
    }
}
