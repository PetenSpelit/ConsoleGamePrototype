using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class Item
    {
        private String itemName;
        private int score;

        public Item(String name, int score)
        {
            this.itemName = name;
            this.score = score;
        }
        public String ItemName { get; set; }
        public String ItemScore { get; set; }
    }
}