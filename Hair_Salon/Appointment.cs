using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hair_Salon
{
    public class Appointment : Entity
    {

        public string? ClientName { get; set; }
        public string? Hairstyle { get; set; }
        public DateTime? Date { get; set; }
        public string? Price { get; set; }
        public string? HairdresserName { get; set; }

        public Appointment()
        {
            ClientName = "";
            Hairstyle = "";
            Date = null;
            Price = "";
            HairdresserName = "";
        }
        public Appointment(Guid id, string clientName, string? hairstyle, DateTime? date, string? price, string? hairdresserName) : base(id)
        {
            ClientName = clientName;
            Hairstyle = hairstyle;
            Date = date;
            Price = price;
            HairdresserName = hairdresserName;
        }
        public override bool Search(string searchString)
        {

            return ClientName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
              HairdresserName!.Contains(searchString, StringComparison.OrdinalIgnoreCase);

        }

        public override void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);

            if (parts.Length != 6)
            {
                throw new FormatException("Invalid record format.");
            }

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            Id = id;
            ClientName = parts[1];
            Hairstyle = parts[2];
            string date = parts[3];
            if (!DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                throw new FormatException("Invalid date format.");
            }

            Date = parsedDate;
            Price = parts[4];
            HairdresserName = parts[5];

        }
        public override string Format()
        {
            return $"{base.Format()}[{ClientName}][{Hairstyle}][{Date}][{Price}][{HairdresserName}]";
        }
    }
}
