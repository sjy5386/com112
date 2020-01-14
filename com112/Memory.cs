using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace com112
{
    class Memory
    {
        private List<MemoryCard> memoryCards = new List<MemoryCard>(4);

        public Memory()
        {
            ManagementClass managementClass = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                string manufacturer = (string)managementObject["Manufacturer"];
                UInt64 size = (UInt64)managementObject["Capacity"];
                MemoryCard memoryCard = new MemoryCard(manufacturer, size);
                memoryCards.Add(memoryCard);
            }
        }

        public UInt64 GetTotalSize()
        {
            UInt64 totalSize = 0;
            foreach (MemoryCard memoryCard in memoryCards)
            {
                totalSize += memoryCard.Size;
            }
            return totalSize;
        }

        public override string ToString()
        {
            string str = Convert.ByteToGiB(GetTotalSize()) + "GB\n";
            foreach (MemoryCard memoryCard in memoryCards)
            {
                str += memoryCard + "\n";
            }
            return str;
        }
    }
}
