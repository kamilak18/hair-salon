using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace hair_salon_system
{
    public class DataManager
    {
        public IEnumerable<IEntity> Entities { get; private set; } = new List<IEntity>();

        public IEntity? this[Guid id]
        {
            get
            {
<<<<<<< Updated upstream
                IEntity? entity = null;

                foreach (var item in Entities)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                return entity;
=======
                return Entities.FirstOrDefault(e => e.Id == id);
>>>>>>> Stashed changes
            }
        }

        public void Add(IEntity entity)
        {
            Entities = Entities.Append(entity);
        }

        public IEnumerable<IEntity> Search(string searchString)
        {
            return Entities.Where(it => it.Search(searchString));
        }

<<<<<<< Updated upstream
        public IEnumerable<IEntity> Filter(FilterDelegate filter)
=======
        public IEnumerable<T> Filter(Func<T, bool> filter)
>>>>>>> Stashed changes
        {
            return Entities.Where(filter);
        }

    }
}
