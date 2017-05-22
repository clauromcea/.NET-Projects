using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models;

namespace Tema1
{
    public partial class CashierForm : Form
    {
        TicketService ticketService;
        List<Ticket> ticketsList = null;

        ShowService showService;
        List<Show> showsList = null;

        public CashierForm()
        {
            InitializeComponent();
            ticketService = new TicketService();
            showService = new ShowService();
            ticketsList = ticketService.getTicketsList();
            showsList = showService.getShowsList();
            LoadDataForTicketsTable();
            LoadDataForShowsTable();
        }

        private void LoadRowForTicketsTable(Ticket ticket)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewTicketsTable.Rows[0].Clone();
            row.Cells[0].Value = ticket.ID;
            row.Cells[1].Value = ticket.Spectacol;
            row.Cells[2].Value = ticket.Rand;
            row.Cells[3].Value = ticket.Loc;
            row.Cells[4].Value = "Delete";
            dataGridViewTicketsTable.Rows.Add(row);
        }

        private void LoadDataForTicketsTable()
        {
            foreach (var ticket in ticketsList)
            {
                LoadRowForTicketsTable(ticket);
            }
        }

        private void LoadRowForShowsTable(Show show)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewShowsTable.Rows[0].Clone();
            row.Cells[0].Value = show.ID;
            row.Cells[1].Value = show.Titlu;
            row.Cells[2].Value = show.DataPremierei;
            row.Cells[3].Value = show.NumarBilete;
            dataGridViewShowsTable.Rows.Add(row);
        }

        private void LoadDataForShowsTable()
        {
            foreach (var show in showsList)
            {
                LoadRowForShowsTable(show);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ticket ticket = null;
            bool ok = false;
            string numeSpectacol = textBoxNumeSpectacol.Text;
            string rand = textBoxRand.Text;
            int loc = 0;
            string s = null;
            int n;

            s = rand.Substring(0, 1);

            try
            {
                //loc = int.Parse(numericUpDownLoc.Value.ToString());
                loc = (int)numericUpDownLoc.Value;

                n = int.Parse(s);

                if ("".Equals(textBoxNumeSpectacol.Text) || "".Equals(textBoxRand.Text))
                {
                    labelMessage.Text = "Toate campurile trebuie completate!";
                }
                else if (loc <= 0)
                {
                    labelMessage.Text = "Locul trebuie sa fie un numar intreg pozitiv!";
                }
                else
                {
                    ticket = new Ticket(numeSpectacol, rand, loc);
                    labelMessage.Text = ticketService.addTicket(ticket, out ok);

                    textBoxNumeSpectacol.Text = "";
                    textBoxRand.Text = "";
                    numericUpDownLoc.Value = 0;

                    if (ok)
                    {
                        ticket = ticketService.getTicket(ticket);
                        LoadRowForTicketsTable(ticket);
                    }
                }

            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
                labelMessage.Text = "Randul este invalid!";
            }
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewTicketsTable.CurrentRow;
            if (dataGridViewTicketsTable.Rows[row.Index].Cells[0].Value != null &&
                dataGridViewTicketsTable.Rows[row.Index].Cells[1].Value != null)
            {
                int id = int.Parse(dataGridViewTicketsTable.Rows[row.Index].Cells[0].Value.ToString());
                string numeSpectacol = dataGridViewTicketsTable.Rows[row.Index].Cells[1].Value.ToString();

                if (dataGridViewTicketsTable.CurrentCellAddress.X == 4)
                {
                    labelMessage.Text = ticketService.deleteTicket(id, numeSpectacol);
                    dataGridViewTicketsTable.Rows.RemoveAt(row.Index);
                }
            }
        }


    }
}
