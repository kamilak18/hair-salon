using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hair_Salon
{
    public partial class ClientForm : MaterialForm
    {
        private Dictionary<string, decimal> hairstylePrices = new Dictionary<string, decimal>
        {
            { "Bob", 450 },
            { "Crop", 400 },
            { "Fade", 500 },
            { "Curls", 650},
            { "Soft waves", 450 }
        };
        public ClientForm()
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

        private void bookApp_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();
            string date = dateBox.Text.Trim();
            string hairstyle = comboBox.SelectedItem?.ToString() ?? "Empty";
            string price = labelPrice.Text;
            Guid id = Guid.NewGuid();
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(hairstyle))
            {
                MessageBox.Show("Please, fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Date is not correct");
            }
            else
            {
                Client client = new Client(id, fullName, date, hairstyle, price);
                client.BookAppointment("clients.txt");
                MessageBox.Show("Appointment Confirmed");
                this.Hide();

            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                string selectedHairstyle = comboBox.SelectedItem.ToString();
                if (hairstylePrices.ContainsKey(selectedHairstyle))
                {
                    labelPrice.Text = $"{hairstylePrices[selectedHairstyle]} UAH";
                }
                else
                {
                    MessageBox.Show("Please, choose hairstyle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
