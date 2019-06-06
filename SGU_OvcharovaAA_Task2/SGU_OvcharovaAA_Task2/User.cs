using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGU_OvcharovaAA_Task2
{
    class User
    {
        private string lastName;
        private string firstName;
        private string secondName;
        //private int age;
        private DateTime dateOfBirth;

        public User()
        {
        }

        public User(string lastName, string firstName, string secondName, DateTime dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
            DateOfBirth = dateOfBirth;
        }


        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Write correct LastName");
                }
                else
                {
                    lastName = value;
                }

            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Write correct FirstName");
                }
                else
                {
                    firstName = value;
                }

            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 20)
                {
                    throw new ArgumentException("Write correct SecondName");
                }
                else
                {
                    secondName = value;
                }

            }
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public int Age => (DateTime.Now.Year - DateOfBirth.Year);



    }
}
