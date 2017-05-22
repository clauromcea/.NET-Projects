using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BL
{
    public class ShowService
    {

        public Show getShow(Show show)
        {
            ShowDAL conn = new ShowDAL();
            return conn.getShow(show);
        }

        public Show getShow(int id)
        {
            ShowDAL conn = new ShowDAL();
            return conn.getShow(id);
        }
        
        public String addShow(Show show, out bool ok)
        {
            ShowDAL conn = new ShowDAL();
            if (!conn.checkShow(show.Titlu))
            {
                if (conn.addShow(show))
                {
                    ok = true;
                    return "Spectacol adaugat cu succes.";
                }
                else
                {
                    ok = false;
                    return "Spectacolul nu a fost adaugat.";
                }
            }
            else
            {
                ok = false;
                return "Spectacolul este deja inregistrat";
            }
        }

        public String deleteShow(int id, out bool ok)
        {
            ShowDAL conn = new ShowDAL();
            if (conn.checkShow(id))
            {
                if (conn.deleteShow(id))
                {
                    ok = true;
                    return "Spectacol sters cu succes.";
                }
                else
                {
                    ok = false;
                    return "Spectacolul nu a fost sters.";
                }
            }
            else
            {
                ok = false;
                return "Spectacolul nu exista!";
            }
        }

        public String updateShow(Show show)
        {
            ShowDAL conn = new ShowDAL();
            if (conn.checkShow(show.Titlu))
            {
                return "Exista un spectacol cu acest nume!";
            }
            else if (conn.checkShow(show.ID))
            {
                if (conn.updateShow(show))
                {
                    return "Informatiile au fast modificate!";
                }
                else
                {
                    return "Informatiile nu au putut fi modificate!";
                }
            }
            else
            {
                return "Spectacolul nu este inregistrat!";
            }
        }

        //public bool editTicketsNumber(int id)
        //{
        //    bool ok = false;

        //    return ok;
        //}

        public List<Show> getShowsList()
        {
            ShowDAL conn = new ShowDAL();
            return conn.getShowsList();
        }
    }
}
