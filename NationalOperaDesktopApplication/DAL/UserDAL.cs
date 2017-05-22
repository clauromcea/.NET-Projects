using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        private static UserDAL _usersDAL = null;
        private String _connectionString = @"DATA Source=CLAU-PC;Initial Catalog=OperaNationalaTimisoara;User ID=sa;Password=root";

        SqlConnection _conn = null;

        public UserDAL()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                //de facut ceva error handling, afisat mesaj, etc..
                _conn = null;
                Console.WriteLine(e.Message);
            }

        }

        public static UserDAL getInstance()
        {
            if (_usersDAL == null)
            {
                _usersDAL = new UserDAL();
            }
            return _usersDAL;
        }

        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
            return u;
        }

        public User getUser(String username)
        {
            User u = null;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE username='" + username + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new User(int.Parse(reader["id"].ToString()), reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }

            return u;
        }

        public Boolean addUser(User user)
        {
            Boolean ok = false;
            String sql = "INSERT INTO [OperaNationalaTimisoara].[dbo].[Users] (username, password, name, role)" +
                           "VALUES ('" + user.Username + "', '" + user.Password + "', '" + user.Name + "', '" + user.Role + "');";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();

                _conn.Close();
                ok = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }
            return ok;
        }

        public Boolean deleteUser(int id)
        {
            Boolean ok = false;
            String sql = "DELETE FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE id = '" + id + "';";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();
                _conn.Close();
                ok = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }
            return ok;
        }

        public Boolean updateUser(User user)
        {
            bool ok = false;
            String sql = "UPDATE [OperaNationalaTimisoara].[dbo].[Users] SET username='"+user.Username+"', name='"+user.Name+"', role='"+user.Role+"' WHERE id="+user.ID;

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();
                ok = true;
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }

            return ok;
        }

        public Boolean resetPassword(string username, string password)
        {
            bool ok = false;
            String sql = "UPDATE [OperaNationalaTimisoara].[dbo].[Users] SET password='" + password + "' WHERE username='" + username+"'";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();
                ok = true;
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }

            return ok;
        }

        public Boolean checkUser(String username)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE username='" + username +"';";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //if (string.IsNullOrEmpty(reader["username"].ToString()))
                if (reader.HasRows)
                {
                    ok = true;
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }
            return ok;
        }

        public Boolean checkUser(int id)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE id=" + id+ ";";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //if (string.IsNullOrEmpty(reader["username"].ToString()))
                if (reader.HasRows)
                {
                    ok = true;
                }
                _conn.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                ok = false;
            }
            finally
            {
                _conn.Close();
            }
            return ok;
        }

        public List<User> getUsersList()
        {
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users]";
            User user = null;
            List<User> usersList = new List<User>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();
                foreach (var row in reader)
                {                    
                    user = new User(int.Parse(reader["id"].ToString()), reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                    //reader.Read();
                    usersList.Add(user);
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
            
            return usersList;
        }
    }
}
