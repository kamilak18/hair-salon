using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace hair_salon_system
{
    public class User : Entity, IEntity
    {
        protected string FullName { get; set; }

        public User(Guid id, string fullname) : base(id)
        {
            FullName = fullname;
        }
        public override string Format()
        {
            return $"{base.Format()}[{FullName}]";

        }
        public bool Search(string searchString)
        {
            return FullName!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }


    }
}



