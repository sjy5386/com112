using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace com112
{
    class Storage
    {
        private List<Drive> drives = new List<Drive>(4);

        public Storage()
        {
            ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                string name = (string)managementObject["Model"];
                UInt64 size = (UInt64)managementObject["Size"];
            }
        }

        public Drive GetDrive(int index)
        {
            return drives[index];
        }

        public int GetSize()
        {
            return drives.Count;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Drive drive in drives)
            {
                str += drive + "\n";
            }
            return str;
        }
    }
}
