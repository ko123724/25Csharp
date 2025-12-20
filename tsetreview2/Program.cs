using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsetreview2
{
    public class unitparent
    {
       protected int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
       protected string name;

    

        public int Gethp()
        {
            return hp;
        }
        public void Setup(int _hp)
        {
            hp = _hp;
        }
    }
    public class player : unitparent
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
         for (int i = 0; i < args.Length; i++)
            {
                int temp
            }
        }
    }
}
