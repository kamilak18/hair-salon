using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hair_salon_system
{
    public class Entity
    {
        public string FileName => "user.txt";
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
        }

        public bool IsValid()
        {
            return Id != Guid.Empty;
        }

        public virtual string Format()
        {
            return "[" + Id.ToString() + "]";
        }




    }
}
