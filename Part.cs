using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kChermak_PA
{
    public abstract class Part
    {
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;

        }
        static private int _nextPartID = 0;
        static public int NextPartID
        {
            get
            {
                return _nextPartID++;
            }
        }

        static public int PeekAtNextPartID
        {
            get
            {
                return _nextPartID;
            }
        }

        public int PartID { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
