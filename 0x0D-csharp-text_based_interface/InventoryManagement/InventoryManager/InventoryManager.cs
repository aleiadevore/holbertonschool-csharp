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

        // Seperate user input by spaces
        string[] words = input.Split(' ');

        // Use switch to send to different methods
        switch (words[0])
        {
            case "ClassNames":
                return;
            case "All":
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
    }
}
