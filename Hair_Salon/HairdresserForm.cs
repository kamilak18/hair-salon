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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hair_Salon
{
    public partial class HairdresserForm : MaterialForm
    {
        public HairdresserForm()
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

        private void showButton_Click(object sender, EventArgs e)
        {
            string fullname = fullName.Text.Trim();
            string password = passwordBox.Text.Trim();
            Guid id = Guid.NewGuid();

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please, fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Hairdresser hairdresser = new Hairdresser(id, fullname, password);
            hairdresser.SaveToFile("hairdressers.txt", fullname);
            hairdresser.ReadPersons("clients.txt", clientsListBox);
        }

        private void serveButton_Click(object sender, EventArgs e)
        {
            string fullname = fullName.Text.Trim();
            string password = passwordBox.Text.Trim();
            Guid id = Guid.NewGuid();

            if (clientsListBox.SelectedItem == null)
            {
                MessageBox.Show("Select a hairdresser and a client.");
            }
            else
            {
                Hairdresser hairdresser = new Hairdresser(id, fullname, password);
                if (hairdresser.CheckPassword(password, "password.txt"))
                {
                    hairdresser.ServeClient(clientsListBox, "served_clients.txt");
                }
                else
                {
                    MessageBox.Show("Your password is not correct");
                }
            }
        }
    }
}
