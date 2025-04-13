using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            dataManager = new DataManager<Appointment>();

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
                IEnumerable<IEntity> foundEntities = new List<IEntity>();


                // If user left searchTextBox empty, load all appointments
                if (string.IsNullOrEmpty(searchBox.Text))
                {
                    foundEntities = dataManager.Entities;
                }
                else
                {
                    // Otherwise, perform search on Appointment list
                    // DataManager searches items in DataManager.Entitites list
                    // In this list we added items in showallButton_Click handler
                    foundEntities = dataManager.Search(searchBox.Text);
                }


                foreach (IEntity entity in foundEntities)
                {
                    // We cast our IEntity entity to Appointment type to obtain all required data
                    // Before casting, IEntity had only Id property, but we need all Appointment related (Name, ...)
                    // We can cast IEntity type to Appointment type because Appointment implements IEntity interface

                    var appEntity = entity as Appointment;
                    // If casting is successful, fill our listView with found appointment items

                    if (appEntity != null)
                    {
                        var item = new ListViewItem(appListView.Items.Count + 1 + "");
                        item.SubItems.Add(appEntity.ClientName);
                        item.SubItems.Add(appEntity.Hairstyle);
                        item.SubItems.Add(appEntity.Date.ToString());
                        item.SubItems.Add(appEntity.Price);
                        item.SubItems.Add(appEntity.HairdresserName);
                        item.SubItems.Add(appEntity.Id.ToString());
                        appListView.Items.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }

        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // if there are no entites, we don't perform filter and exit this method
                if (!dataManager.Entities.Any())
                {
                    return;
                }

                // Remove all items from the list to fill the list view only with filtered items
                appListView.Items.Clear();
                IEnumerable<IEntity> filteredEntities = new List<IEntity>();

                if (string.IsNullOrEmpty(fromBox.Text) || string.IsNullOrEmpty(toBox.Text))
                {
                    // If user left fromTextBox and toTextBox empty, load all appointments
                    filteredEntities = dataManager.Entities;
                }
                else
                {
                    // Otherwise, perform filter on Appointment list
                    // DataManager filters items over DataManager.Entitites list
                    // DataManager.Filter accepts a delegate as parameter so we pass the method reference to it

                    filteredEntities = dataManager.Filter(FilterAppointmentsByDate);


                    foreach (IEntity entity in filteredEntities)
                    {
                        // We can simplify casting like this
                        // We check if entity is Appointment type and cast it to Appointment type at the same time

                        if (entity is Appointment appEntity)
                        {
                            var item = new ListViewItem(appListView.Items.Count + 1 + "");
                            item.SubItems.Add(appEntity.ClientName);
                            item.SubItems.Add(appEntity.Hairstyle);
                            item.SubItems.Add(appEntity.Date.ToString());
                            item.SubItems.Add(appEntity.Price);
                            item.SubItems.Add(appEntity.HairdresserName);
                            item.SubItems.Add(appEntity.Id.ToString());

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

                //Get entity using indexer
                IEntity entity = dataManager[id];
                if (entity != null)
                {
                    if (entity is Appointment appointment)
                    {
                        var formattedText = appointment.Format();
                        selectedTextBox.Text = formattedText;
                    }
                }

            }
        }
    }
}
