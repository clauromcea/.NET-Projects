using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class ShowDAL
    {
        private static ShowDAL _showsDAL = null;
        private String _connectionString = @"DATA Source=CLAU-PC;Initial Catalog=OperaNationalaTimisoara;User ID=sa;Password=root";

        SqlConnection _conn = null;

        public ShowDAL()
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

        public static ShowDAL getInstance()
        {
            if (_showsDAL == null)
            {
                _showsDAL = new ShowDAL();
            }
            return _showsDAL;
        }

        public ShowDAL getShow()
        {
            return new ShowDAL();
        }

        public Show getShow(int id)
        {
            Show s = null;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Users] WHERE id='" + id + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                /*               
                 * DateTime dt;
                 * DateTime.TryParse(reader["data_premierei"].ToString(), out dt);
                 */
                s = new Show(reader["Gen"].ToString(), reader["Titlu"].ToString(), reader["Regia"].ToString(),
                    reader["Distributia"].ToString(), DateTime.Parse(reader["DataPremierei"].ToString()),
                    Int32.Parse(reader["NumarBilete"].ToString()));
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
            return s;
        }

        public Show getShow(Show show)
        {
            Show s = null;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE gen ='" +
                show.Gen + "'AND titlu = '"+show.Titlu+"'AND regia='"+show.Regia+"'AND distributia = '"+
                show.Distributia + "' and data_premierei ='" + show.DataPremierei.ToString("yyyy-MM-dd HH:mm:ss") + "' and numar_bilete = "+show.NumarBilete;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                s = new Show(int.Parse(reader["id"].ToString()), reader["Gen"].ToString(), reader["Titlu"].ToString(), reader["Regia"].ToString(),
                    reader["Distributia"].ToString(), DateTime.Parse(reader["Data_Premierei"].ToString()),
                    int.Parse(reader["Numar_Bilete"].ToString()));
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
            return s;
        }

        public Boolean checkShow(Show show)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE gen= '"+
                show.Gen+"' AND titlu='" + show.Titlu + "' AND regia = '" + 
                show.Regia + "' AND distributia = '" + show.Distributia + "' AND data_premierei = '" + 
                show.DataPremierei.ToString("yyyy-MM-dd HH:mm:ss") + "';";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    ok = true;
                }               
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

        public Boolean checkShow(int id)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE id = "+id;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    ok = true;
                }
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

        public Boolean checkShow(string titlu)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE titlu = '" + titlu +"'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    ok = true;
                }
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

        public Boolean addShow(Show show)
        {
            Boolean ok = false;
            String sql = "INSERT INTO [OperaNationalaTimisoara].[dbo].[Shows] (gen, titlu, regia, distributia, data_premierei, numar_bilete)" +
                           "VALUES ('" + show.Gen + "', '" + show.Titlu + "', '" + show.Regia + "', '" + show.Distributia + "', '" + show.DataPremierei.ToString("yyyy-MM-dd HH:mm:ss") + "', " + show.NumarBilete + ");";
            
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();
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

        public Boolean deleteShow(int id)
        {
            Boolean ok = false;
            String sql = "DELETE FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE id = " + id + ";";

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                int r = cmd.ExecuteNonQuery();
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

        public Boolean updateShow(Show show)
        {
            bool ok = false;
            String sql = "UPDATE [OperaNationalaTimisoara].[dbo].[Shows] SET gen='" + show.Gen + 
                "', titlu='" + show.Titlu + "', regia='" + show.Regia + "', distributia ='"+show.Distributia+
                "', data_premierei='"+show.DataPremierei.ToString("yyyy-MM-dd HH:mm:ss")+"', numar_bilete = "+show.NumarBilete+" WHERE id=" + show.ID;

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

        //returneaza numarul de bilete disponibile pentru un spectacol
        public int getTicketsNumber(string titlu)
        {
            int numarBilete = 0;

            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows] WHERE titlu='" + titlu+"'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    numarBilete = int.Parse(reader["numar_bilete"].ToString());
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                numarBilete = -1;
            }
            finally
            {
                _conn.Close();
            }

            return numarBilete;
        }

        public bool decreaseTicketsNumber(string titlu)
        {
            bool ok = false;
            string sql = "UPDATE [OperaNationalaTimisoara].[dbo].[Shows] SET  numar_bilete = (numar_bilete - 1) WHERE titlu='" + titlu+"'";

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

        public bool increaseTicketsNumber(string titlu)
        {
            bool ok = false;
            string sql = "UPDATE [OperaNationalaTimisoara].[dbo].[Shows] SET  numar_bilete = (numar_bilete + 1) WHERE titlu='" + titlu+"'";

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

        public List<Show> getShowsList()
        {
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Shows]";
            Show show = null;
            List<Show> showsList = new List<Show>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                foreach (var row in reader)
                {
                    show = new Show(int.Parse(reader["id"].ToString()), reader["gen"].ToString(), reader["titlu"].ToString(), reader["regia"].ToString(), reader["distributia"].ToString(), DateTime.Parse(reader["data_premierei"].ToString()), int.Parse(reader["numar_bilete"].ToString()));
                    //reader.Read();
                    showsList.Add(show);
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

            return showsList;
        }

    }
}
