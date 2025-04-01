using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hair_salon_system
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool Search(string searchString);
    }

}