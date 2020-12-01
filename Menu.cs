using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace asdfg
{

    public class Menu
    {
        List<Item> Items = new List<Item>();

        public Menu(List<Item> items)
        {
            this.Items = items;
        }

        public void print()
        {
            List<Item> objListOrder =
   this.Items.OrderBy(item => item.price).ToList();
            objListOrder.Reverse();

            foreach (Item item in objListOrder)
            {
                Console.WriteLine("{0} costs {1}.", item.name, item.price);
            }
        }

    }

}