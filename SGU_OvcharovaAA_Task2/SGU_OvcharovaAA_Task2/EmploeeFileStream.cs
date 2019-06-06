using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SGU_OvcharovaAA_Task2
{
    class EmployeeFileStream
    {
        public Employee Read()
        {
            
            User user = new User();
            using (StreamReader file = new StreamReader("input.txt"))
            {

                string[] line = file.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                user.LastName = line[0];
                user.FirstName = line[1];
                user.SecondName = line[2];
                user.DateOfBirth = DateTime.Parse(file.ReadLine());

                var Work = int.Parse(file.ReadLine());
                var Position = file.ReadLine();
                Employee employee = new Employee(user.LastName, user.FirstName, user.SecondName, user.DateOfBirth, Work, Position);

                return employee;
            }

        }
        public void Save(Employee employee)
        {
            using (StreamWriter file = new StreamWriter("output.txt"))
            {
                file.Write("Сотрудник: {0} {1} {2}, Возраст: {3}, Стаж работы:{4}, Должность: {5}", employee.FirstName, employee.SecondName, employee.LastName, employee.Age, employee.Work, employee.Position);
            }
        }
    }
}
