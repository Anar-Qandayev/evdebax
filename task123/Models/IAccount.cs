using System;
using System.Collections.Generic;
using System.Text;

namespace task123.Models
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
