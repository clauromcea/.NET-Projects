using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Security.Cryptography;

namespace BL
{
    public class UserService
    {
        public UserService()
        {
            
        }

        public User login(String username, String password)
        {
            UserDAL conn = new UserDAL();
            return conn.getUser(username, getMd5Hash(password));
        }

        static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public User getUser(string username)
        {
            UserDAL conn = new UserDAL();
            return conn.getUser(username);
        }

        public String addUser(User user, out bool ok)
        {
            UserDAL conn = new UserDAL();

            if (conn.checkUser(user.Username))
            {
                ok = false;
                return "Username deja existent!";
            }
            else
            {
                user.Password = getMd5Hash(user.Password);

                if (conn.addUser(user))
                {
                    ok = true;
                    return "Utilizatorul a fost adaugat cu success!";
                }
                else
                {
                    ok = false;
                    return "Utilizatorul nu a putut fi adaugat!";
                }
            }
        }

        public String deleteUser(int ID)
        {
            UserDAL conn = new UserDAL();
            if (!conn.checkUser(ID))
            {
                return "Utilizatorul nu exista!";
            }
            else
            {
                if (conn.deleteUser(ID))
                {
                    return "Utilizatorul a fost sters cu success!";
                }
                else
                {
                    return "Utilizatorul nu a putut fi sters!";
                }
            }
        }

        public String updateUser(User user)
        {
            UserDAL conn = new UserDAL();
            if (!conn.checkUser(user.ID))
            {
                return "Utilizatorul nu exista!";
            }
            else
            {
                if (conn.updateUser(user))
                {
                    return "Datele utilizatorului au fost modificate!";
                }
                else
                {
                    return "Datele utilizatorului nu au putut fi modificate!";
                }
            }
        }

        public List<User> getUsersList()
        {
            UserDAL conn = new UserDAL();
            return conn.getUsersList();
        }

        public static bool resetPassword(string username, string password)
        {
            UserDAL conn = new UserDAL();
            return conn.resetPassword(username, getMd5Hash(password));
        }
    }
}
