using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hair_Salon
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
        public static IEnumerable<T> GetEntities<T>(string path) where T : IEntity, new()
        {
            var list = new List<T>(); 
            var lines = File.ReadAllLines(path); 

            foreach (var line in lines) 
            {
                var entity = new T(); 
                entity.Parse(line); 
                list.Add(entity);
                yield return entity;
            }
        }

    }
}