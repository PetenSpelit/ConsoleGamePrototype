using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class MenuController
    {
        private Item viina;
        private Item terva;
        private Item hauta;
        private Player pelaaja;
        private GameController game;
        private String temp;

        public MenuController()
        {
            this.game = new GameController();
            this.pelaaja = new Player("Pera");
            this.viina = new Item("viina", 30);
            this.hauta = new Item("hauta", -10);
            this.terva = new Item("terva", 10);
            this.temp = "";
        }
        public void MainLoop()
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
                game.Start();
            }
            else if (value == 3)
            {
                Start();
            }
            Console.Clear();
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
    }
}