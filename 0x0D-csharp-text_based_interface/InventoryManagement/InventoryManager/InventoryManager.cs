using System;
using InventoryLibrary;
using System.Collections.Generic;

class InventoryManager
{
    static void Main(string[] args)
    {
        JSONStorage StoreManager = new JSONStorage();

        StoreManager.Load();

        //TODO: Print an initial prompt with the available commands and their usage.

        string input = Console.ReadLine();

        //TODO: remove casing (should not be case sensitive)

        // Seperate user input by spaces
        string[] words = input.Split(' ');

        // Use switch to send to different methods
        switch (words[0])
        {
            case "ClassNames":
                return;
            case "All":
                // TODO: Handle if classname given in words[1]
                return;
            case "Create":
                return;
            case "Show":
                return;
            case "Update":
                return;
            case "Delete":
                return;
            case "Exit":
                return;
        }

        //TODO: When a command is completed without error, print the initial prompt with command list again
    }

    /// <summary>
    /// Print all class names of objects loaded in JSONStorage
    /// </summary>
    public void ClassNames()
    {

    }

    /// <summary>
    /// Print all objects
    /// </summary>
    public void All()
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
    }

    /// <summary>
    /// Create and save a new object of ClassName
    /// </summary>
    public void Create()
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
    }

    /// <summary>
    /// Print the string representation of the requested object
    /// </summary>
    public void Show()
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Update the properties of the given object
    /// </summary>
    public void Update()
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Delete the given object from the JSONStorage
    /// </summary>
    public void Delete()
    {
        //TODO: If ClassName is invalid, print: <ClassName> is not a valid object type
        //TODO: If id is invalid, print: Object<id> could not be found
    }

    /// <summary>
    /// Quits the application
    /// </summary>
    public void Exit()
    {

    }
}
