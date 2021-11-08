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
        public Dictionary<string, Object> objects = new Dictionary<string, Object>();
        public string mode = "normal";

        public JSONStorage()
        {
            //this.Load();
        }

        /// <summary>
        /// Return objects dictionary
        /// </summary>
        public Dictionary<string, Object> All()
        {
            return objects;
        }

        /// <summary>
        /// Add a new key-value pair to objects
        /// </summary>
        /// <param name="obj">Object to add to objects dictionary</param>
        public void New(Object obj)
        {
            Type ClassName = obj.GetType();
            string id = ClassName.GetProperty("id").GetValue(obj).ToString();

            string key = $"{ClassName.Name}.{id}";

            //objects is null for some reason
            if (objects == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No objects");
                Console.ResetColor();
            }
            this.objects.Add(key, obj);
            this.Save();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Created {key.ToString()}");
            Console.ResetColor();
        }

        /// <summary>
        /// Serializes objects to JSON and saves to JSON file
        /// </summary>
        public void Save()
        {
            //TODO: Only serializing id. Why?
            string json = JsonSerializer.Serialize(objects);
            string fileName = "storage/inventory_manager.json";
            if (mode == "test")
                fileName = "../../../../storage/inventory_manager.json";             
            File.WriteAllText(fileName, json);
        }

        /// <summary>
        /// Deserializes JSON file to objects dictionary
        /// </summary>
        public void Load()
        {
            //TODO: Make sure it works when file doesn't exist
            string fileName = "storage/inventory_manager.json";
            if (mode == "test")
                fileName = "../../../../storage/inventory_manager.json"; 
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(jsonString);
        }
    }
}
