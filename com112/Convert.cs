using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com112
{
    class Convert
    {
        public static double MHzToGHz(UInt32 mhz)
        {
            double ghz = mhz / 1000;
            return ghz;
        }

        public static int ByteToGB(UInt64 b)
        {
            UInt64 gb = b / 1000 / 1000 / 1000;
            return (int)gb;
        }

        public static int ByteToGiB(UInt64 b)
        {
            UInt64 gib = b / 1024 / 1024 / 1024;
            return (int)gib;
        }
    }
}
