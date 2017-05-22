using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int ID { get; set; }
        private String username;
        private String password;
        private String name;        
        private String role;
        

        public User() { }

        public User(String username, String password, String name, String role)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.role = role;
        }

        public User(int ID, String username, String password, String name, String role)
        {
            this.ID = ID;
            this.username = username;
            this.password = password;
            this.name = name;
            this.role = role;
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Role
        {
            get { return role; }
            set { role = value; }
        }

        
    }
}
