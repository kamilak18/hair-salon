using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hair_Salon
{
    public delegate bool FilterDelegate<T>(T entity) where T : IEntity;
}

