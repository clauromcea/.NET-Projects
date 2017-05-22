using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDAL
    {
        private static TicketDAL _ticketsDAL = null;
        private String _connectionString = @"DATA Source=CLAU-PC;Initial Catalog=OperaNationalaTimisoara;User ID=sa;Password=root";

        SqlConnection _conn = null;

        public TicketDAL()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                _conn = null;
            }

        }

        public static TicketDAL getInstance()
        {
            if (_ticketsDAL == null)
            {
                _ticketsDAL = new TicketDAL();
            }
            return _ticketsDAL;
        }

        public Ticket getTicket(Ticket ticket)
        {
            Ticket returnedticket = null;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Tickets] WHERE nume_spectacol = '" + ticket.Spectacol + "' AND rand = '" + ticket.Rand + "' AND loc = " + ticket.Loc;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                returnedticket = new Ticket(int.Parse(reader["id"].ToString()), reader["nume_spectacol"].ToString(), reader["rand"].ToString(), int.Parse(reader["loc"].ToString()));
                
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
            return returnedticket;
        }

        public Boolean addTicket(Ticket ticket)
        {
            Boolean ok = false;
            String sql = "INSERT INTO [OperaNationalaTimisoara].[dbo].[Tickets] (nume_spectacol, rand, loc)" +
                           "VALUES ('" + ticket.Spectacol + "', '" + ticket.Rand + "', " + ticket.Loc + ");";

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

        public Boolean deleteTicket(int id)
        {
            Boolean ok = false;
            String sql = "DELETE FROM [OperaNationalaTimisoara].[dbo].[Tickets] WHERE id = " + id + ";";

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

        //public Boolean updateTicket(Ticket ticket)
        //{
        //    bool ok = false;
        //    return ok;
        //}

        public Boolean checkTicket(Ticket ticket)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Tickets] WHERE nume_spectacol = '" + ticket.Spectacol + "' AND rand = '" + ticket.Rand + "' AND loc = " + ticket.Loc;
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

        public Boolean checkTicket(int id)
        {
            Boolean ok = false;
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Tickets] WHERE id = " + id + ";";
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

        public List<Ticket> getTicketsList()
        {
            String sql = "SELECT * FROM [OperaNationalaTimisoara].[dbo].[Tickets]";
            Ticket ticket = null;
            List<Ticket> ticketsList = new List<Ticket>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();
                foreach (var row in reader)
                {
                    ticket = new Ticket(int.Parse(reader["id"].ToString()), reader["nume_spectacol"].ToString(), reader["rand"].ToString(), int.Parse(reader["loc"].ToString()));
                    //reader.Read();
                    ticketsList.Add(ticket);
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

            return ticketsList;
        }
    }
}
