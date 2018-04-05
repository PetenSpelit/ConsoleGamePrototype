using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    class Level
    {
        private Dictionary<char, int> grid;
        private GameObject[,] levelGrid;
        public Level()
        {
            this.levelGrid = new GameObject[6,8];
        }
        public CheckPlace(GameObject movingObject)
        {
            foreach (GameObject temp in levelGrid)
            {
                if (temp.Place == movingObject.Place && !temp.WalkOver)
                {
                    //implement "don't go"
                } else if {
                }
            }
        }
    }
}
