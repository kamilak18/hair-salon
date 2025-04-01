using hair_salon_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hair_salon_system
{
    public static class FileManager 
    {
        public static void WriteToFile(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            if (!entity.IsValid())
            {
                throw new Exception("Entity is invalid");
            }
            var record = entity.Format();
            using (StreamWriter writer = new StreamWriter(entity.FileName, true))
            {
                writer.WriteLine(record);
            }

        }
    }
}