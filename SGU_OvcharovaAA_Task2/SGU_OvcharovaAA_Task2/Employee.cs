using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU_OvcharovaAA_Task2
{
    class Employee : User
    {
        private int work_experience;
        private string position;

        public Employee()
        {
        }

        public Employee(string LastName, string FirstName, string SecondName, DateTime DateOfBirth, int workExp, string pos) : base(LastName, FirstName, SecondName, DateOfBirth)
        {
            Work = workExp;
            Position = pos;
        }

        public int Work
        {
            get
            {
                return work_experience;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The work_experience can't be less that zero");
                }
                work_experience = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

      /*  public string Show()
        {
            return ("Сотрудник: {0}{1}{2}, Дата рождения: {3}, Стаж работы:{4}, Должность: {5}", FirstName, SecondName, LastName, DateOfBirth, Work, Position);
        }
        */

    }
}
