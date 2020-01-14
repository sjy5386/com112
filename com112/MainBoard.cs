using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace com112
{
    class MainBoard
    {
        private string manufacturer;
        private string name;

        public MainBoard()
        {
            ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                manufacturer = managementObject.GetPropertyValue("Manufacturer").ToString();
                name = managementObject.GetPropertyValue("Product").ToString();
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
