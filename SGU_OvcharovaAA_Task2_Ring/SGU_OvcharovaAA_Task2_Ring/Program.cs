using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SGU_OvcharovaAA_Task2_Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            RingFileStream file = new RingFileStream();
            Ring ring = file.Read();
            file.Save(ring);
        }
    }
}
