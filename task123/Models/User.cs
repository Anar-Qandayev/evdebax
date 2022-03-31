using System;
using System.Collections.Generic;
using System.Text;

namespace task123.Models
{
    class User : IAccount
    {
        private int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User()
        {
           
            _id++;
                Id=_id;
        }
        public bool PasswordChecker(string password)
        {
            bool isupper = false;
            bool islower = false;
            bool isdigit = false;
            if (password.Length>=8)
            {
              foreach (var item in password)
              {
                if (char.IsUpper(item))
                {
                    isupper=true;
                }
                else if (char.IsLower(item))
                {
                    islower=true;
                }
                else if (char.IsDigit(item))
                {
                    isdigit=true;
                }   
              }
                if (isdigit&&islower&&isupper) return true;

            }
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User id:{Id}\nUser fullname:{Fullname}\nUser email:{Email}");
        }
    }
}
