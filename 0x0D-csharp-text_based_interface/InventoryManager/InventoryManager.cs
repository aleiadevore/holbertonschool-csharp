using System;
using InventoryLibrary;
using System.Collections.Generic;

class InventoryManager
{
    public Dictionary<string, Object> objects;
    public JSONStorage storage;

    public InventoryManager()
    {
        this.storage = new JSONStorage();
        try
        {
            storage.Load();
            this.objects = storage.objects;
        }
        catch
        {
            this.objects = null;
        }
    }

    public Dictionary<string, Type> classes = new Dictionary<string, Type>{
        { "baseclass", typeof(BaseClass) },
        { "item", typeof(Item) },
        { "user", typeof(User) },
        { "inventory", typeof(Inventory) }
        };

    static void Main(string[] args)
    {
        while (true)
            Delimate();
    }

    /// <summary>
    /// Delimates user input and sends to appropriate method
    /// </summary>
    public static void Delimate()
    {
        // Print an initial prompt with the available commands and their usage.
        string prompt = "\nInventory Manager\n------------------------\n<ClassNames> show all ClassNames of objects\n<All> show all objects\n<All[ClassName]> show all objects of a ClassName\n<Create[ClassName]> a new object\n<Show[ClassName object_id]> an object\n<Update [ClassName object_id]> an object\n<Delete [ClassName object_id]> an object\n<Exit>\n\n$ ";
        Console.Write(prompt);

        string input = Console.ReadLine().ToLower();

        // Seperate user input by spaces
        string[] words = input.Split(' ');
        InventoryManager manager = new InventoryManager();

        //TODO: Update console color for prompt and usage

        // Use switch to send to different methods
        switch (words[0])
        {
            case "classnames":
                manager.ClassNames();
                return;
            case "all":
                if (words.Length == 2)
                    manager.All(words[1]);
                else
                    manager.All();
                return;
            case "create":
                if (words.Length == 2)
                    manager.Create(words[1]);
                else
                    Console.WriteLine("Usage: Create <ClassName>");
                return;
            case "show":
                if (words.Length == 3)
                    manager.Show(words[1], words[2]);
                else
                    Console.WriteLine("Usage: Show <ClassName> <id>");
                return;
            case "update":
                if (words.Length == 3)
                    manager.Update(words[1], words[2]);
                else
                    Console.WriteLine("Usage: Update <ClassName> <id>");
                return;
            case "delete":
                if (words.Length == 3)
                    manager.Delete(words[1], words[2]);
                else
                    Console.WriteLine("Usage: Delete <ClassName> <id>");
                return;
            case "exit":
                manager.Exit();
                return;
        }
    }

    /// <summary>
    /// Print all class names of objects loaded in JSONStorage
    /// </summary>
    public void ClassNames()
    {
        Dictionary<string, bool> UsedClasses = new Dictionary<string, bool>{
            { "BaseClass", false },
            {"User", false },
            { "Item", false },
            { "Inventory", false }
        };
        foreach (string key in this.objects.Keys)
        {
            if (UsedClasses.ContainsKey(key.Split('.')[0]))
                UsedClasses[key.Split('.')[0]] = true;
        }
        foreach (string key in UsedClasses.Keys)
            if (UsedClasses[key] == true)
                Console.WriteLine(key);
    }

    /// <summary>
    /// Print all objects
    /// </summary>
    public void All(string ClassName=null)
    {
        string oldk;
        string k = null;

        if (objects == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Inventory is empty.");
            Console.ResetColor();
            return;
        }

        // If no class name given, print out every object
        if (ClassName == null)
        {
            foreach (string key in objects.Keys)
            {
                oldk = k;
                k = key.Split('.')[0];

                if (oldk != k)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(k);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                    Console.WriteLine($"\t{objects[key].ToString()}");
            }
        }

        // Incorrect class name given
        else if (classes.ContainsKey(ClassName) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ClassName} is not a valid object type");
            Console.ResetColor();
            return;
        }

        // Correct class name
        else
        {
            // Print class name
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ClassName);
            Console.ResetColor();
            Console.WriteLine();

            // Filter for keys beginning in class name, print each
            foreach (string key in objects.Keys)
            {
                k = key.Split('.')[0];
                if (k.ToLower() == ClassName)
                    Console.WriteLine($"\t{objects[key].ToString()}");
            }
        }
    }

    /// <summary>
    /// Create and save a new object of ClassName
    /// </summary>
    public void Create(string ClassName)
    {
        // Incorrect class name given
        if (classes.ContainsKey(ClassName) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ClassName} is not a valid object type");
            Console.ResetColor();
            return;
        }

        if (ClassName == "baseclass")
        {
            BaseClass obj = new BaseClass();
            storage.New(obj);
        }
        storage.Save();
        storage.Load();
        this.objects = storage.objects;
        /*else if (ClassName == "item")
            storage.New(new Item());
        else if (ClassName == "inventory")
            storage.New(new Inventory());*/

    }

    /// <summary>
    /// Print the string representation of the requested object
    /// </summary>
    public void Show(string ClassName, string id)
    {
        // Incorrect class name given
        if (classes.ContainsKey(ClassName) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ClassName} is not a valid object type");
            Console.ResetColor();
            return;
        }

        // Filter for keys beginning in class name
        foreach (string key in objects.Keys)
        {
            string k = key.Split('.')[1];
            string kId = key.Split('.')[2];
            if (k.ToLower() == ClassName && kId == id)
            {
                Console.WriteLine(objects[key].ToString());
                return;
            }

        }
        // If id is invalid, print: Object<id> could not be found
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Object {id} could not be found");
        Console.ResetColor();
    }

    /// <summary>
    /// Update the properties of the given object
    /// </summary>
    public void Update(string ClassName, string id)
    {
        // Incorrect class name given
        if (classes.ContainsKey(ClassName) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ClassName} is not a valid object type");
            Console.ResetColor();
            return;
        }
        //TODO: Prompt for property to update
        //TODO: Prompt for value of property
        Object obj;
        // Find correct object
        foreach (string key in objects.Keys)
        {
            string k = key.Split('.')[1];
            string kId = key.Split('.')[2];
            if (k.ToLower() == ClassName && kId == id)
            {
                obj = objects[key];
                // Find and set updated time
                obj.GetType().GetProperty("date_updated").SetValue(obj, DateTime.Now);

                // Confirm and save
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Updated {objects[key].ToString()}");
                Console.ResetColor();
                storage.Save();
                storage.Load();
                return;
            }
        }
        // If id is invalid, print: Object<id> could not be found
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Object {id} could not be found");
        Console.ResetColor();
    }

    /// <summary>
    /// Delete the given object from the JSONStorage
    /// </summary>
    public void Delete(string ClassName, string id)
    {
        // Incorrect class name given
        if (classes.ContainsKey(ClassName) == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ClassName} is not a valid object type");
            Console.ResetColor();
            return;
        }

        // Find and delete correct object
        foreach (string key in objects.Keys)
        {
            string k = key.Split('.')[1];
            string kId = key.Split('.')[2];
            if (k.ToLower() == ClassName && kId == id)
            {
                objects.Remove(key);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Deleted {key}");
                Console.ResetColor();
                storage.Save();
                storage.Load();
                return;
            }
        }
        // If id is invalid, print: Object<id> could not be found
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Object {id} could not be found");
        Console.ResetColor();
    }

    /// <summary>
    /// Quits the application
    /// </summary>
    public void Exit()
    {
        System.Environment.Exit(1);
    }
}
