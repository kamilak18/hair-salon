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

namespace Hair_Salon
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

        public override string Format()
        {
            return $", {base.Format()}";
        }

        public bool CheckPassword(string password, string file)
        {
            string password1 = File.ReadAllText(file).Trim();
            if (password == password1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

