﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace com112
{
    class Processor
    {
        private string name;
        private double speed;

        public Processor()
        {
            ManagementClass managementClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                name = (string)managementObject["name"];
                speed = Convert.MHzToGHz((UInt32)managementObject.Properties["CurrentClockSpeed"].Value);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
        }

        public override string ToString()
        {
            return name + " @ " + speed + "GHz";
        }
    }
}
