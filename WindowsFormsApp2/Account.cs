using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Account
    {
        int id;
        String firstName;
        String lastName;
        String email;
        String password;
        String type;

        public Account(int id, String firstName, String lastName, String email, String password, String type)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.type = type;
        }
    }
}
