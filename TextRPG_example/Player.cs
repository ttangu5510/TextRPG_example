﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    public class Player
    {
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
        // TODO : 골드 추가 등
    }
}
