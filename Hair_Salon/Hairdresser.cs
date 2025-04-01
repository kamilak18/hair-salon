using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hair_salon_system
{
    class Hairdresser : User
    {
        private string Password { get; set; }
        public Hairdresser(Guid id, string fullname, string password) : base(id, fullname)
        {
            Password = password;
        }

        public void ServeClient(MaterialListBox listBox, string fileName)
        {
            string clientInfo = listBox.SelectedItem.Text;

            string[] parts = clientInfo.Split(new[] { ", " }, StringSplitOptions.None);

            string clientName = parts[0];
            string hairstyle = parts[1];
            string date = parts[2];
            string price = parts[3];

            string servedClientInfo = $"[{clientName}][{hairstyle}][{date}][{price}]";
            listBox.Items.Remove(listBox.SelectedItem);

            string message = $"The client {clientInfo} has been served.";

            MessageBox.Show(message, "Service Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(servedClientInfo + Format());
            }

        }
        public void SaveToFile(string fileName, string info)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(base.Format());
            }
        }


        public void ReadSchedule(string fileName, MaterialListBox listBox)
        {
            if (File.Exists(fileName))
            {
                listBox.Items.Clear();
                string[] lines = File.ReadAllLines(fileName);


                foreach (string line in lines)
                {
                    var item = new ListViewItem();

                    var parts = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

                    var clientName = parts[1];
                    var hairstyle = parts[2];
                    var date = parts[3];
                    var price = parts[4];
                    string text = $"{clientName}, {hairstyle}, {date}, {price}";
                    listBox.Items.Add(new MaterialListBoxItem(text));
                }
            }
            else
            {
                MessageBox.Show("File was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool CheckPassword(string password1, string path)
        {
            string password = File.ReadAllText(path).Trim();
            if (password1 == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string Format()
        {
            return $", {base.Format()}";
        }
    }
}

