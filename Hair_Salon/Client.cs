using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hair_Salon
{
    public class Client : User
    {
        private string Date { get; set; }
        private string Hairstyle { get; set; }

        private string Price { get; set; }

        public Client(Guid id, string fullname, string date, string hairstyle, string price) : base(id, fullname)
        {
            Date = date;
            Hairstyle = hairstyle;
            Price = price;
        }
        public override string Format()
        {
            return $"{base.Format()}[{Hairstyle}][{Date}][{Price}]";
        }

        public void BookAppointment(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(Format());
            }

        }






    }
}

