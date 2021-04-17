using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject_Spring2021
{
    public class Item
    {
        public int cost;
        public string name;
        public string[] ingredients;

        public Item(int cost, string name, string[] ingredients)
        {
            this.cost = cost;
            this.name = name;
            this.ingredients = ingredients;
        }
    }
    public class Drink
    {
        public string name;
        public int cost;
        public int size;

        public Drink(string name, int cost, int size)
        {
            this.name = name;
            this.cost = cost;
            this.size = size;
        }
    }
    public class Side
    {
        public string name;
        public int cost;

        public Side(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
    public class Combo
    {
        public Item item;
        public Drink drink;
        public Side side;

        public Combo(Item item, Drink drink, Side side)
        {
            this.item = item;
            this.drink = drink;
            this.side = side;
        }
    }
}
