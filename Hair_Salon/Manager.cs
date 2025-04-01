using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hair_salon_system
{
    sealed class Manager : User
    {
        private string Password { get; set; }
        public Manager(Guid id, string fullname, string password) : base(id, fullname)
        {
            Password = password;
        }


        public void ReadPersons(MaterialListBox listBox, string fileName)
        {
            if (File.Exists(fileName))
            {
                listBox.Items.Clear();
                string[] lines = File.ReadAllLines(fileName);

                foreach (var line in lines)
                {
                    var parts = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
                    if (parts.Length < 3)
                    {
                        var item = new ListViewItem();
                        var masterName = parts[1];
                        string text = $"{masterName}";
                        listBox.Items.Add(new MaterialListBoxItem(text));
                    }
                    else
                    {
                        var item1 = new ListViewItem();

                        var parts1 = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

                        var clientName = parts1[1];
                        var hairstyle = parts1[2];
                        var date = parts1[3];
                        var price = parts1[4];
                        string text1 = $"{clientName}, {hairstyle}, {date}, {price}";
                        listBox.Items.Add(new MaterialListBoxItem(text1));
                    }

                }
            }
            else
            {
                MessageBox.Show("File was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ScheduleWithHairdressers(MaterialListBox listBox1, MaterialListBox listBox2, string fileName1, string fileName2)
        {
            string clientInfo = listBox1.SelectedItem.Text;
            string hairdressers = listBox2.SelectedItem.Text;

            listBox1.Items.Remove(listBox1.SelectedItem);

            string[] parts = clientInfo.Split(new[] { ", " }, StringSplitOptions.None);

            string clientName = parts[0];
            string hairstyle = parts[1];
            string date = parts[2];
            string price = parts[3];

            string[] clients = File.ReadAllLines(fileName1);
            foreach (var line in clients)
            {
                var Data = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
                string id = Data[0];
                string client = Data[1];
                string Date = Data[3];
                string haircut = Data[2];

                if (clientName == client && date == Date && haircut == hairstyle)
                {
                    string clientData = $"[{id}][{client}][{haircut}][{Date}][{price}][{hairdressers}]";

                    using (StreamWriter writer = new StreamWriter(fileName2, true))
                    {
                        writer.WriteLine(clientData);
                    }
                    MessageBox.Show("Appointment scheduled successfully.");
                }
            }

        }

        public override string Format()
        {
            return $"{base.Format()}";
        }


    }
}
