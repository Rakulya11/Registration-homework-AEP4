using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    interface IAccaunt
    {
        bool PasswordChecker(string password);

        string ShowInfo();
    }
}
