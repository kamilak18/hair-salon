using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hair_Salon
{
    public class User : Entity
    {
        protected string FullName { get; set; }

        public User()
        {
            FullName = string.Empty;
        }
        public User(Guid id, string fullname) : base(id)
        {
            FullName = fullname;
        }
        public override string Format()
        {
            return $"{base.Format()}[{FullName}]";

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


        public void ReadPersons(string fileName, MaterialListBox listBox)
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
                        string name = $"{masterName}";
                        listBox.Items.Add(new MaterialListBoxItem(name));
                    }
                    else
                    {
                        var item1 = new ListViewItem();

                        var parts1 = line.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

                        var clientName = parts1[1];
                        var hairstyle = parts1[2];
                        var date = parts1[3];
                        var price = parts1[4];
                        string text = $"{clientName}, {hairstyle}, {date}, {price}";
                        listBox.Items.Add(new MaterialListBoxItem(text));
                    }

                }
            }
            else
            {
                MessageBox.Show("File was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 2)
            {
                throw new FormatException("Invalid record format.");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            Id = id;
            FullName = parts[1];
        }

        public override bool Search(string searchString)
        {
            return FullName!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }

    }
}



