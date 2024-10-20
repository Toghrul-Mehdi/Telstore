using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telstrore
{
    internal class Equipment
    {
        public string ProductName;
        public double Price;
        public int Count;

        private int _count;

        public int COUNT
        {
            get { return _count; }
            set { if (value > 0) 
                {
                    _count = value;
                }
            }
        }

        private double _price;

        public  double PRICE
        {
            get { return _price; }

            set { if (value > 0)
                {
                    _price = value;
                } 
            }
        }

        public Equipment(string name,double price,int count)
        {
            ProductName = name;
            Price = price;
            Count = count;
        }




    }
}
