using System;
using System.Collections;
using System.Collections.Generic;
namespace asdfg
{
    class Program
    {
        static void Main(string[] args)
        {

            Item CocaCola = new Item("CocaCola", 1.20);
            Item Fanta = new Item("Fanta", 1.30);
            Item Sprite = new Item("Sprite", 1.40);
            Item Water = new Item("Water", 0.6);

            List<Item> items = new List<Item>();
            items.Add(CocaCola);
            items.Add(Fanta);
            items.Add(Sprite);

            Menu menu = new Menu(items);

            menu.print();




        }
    }
}
