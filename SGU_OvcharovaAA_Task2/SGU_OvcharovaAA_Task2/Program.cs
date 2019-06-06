using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU_OvcharovaAA_Task2
{
    class Program
    {
        static void Main()
        {
            EmployeeFileStream file = new EmployeeFileStream();
            Employee us = file.Read();
            file.Save(us);
           // User u = new Employee("Ivanov", "Ivan", "Ivanovich", new DateTime(2013-01-01), 5, "director");
        }
    }
}
