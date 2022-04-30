using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    public class User : IAccaunt
    {
        private static int _id;


        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        private User()
        {
            _id++;
            ID = _id;
        }
        public User(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }
        public User(string name, string surname, string email, string password):this(name, surname)
        {
            Email = email;
            Password = password;
        }


        public bool PasswordChecker(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;
            bool isAll = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
                {
                    if (char.IsUpper(password[i]))
                    {
                        isUpper = true;
                    }

                    if (char.IsLower(password[i]))
                    {
                        isLower = true;
                    }

                    if (char.IsDigit(password[i]))
                    {
                        isDigit = true;
                    }
                }
                if (isDigit && isUpper && isLower)
                {
                    isAll = true;
                }
            }

            if (isAll)
            {
                Console.WriteLine("Correct Password!");
            }
            else
            {
                Console.WriteLine("Incorrect Password! Please try again.");
            }
            return isAll;
        }

        public string Fullname()
        {
            return Name + " " + Surname;
        }

        public string ShowInfo()
        {
            return $"\n User ID: {ID} \n User Fullname: {Fullname()} \n User email: {Email} ";
            /*\n User Password: {Password}*/
        }
    }
}
