using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
namespace InventoryLibrary
{
    public class JSONStorage
    {
        /// <summary>
        /// Dictionary of all BaseClass objects
        /// Key is ClassName.id
        /// </summary>
        public Dictionary<string, BaseClass> objects;

        public JSONStorage(Dictionary<string, BaseClass> objects)
        {
            this.objects = objects;
        }

        /// <summary>
        /// Return objects dictionary
        /// </summary>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        /// <summary>
        /// Add a new key-value pair to objects
        /// </summary>
        /// <param name="obj">Object to add to objects dictionary</param>
        public void New(BaseClass obj)
        {
            Type ClassName = obj.GetType();
            string id = obj.id;

            string key = $"{ClassName}.{id}";

            objects.Add(key, obj);
        }

        /// <summary>
        /// Serializes objects to JSON and saves to JSON file
        /// </summary>
        public void Save()
        {
            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText("storage/inventory_manager.json", json);
        }

        /// <summary>
        /// Deserializes JSON file to objects dictionary
        /// </summary>
        public void Load()
        {
            string fileName = "storage/inventory_manager.json";
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}
