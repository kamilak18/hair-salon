using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hair_salon_system;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hair_Salon
{
    public partial class AppointmentForm : MaterialForm
    {
        private readonly DataManager<Appointment> dataManager;
        public AppointmentForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE
            );
            var appointments = FileManager.GetEntities<Appointment>("appointments.txt");
            foreach (var app in appointments)
            {
                dataManager.Add(app);
                var item = new ListViewItem(appListView.Items.Count + 1 + "");
                item.SubItems.Add(app.ClientName);
                item.SubItems.Add(app.Hairstyle);
                item.SubItems.Add(app.Date.ToString());
                item.SubItems.Add(app.Price);
                item.SubItems.Add(app.HairdresserName);
                item.SubItems.Add(app.Id.ToString());

                appListView.Items.Add(item);
                
            }
        }


        private bool FilterAppointmentsByDate(IEntity entity)
        {
            DateTime? dateFrom = null;
            if (DateTime.TryParse(fromBox.Text, out var dateFromResult))
            {
                dateFrom = dateFromResult;
            }

            DateTime? dateTo = null;
            if (DateTime.TryParse(toBox.Text, out var dateToResult))
            {
                dateTo = dateToResult;
            }

            var app = entity as Appointment;
            if (app != null && app.Date != null && dateFrom != null && dateTo != null)
            {
                return app.Date >= dateFrom && app.Date <= dateTo;
            }
            else
            {
                return false;
            }
        }




        

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // if there are no entites, we don't perform search and exit this method
                if (!dataManager.Entities.Any())
                {
                    return;
                }
                // Remove all items from the list to fill the list view only with found items
                appListView.Items.Clear();
                IEnumerable<Appointment> foundEntities = new List<Appointment>();


                if (string.IsNullOrEmpty(searchBox.Text) &&
                    string.IsNullOrEmpty(fromBox.Text) &&
                    string.IsNullOrEmpty(toBox.Text))
                {
                    // If user left searchTextBox and filterBox empty, load all appointments
                    // sorted and paginated
                    foundEntities = dataManager.Entities
                        .OrderBy(x => x.ClientName)
                        .ThenByDescending(x => x.Price)
                        .Paginate(current_page, PAGE_LIMIT);
                }
                else
                {
                    // Otherwise, perform search and filter on Appointment list using LINQ
                    // and paginate with sorting
                    DateTime? dateFrom = null;
                    if (DateTime.TryParse(fromBox.Text, out var dateFromResult))
                    {
                        dateFrom = dateFromResult;
                    }

                    DateTime? dateTo = null;
                    if (DateTime.TryParse(toBox.Text, out var dateToResult))
                    {
                        dateTo = dateToResult;
                    }
                    foundEntities = dataManager.Entities
                        .Where(e => (string.IsNullOrEmpty(searchBox.Text) || e.Search(searchBox.Text)) &&
                                    (fromBox == null || toBox == null || (e.Date >= dateFrom && e.Date <= dateTo)))
                        .OrderBy(x => x.ClientName)
                        .ThenByDescending(x => x.Price)
                        .Paginate(current_page, PAGE_LIMIT);
                        
                }


                foundEntities.ToList().ForEach(e =>
                {
                    var item = new ListViewItem(appListView.Items.Count + 1 + "");
                    item.SubItems.Add(e.ClientName);
                    item.SubItems.Add(e.Hairstyle);
                    item.SubItems.Add(e.Date.ToString());
                    item.SubItems.Add(e.Price);
                    item.SubItems.Add(e.HairdresserName);
                    item.SubItems.Add(e.Id.ToString());
                    appListView.Items.Add(item);
                });
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }

        }





        private void appListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if item is selected
            if (appListView.SelectedItems.Count > 0)
            {
                //Get the selected index
                int selectedIndex = appListView.SelectedIndices[0];

                //Get the selected item's text
                string selectedItemText = appListView.SelectedItems[0].SubItems[6].Text;
                //Convert to the Guid
                var id = Guid.Parse(selectedItemText);

                //Get only several fields of Appointment
                var data = dataManager.Entities
                    .Where(x => x.Id == id)
                    .Select(x => x.ClientName + " " + x.Hairstyle + " " + x.Date.ToString())
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(data))
                {
                    selectedTextBox.Text = data;
                }

            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            appListView.Items.Clear();
            var appointments = dataManager.Entities
                .OrderBy(x => x.ClientName)
                .ThenByDescending(x => x.Price)
                .Skip(current_page * PAGE_LIMIT)
                .Take(PAGE_LIMIT);

            foreach (var app in appointments)
            {
                var item = new ListViewItem(appListView.Items.Count + 1 + "");
                item.SubItems.Add(app.ClientName);
                item.SubItems.Add(app.Hairstyle);
                item.SubItems.Add(app.Date.ToString());
                item.SubItems.Add(app.Price);
                item.SubItems.Add(app.HairdresserName);
                item.SubItems.Add(app.Id.ToString());

                appListView.Items.Add(item);

            }

        }



        private void Paginate()
        {
            appListView.Items.Clear();

            var data = dataManager.Entities
                .OrderBy(x => x.ClientName)
                .ThenByDescending(x => x.Price)
                .Paginate(current_page, PAGE_LIMIT)
                .ToList();
            data.ForEach(e =>
            {
                var item = new ListViewItem(appListView.Items.Count + 1 + "");
                item.SubItems.Add(e.ClientName);
                item.SubItems.Add(e.Hairstyle);
                item.SubItems.Add(e.Date.ToString());
                item.SubItems.Add(e.Price);
                item.SubItems.Add(e.HairdresserName);
                item.SubItems.Add(e.Id.ToString());

                            appListView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void loadSource_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                appListView.Items.Clear();

                var allappointments = dataManager.Entities
                    .OrderBy(x => x.ClientName)
                    .ThenByDescending(x => x.Price)
                    .ToList();

                allappointments.ForEach(e => dataManager.Add(e));
                allappointments = allappointments.Paginate(0, PAGE_LIMIT).ToList();
                allappointments.ForEach(e =>
                {
                    var item = new ListViewItem(appListView.Items.Count + 1 + "");
                    item.SubItems.Add(e.ClientName);
                    item.SubItems.Add(e.Hairstyle);
                    item.SubItems.Add(e.Date.ToString());
                    item.SubItems.Add(e.Price);
                    item.SubItems.Add(e.HairdresserName);
                    item.SubItems.Add(e.Id.ToString());

                    appListView.Items.Add(item);
                });
            }
        }
    }
}
