using BL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class AdminForm : Form
    {
        UserService userService;
        ShowService showService;
        List<User> usersList = null;
        List<Show> showsList = null;

        public AdminForm()
        {
            InitializeComponent();
            userService = new UserService();
            showService = new ShowService();
            userControlPanel.Show();
            showControlPanel.Hide();
            usersList = userService.getUsersList();
            showsList = showService.getShowsList();
            LoadDataForUsersTable();
            LoadDataForShowsTable();
        }

        private void LoadDataForShowsTable(){
            foreach (var show in showsList)
            {
                LoadRowForShowsTable(show);
            }
        }

        private void LoadRowForShowsTable(Show show)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewShowsTable.Rows[0].Clone();
            row.Cells[0].Value = show.ID;
            row.Cells[1].Value = show.Titlu;
            row.Cells[2].Value = show.Gen;
            row.Cells[3].Value = show.Regia;
            row.Cells[4].Value = show.Distributia;
            row.Cells[5].Value = show.DataPremierei;
            row.Cells[6].Value = show.NumarBilete;
            row.Cells[7].Value = "Delete";
            row.Cells[8].Value = "Update";
            dataGridViewShowsTable.Rows.Add(row);
        }

        private void LoadDataForUsersTable()
        {
            foreach (var user in usersList)
            {
                LoadRowForUsersTable(user);
            }
        }

        private void LoadRowForUsersTable(User user)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewUsersTable.Rows[0].Clone();
            row.Cells[0].Value = user.ID;
            row.Cells[1].Value = user.Name;
            row.Cells[2].Value = user.Username;
            row.Cells[3].Value = user.Role;
            row.Cells[4].Value = "Delete";
            row.Cells[5].Value = "Update";
            dataGridViewUsersTable.Rows.Add(row);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String name = textBoxName.Text;
            String password = textBoxPassword.Text;
            String role = comboBoxRole.Text;


            if ("".Equals(username) || "".Equals(name) || "".Equals(password) || "".Equals(role))
            {
                lblMessage.Text = "Toate campurile sunt obligatorii!";
            }
            else if (!"casier".Equals(role.ToLower()) && !"admin".Equals(role.ToLower()))
            {
                lblMessage.Text = "Rolul adaugat este incorect!";
            }
            else
            {
                User user = new User(username, password, name, role);

                bool ok = false;
                lblMessage.Text = userService.addUser(user, out ok);

                textBoxUsername.Text = "";
                textBoxName.Text = "";
                textBoxPassword.Text = "";
                comboBoxRole.Text = "";

                if (ok)
                {
                    user = userService.getUser(username);
                    LoadRowForUsersTable(user);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if ("Show".Equals(comboBoxShow.Text))
            {
                //userControlPanel.Hide();
                showControlPanel.Show();
            }
            else if ("User".Equals(comboBoxShow.Text))
            {
                //userControlPanel.Show();
                showControlPanel.Hide();
            }
        }

        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewUsersTable.CurrentRow;
            if (dataGridViewUsersTable.Rows[row.Index].Cells[0].Value != null)
            {
                int id = int.Parse(dataGridViewUsersTable.Rows[row.Index].Cells[0].Value.ToString());

                if (dataGridViewUsersTable.CurrentCellAddress.X == 4)
                {
                    lblMessage.Text = userService.deleteUser(id);
                    dataGridViewUsersTable.Rows.RemoveAt(row.Index);
                }

                if (dataGridViewUsersTable.CurrentCellAddress.X == 5)
                {
                    string name = dataGridViewUsersTable.Rows[row.Index].Cells[1].Value.ToString();
                    string username = dataGridViewUsersTable.Rows[row.Index].Cells[2].Value.ToString();
                    string role = dataGridViewUsersTable.Rows[row.Index].Cells[3].Value.ToString();

                    if ("admin".Equals(role.ToLower()) || "casier".Equals(role.ToLower()))
                    {
                        User user = new User(id, username, "", name, role);
                        lblMessage.Text = userService.updateUser(user);
                    }
                    else
                    {
                        lblMessage.Text = "Rolul adaugat este incorect!";
                    }
                }
            }
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            //System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);

            //customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss";

            //System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            ////System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            string gen = comboBoxGenul.Text;
            string titlu = textBoxTitlu.Text;
            string regia = textBoxRegia.Text;
            string distributia = textBoxDistributia.Text;
            DateTime dataPremierei;// = System.Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            int numarBilete = (int)numericUpDownNumarBilete.Value;


            String dataSiOra = dateTimePickerDataPremierei.Value.Date.ToString().Substring(0, 10) + " " + dateTimePickerOra.Value.TimeOfDay.ToString().Substring(0, 8);
            
            dataPremierei = DateTime.Parse(dataSiOra);

            //String.Format("{0:yyyy-MM-dd HH:mm:ss}", dataPremierei);
            //string.Format("{0:u}", dataPremierei);

            

            if("".Equals(comboBoxGenul.Text) || "".Equals(textBoxTitlu.Text) || "".Equals(textBoxRegia) || "".Equals(textBoxDistributia)){
                lblMessageS.Text = "Toate campurile trebuie completete!";
            }
            else if (!"balet".Equals(comboBoxGenul.Text.ToLower()) && !"opera".Equals(comboBoxGenul.Text.ToLower()) && !"opereta".Equals(comboBoxGenul.Text.ToLower()))
            {
                lblMessageS.Text = "Genul este incorect";
            }
            //else if(numarBilete <= 0)
            //{
            //    lblMessageS.Text = "Numarul de bilete trebuie sa fie mai mare decat 0!"
            //}
            else
            {
                bool ok = false;

                Show show = new Show(gen, titlu, regia, distributia, dataPremierei, numarBilete);
                lblMessageS.Text = showService.addShow(show, out ok);

                comboBoxGenul.Text = "";
                textBoxTitlu.Text = "";
                textBoxRegia.Text = "";
                textBoxDistributia.Text = "";
                dateTimePickerDataPremierei.ResetText();
                dateTimePickerOra.ResetText();
                numericUpDownNumarBilete.Value = 0;

                if (ok)
                {
                    show = showService.getShow(show);
                    LoadRowForShowsTable(show);
                }
            }
        }

        private void dataGridViewShowsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewShowsTable.CurrentRow;
            if (dataGridViewShowsTable.Rows[row.Index].Cells[0].Value != null)
            {
                int id = int.Parse(dataGridViewShowsTable.Rows[row.Index].Cells[0].Value.ToString());

                if (dataGridViewShowsTable.CurrentCellAddress.X == 7)
                {
                    bool ok = false;
                    lblMessageS.Text = showService.deleteShow(id, out ok);
                    if (ok)
                    {
                        dataGridViewShowsTable.Rows.RemoveAt(row.Index);
                    }
                }

                if (dataGridViewShowsTable.CurrentCellAddress.X == 8)
                {
                    string titlu = dataGridViewShowsTable.Rows[row.Index].Cells[1].Value.ToString();
                    string gen = dataGridViewShowsTable.Rows[row.Index].Cells[2].Value.ToString();
                    string regia = dataGridViewShowsTable.Rows[row.Index].Cells[3].Value.ToString();
                    string distributia = dataGridViewShowsTable.Rows[row.Index].Cells[4].Value.ToString();
                    DateTime dataPremierei = DateTime.Parse(dataGridViewShowsTable.Rows[row.Index].Cells[5].Value.ToString());
                    int numarBilete = int.Parse(dataGridViewShowsTable.Rows[row.Index].Cells[6].Value.ToString());

                    if (!"balet".Equals(gen.ToLower()) && !"opera".Equals(gen.ToLower()) && !"opereta".Equals(gen.ToLower()))
                    {                        
                        lblMessageS.Text = "Genul este incorect!";
                    }
                    else if (numarBilete < 0)
                    {
                        lblMessageS.Text = "Numarul de bilete trebuie sa fi intreg pozitiv";
                    }
                    else
                    {
                        Show show = new Show(id, gen, titlu, regia, distributia, dataPremierei, numarBilete);
                        lblMessageS.Text = showService.updateShow(show);
                        dataGridViewShowsTable.Refresh();
                    }
                }
            }
        }
                
    }
}
