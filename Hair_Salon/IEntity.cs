using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hair_Salon
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool Search(string searchString);
        public void Parse(string record);
        public bool IsValid();
    }

}