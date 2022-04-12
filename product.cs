using System;
using System.Collections.Generic;
using System.Text;

namespace productselltask
{
    class product :milk
    {
        private string _name;
        private double _price;
        private int _count;
        private double _totallcome;
        public void sell()
        {
           
            if (_count>0)
            {
                Console.WriteLine($"malin adi {_name}");
                Console.WriteLine($"umumi pulun {_totallcome += _price}"); 
                _count--;
                Console.WriteLine($"qalan mal {_count}");

            }
            else
            {
                Console.WriteLine("mehsul qalmayib");
            }
        }
        public string Name
        {
            get => _name;
            
            set
            {
                _name = value;
            }
                
        }
        public double Price
        {
            get => _price;

            set
            {
                _price = value;
            }

        }
        public int Count
        {
            get => _count;

            set
            {
                _count = value;
            }

        }
      
    }
}
