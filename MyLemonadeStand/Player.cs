using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Player
    {
        //member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;


        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }


        //member methods (CAN DO)

    }
}
