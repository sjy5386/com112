using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace com112
{
    class Graphic
    {
        private string name;
        private UInt64 memory;

        public Graphic()
        {
            ManagementClass managementClass = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                name = System.Convert.ToString(managementObject["Name"]);
                memory = System.Convert.ToUInt64(managementObject["AdapterRAM"]);
            }
        }

        public override string ToString()
        {
            return name + " " + Convert.ByteToGiB(memory) + "GB";
        }
    }
}
