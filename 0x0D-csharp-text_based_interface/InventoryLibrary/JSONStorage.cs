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
        public Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();

        public JSONStorage()
        {
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

            //objects is null for some reason
            if (objects == null)
                Console.WriteLine("No objects");
            this.objects.Add(key, obj);
            this.Save();
            this.Load();
            foreach(string k in objects.Keys)
                Console.WriteLine($"{key}: {objects[key]}");
            Console.WriteLine($"Created {key}");
        }

        /// <summary>
        /// Serializes objects to JSON and saves to JSON file
        /// </summary>
        public void Save()
        {
            //TODO: Not serializing all objects correctly. (only shows id)
            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText("storage/inventory_manager.json", json);
        }

        /// <summary>
        /// Deserializes JSON file to objects dictionary
        /// </summary>
        public void Load()
        {
            //TODO: Make sure it works when file doesn't exist
            string fileName = "storage/inventory_manager.json";
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}
