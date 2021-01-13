using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace la_viborita
{
    class Input
    {
        private static Hashtable Caro = new Hashtable();
        public static bool KeyPress(Keys key)
        {
            if (Caro[key] == null)
            {
                // if the hashtable is empty then we return flase
                return false;
            }
            // if the hastable is not empty then we return true
            return (bool)Caro[key];



        }
        public static void changeState(Keys key, bool state)
        {
            // this function will change state of the keys and the player with it
            // this function has two arguments Key and state
            Caro[key] = state;

        }
    }
}  
