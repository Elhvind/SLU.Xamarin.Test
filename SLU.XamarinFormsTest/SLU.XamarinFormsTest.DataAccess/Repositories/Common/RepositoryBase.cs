using Newtonsoft.Json;
using SLU.XamarinFormsTest.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SLU.XamarinFormsTest.DataAccess.Repositories.Common
{
    public abstract class RepositoryBase<TEntityType> : IRepository<TEntityType> where TEntityType : IDataEntity, new()
    {
        private readonly string _jsonFileName;

        public RepositoryBase(string jsonFileName)
        {
            _jsonFileName = jsonFileName;
        }

        protected ICollection<TEntityType> ReadJsonFile()
        {
            var serializedEntities = File.ReadAllText(JsonFilePath());
            return JsonConvert.DeserializeObject<ICollection<TEntityType>>(serializedEntities);
        }

        protected void WriteJsonFile(ICollection<TEntityType> entities)
        {
            var serializedEntities = JsonConvert.SerializeObject(entities ?? new List<TEntityType>());
            File.WriteAllText(JsonFilePath(), serializedEntities);
        }

        public virtual void Create(TEntityType entity)
        {
            var existingEntities = ReadJsonFile();

            entity.Id = existingEntities.Any()
                ? existingEntities.Max(x => x.Id) + 1
                : 1;

            existingEntities.Add(entity);
            WriteJsonFile(existingEntities);
        }

        public virtual bool Update(int id, TEntityType entity)
        {
            var updated = false;
            var existingEntities = ReadJsonFile();

            foreach (var existingEntity in existingEntities)
            {
                if (existingEntity.Id != id)
                    continue;

                PropertyInfo[] properties = typeof(TEntityType).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (string.Compare(property.Name, nameof(existingEntity.Id), true) == 0)
                        continue;

                    var newValue = entity.GetType().GetProperty(property.Name).GetValue(entity, null);
                    property.SetValue(existingEntity, newValue);
                }

                updated = true;
                break;
            }

            WriteJsonFile(existingEntities);

            return updated;
        }

        public virtual bool Delete(int id)
        {
            var allEntites = ReadJsonFile();
            var filteredEntites = allEntites.Where(x => x.Id != id).ToList();
            WriteJsonFile(filteredEntites);

            return allEntites.Count() != filteredEntites.Count();
        }

        public virtual ICollection<TEntityType> GetAll()
        {
            return ReadJsonFile();
        }

        public virtual TEntityType Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.Id == id);
        }

        private string JsonFilePath()
        {
            if (string.IsNullOrWhiteSpace(_jsonFileName))
                throw new InvalidDataException($"Property: \"{nameof(_jsonFileName)}\" is invalid!");

            var filePath = Path.Combine(Environment.CurrentDirectory, $"Data\\{_jsonFileName}");

            if (!File.Exists(filePath))
                throw new InvalidDataException($"Invalid file path: \"{filePath}\"!");

            return filePath;
        }


    }
}