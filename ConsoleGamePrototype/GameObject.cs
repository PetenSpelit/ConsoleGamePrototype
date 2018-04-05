using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGamePrototype
{
    /**
     * All classes that interact with the level, need to be extending this class.
     */
    abstract class GameObject
    {
        private int[] place;
        private bool walkOver; // false when you can't walk over the object.

        public GameObject(int x, int y, bool walkOver)
        {
            this.place = new int[] { x, y };
            this.walkOver = walkOver;
        }
        public int[] Place {
            get { return place; }
        }
        public bool WalkOver {
            get { return walkOver; }
        }

        public void SetPlace(int x, int y)
        {
            place[0] = x;
            place[1] = y;
        }
    }
}
