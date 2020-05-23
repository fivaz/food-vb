using System;

namespace WindowsFormsApp2
{
    public class Account
    {
        public int id;
        public String firstName;
        public String lastName;
        public String email;
        public String password;
        public String type;

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
