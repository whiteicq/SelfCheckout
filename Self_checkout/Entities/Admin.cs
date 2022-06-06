using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class Admin
    {
        private string _password;
        
        public string Password { get; private set; }
        public Admin(string pass)
        {
            Password = pass;
        }
    }
}
