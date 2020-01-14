using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com112
{
    class MemoryCard
    {
        private string manufacturer;
        private UInt64 size;

        public MemoryCard(string manufacturer, UInt64 size)
        {
            this.manufacturer = manufacturer;
            this.size = size;
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
        }

        public UInt64 Size
        {
            get
            {
                return size;
            }
        }
    }
}
