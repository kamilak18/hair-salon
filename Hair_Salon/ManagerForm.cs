using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hair_Salon
{
    public partial class ManagerForm : MaterialForm
    {
        public ManagerForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE
            );
        }

        private void takeOrderButton_Click(object sender, EventArgs e)
        {

            string fullname = fullName.Text.Trim();
            string password = passwordBox.Text.Trim();
            Guid id = Guid.NewGuid();

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please, fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Manager manager = new Manager(id, fullname, password);

                string[] clients = File.ReadAllLines("clients.txt");

                manager.ReadPersons("clients.txt", clientsListBox);
                manager.ReadPersons("hairdressers.txt", hairdresserListBox);

            }
        }
        private void scheduleButton_Click(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedItem == null || hairdresserListBox.SelectedItem == null)
            {
                MessageBox.Show("Select a hairdresser and a client.");
                return;
            }
            string fullname = fullName.Text.Trim();
            string password = passwordBox.Text.Trim();
            Guid id = Guid.NewGuid();

            Manager manager = new Manager(id, fullname, password);

            manager.ScheduleWithHairdressers(clientsListBox, hairdresserListBox, "clients.txt", "appointments.txt");
        }

        private void showAppButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appForm = new AppointmentForm();
            appForm.Show();
            this.Hide();
        }

       
    }
}
