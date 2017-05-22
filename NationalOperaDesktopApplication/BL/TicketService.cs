using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TicketService
    {

        public String addTicket(Ticket ticket, out bool ok)
        {
            bool ok1 = false;

            TicketDAL conn = new TicketDAL();
            ShowDAL conn1 = new ShowDAL();

            //Verifica da ca numarul de locuri al spectacolului este mai mare decat 0 
            if (0 >= conn1.getTicketsNumber(ticket.Spectacol))
            {
                ok = false;
                return "Sala este plina";
            }
            //Verifica da ca biletul a fost deja vandut (daca exista in baza de dare)
            else if (!conn.checkTicket(ticket))
            {
                if (conn.addTicket(ticket))
                {
                    ok = true;
                    //Scade numarul de bilete disponibile dupa ce a vandut un bilet
                    ok1 = conn1.decreaseTicketsNumber(ticket.Spectacol);
                    return "Bilet adaugat cu succes.";
                }
                else
                {
                    ok = false;
                    return "Biletul nu a fost adaugat.";
                }
            }
            else
            {
                ok = false;
                return "Biletul a fost deja cumparat";
            }
        }

        public Ticket getTicket(Ticket ticket)
        {
            TicketDAL conn = new TicketDAL();
            Ticket returnedTicket = null;

            returnedTicket = conn.getTicket(ticket);

            return returnedTicket;
        }

        public String deleteTicket(int id, string numeSpectacol)
        {
            bool ok = false;
            TicketDAL conn = new TicketDAL();
            ShowDAL conn1 = new ShowDAL();

            //Verifica da ca biletul exista in DB
            if (conn.checkTicket(id))
            {
                //sterge biletul daca exista
                if (conn.deleteTicket(id))
                {
                    //Creste numarul de bilete disponibile cu 1 daca un bilet a fost sters din db
                    ok =  conn1.increaseTicketsNumber(numeSpectacol);
                    return "Bieltul a fost sters cu succes.";
                }
                else
                {
                    return "Biletul nu a putut fi sters.";
                }
            }
            else
            {
                return "Biletul nu este inregistrat!";
            }
        }

        //public String updateTicket(int id)
        //{
        //    TicketDAL conn = new TicketDAL();
        //    if (conn.checkTicket(id))
        //    {
        //        if (conn.updateTicket(id))
        //        {
        //            return "Informatiile despre bilet au fst modificate!";
        //        }
        //        else
        //        {
        //            return "Informatiile despre bilet nu au putut fi modificate!";
        //        }
        //    }
        //    else
        //    {
        //        return "Biletul nu este inregistrat!";
        //    }
        //}

        public List<Ticket> getTicketsList()
        {
            TicketDAL conn = new TicketDAL();
            return conn.getTicketsList();
        }
    }
}
