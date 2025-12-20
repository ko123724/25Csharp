using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tsetreview2
{

    public class Inven
    {
       
    }

    public class Item
    {
        string name;
        public string Name { get { return name; } }
        int price;
        public int Price { get { return price; } }

        public string GetName() { return name; }
        public Item(string _name, int _price)
        {  name = _name; price = _price;}
        
    }
    public class Class1
    {
        static void Main(string[] args)
        {
            Item itemA = new Item();
            Item itemB = new Item();
            Item itemc = new Item();
        }
    }
}
