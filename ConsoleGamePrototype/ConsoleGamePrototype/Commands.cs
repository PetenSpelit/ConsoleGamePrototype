using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class Commands
    {
        private Dictionary<String, int> menuCommands;
        private Dictionary<String, int> gameCommands;
        private int value;
        private bool menuCommand;

        public Commands()
        {
            this.menuCommands = new Dictionary<String, int>();
            this.gameCommands = new Dictionary<String, int>();
            this.value = 0;
            this.menuCommand = false;
            addCommands();
        }
        public int getcommand()
        {
        }
        private void addCommands()
        {
            menuCommands.Add("stop", 1);
            menuCommands.Add("end", 1);
            menuCommands.Add("quit", 1);
            menuCommands.Add("exit", 1);
            menuCommands.Add("start", 2);
            menuCommands.Add("execute", 2);
            menuCommands.Add("play", 2);
            menuCommands.Add("restart", 3);

            gameCommands.Add("up", 1);
            gameCommands.Add("down", 2);
            gameCommands.Add("right", 3);
            gameCommands.Add("left", 4);
            gameCommands.Add("collect", 5);
        }
        public bool checkMenuCommand(String command)
        {
            value = mainCommands[command];
            if (value == 1 || value == 2 || value == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
