using MaterialSkin;
using MaterialSkin.Controls;

namespace Hair_Salon
{
    public partial class HairSalon : MaterialForm
    {
        public HairSalon()
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ClientRole.Checked)
            {
                ClientForm clientForm = new ClientForm();
                clientForm.Show();
                this.Hide();
            }
            else if (HairdresserRole.Checked)
            {
                HairdresserForm hairdresserForm = new HairdresserForm();
                hairdresserForm.Show();
                this.Hide();
            }
            else if (ManagerRole.Checked)
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, choose your role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
