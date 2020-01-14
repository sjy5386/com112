using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com112
{
    class Drive
    {
        private string name;
        private UInt64 size;

        public Drive(string name, UInt64 size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public UInt64 Size
        {
            get
            {
                return size;
            }
        }

        public override string ToString()
        {
            return name + " (" + Convert.ByteToGB(size) + "GB)";
        }
    }
}
