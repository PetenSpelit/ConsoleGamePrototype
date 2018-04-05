using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class GameController
    {
        private Item viina;
        private Item terva;
        private Item hauta;
        private Player pelaaja;
        private Dictionary<String, int> mainCommands;
        private Dictionary<String, int> gameCommands;
        private String temp;
        private int value;
        private bool running;

        public GameController()
        {
            this.mainCommands = new Dictionary<String, int>();
            this.gameCommands = new Dictionary<String, int>();
            this.pelaaja = new Player("Pera");
            this.viina = new Item("viina", 30);
            this.hauta = new Item("hauta", -10);
            this.terva = new Item("terva", 10);
            this.temp = "";
            this.value = 0;
            this.running = false;
        }

        public void MainLoop()
        {
            do
            {
                Console.WriteLine("Give a command.");
                temp = Console.ReadLine();
                value = commands[temp];
                if (value == 1)
                {
                    running = false;
                    Console.WriteLine("You have quitted the game");
                }
                else if (value == 2)
                {
                    Start();
                }
                else
                {
                    running = true;
                }
            } while (running);
            Console.Clear();
        }
        public void CheckInventory()
        {
            foreach (Item name in pelaaja.Inventory)
            {
                String temp = name.ItemName;
                Console.Write(temp);
                foreach(Item score in pelaaja.Inventory)
            }
        }
        public void Start()
        {
            Console.WriteLine("Starting the game...");
            do
            {
                Console.WriteLine("Press any key");
                Console.ReadLine();
                MainLoop();
            } while (running);
        }
        private void addCommands()
        {
            mainCommands.Add("stop", 1);
            mainCommands.Add("end", 1);
            mainCommands.Add("quit", 1);
            mainCommands.Add("exit", 1);
            mainCommands.Add("start", 2);
            mainCommands.Add("execute", 2);
            mainCommands.Add("continue", 3);
            gameCommands.Add("up", 4);
            gameCommands.Add("down", 4);
            gameCommands.Add("right", 4);
            gameCommands.Add("left", 4);
            gameCommands.Add("collect", 4);
        }
    }
}