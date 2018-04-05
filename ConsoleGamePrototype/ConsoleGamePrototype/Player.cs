using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class Player
    {
        private List<Item> inventory;
        private String name;

        public Player(String name)
        {
            this.name = name;
            this.inventory = new List<Item>();
        }

        public void Collect(Item item)
        {
            inventory.Add(item);
        }
        public List<Item> Inventory
        {
            get { return inventory; }
            set { }
        }
    }
}