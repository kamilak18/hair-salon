using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace hair_salon_system
{
    public class Appointment : Entity, IEntity
    {

        public string? ClientName { get; set; }
        public string? Hairstyle { get; set; }
        public DateTime? Date { get; set; }
        public string? Price { get; set; }
        public string? HairdresserName { get; set; }

        public Appointment(Guid id) : base(id)
        {
            ClientName = " ";
            Hairstyle = "";
            Date = null;
            Price = "";
            HairdresserName = " ";
        }
        public Appointment(Guid id, string clientName, string? hairstyle, DateTime? date, string? price, string? hairdresserName) : base(id)
        {
            ClientName = clientName;
            Hairstyle = hairstyle;
            Date = date;
            Price = price;
            HairdresserName = hairdresserName;
        }
        public bool Search(string searchString)
        {

            return ClientName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
              HairdresserName!.Contains(searchString, StringComparison.OrdinalIgnoreCase);

        }
        public override string Format()
        {
            return $"{base.Format()}[{ClientName}][{Hairstyle}][{Date}][{Price}][{HairdresserName}]";
        }


    }
}
