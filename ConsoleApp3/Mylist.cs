using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mylist
    {
        private T[] array;
        private int count;
        public int Count { get { return count; } }
        private int capacity;
        public int Capacity { get { return capacity; } }
        public Mylist() { 
        array = new T[4];
            count = 0;
            capacity = array.Length;
        }

        public void Add()
        {
            if(count >capacity)
            {
                Resize();
            }
            array[count] = _data;
            count++;

            private void Resize()
        {
            T[] tempArray = new T[count * 2];
            for(int i =0; i<count; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
        }
    }
}
