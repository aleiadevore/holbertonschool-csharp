using System;
using InventoryLibrary;
using System.Collections.Generic;

class InventoryManager
{
    public Dictionary<string, BaseClass> objects;
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
        //TODO: Print an initial prompt with the available commands and their usage.
        Console.WriteLine("Prompt");

        string input = Console.ReadLine().ToLower();

        // Seperate user input by spaces
        string[] words = input.Split(' ');
        InventoryManager manager = new InventoryManager();

        // Use switch to send to different methods
        switch (words[0])
        {
            case "classNames":
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
                return;
            case "update":
                return;
            case "delete":
                return;
            case "exit":
                manager.Exit();
                return;
        }

    //TODO: When a command is completed without error, print the initial prompt with command list again
    }

    /// <summary>
    /// Print all class names of objects loaded in JSONStorage
    /// </summary>
    public void ClassNames()
    {
        foreach (string key in this.objects.Keys)
            Console.WriteLine(key.Split('.')[0]);
    }

    /// <summary>
    /// Print all objects
    /// </summary>
    public void All(string ClassName="null")
    {
        if (objects == null)
            return;

        // If no class name given, print out every object
        if (ClassName == null)
        {
            foreach (string key in objects.Keys)
            {
                string k = key.Split('.')[0];
                Console.WriteLine($"{k}: {objects[key]}");
                //TODO: Print out every object beginning with key
            }
        }

        // Incorrect class name given
        else if (classes.ContainsKey(ClassName) == false)
        {
            Console.WriteLine($"{ClassName} is not a valid object type");
            return;
        }

        // Correct class name
        else
        {
            // Filter for keys beginning in class name, print each
            foreach (string key in objects.Keys)
            {
                string k = key.Split('.')[0];
                if (k == ClassName)
                    Console.WriteLine($"{k}: {objects[key]}");
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
            Console.WriteLine($"{ClassName} is not a valid object type");
            return;
        }

        // Use storage.new(ClassName)
        /*if (ClassName == "baseclass")
            storage.New(new BaseClass());*/
        BaseClass obj = new BaseClass();
        if (ClassName == "baseclass")
            storage.New(obj);
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
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Update the properties of the given object
    /// </summary>
    public void Update(string ClassName, string id)
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Delete the given object from the JSONStorage
    /// </summary>
    public void Delete(string ClassName, string id)
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Quits the application
    /// </summary>
    public void Exit()
    {
        System.Environment.Exit(1);
    }
}
