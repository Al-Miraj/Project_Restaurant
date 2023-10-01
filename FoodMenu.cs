using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

static class FoodMenu
{
    public static List<MenuItem> MenuItems = GetAppropiateMenu();
    public static bool isDinner = true;

    public static List<MenuItem>? LoadData()
    {
        MenuItems.Clear();
        try
        {
            using StreamReader reader = new StreamReader("");
            string json = reader.ReadToEnd();
            var items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            return items;
        }
        catch (JsonReaderException)
        { return null; }
    }

    public static void Display()
    {
        MenuItems.Clear();
        var allItems = LoadData();
        Console.WriteLine();
        Console.WriteLine("=========================================================");
        for (int i = 0; i < MenuItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {MenuItems[i].Name}                      {MenuItems[i].Price}");
            Console.WriteLine($"{MenuItems[i].Details}");
            Console.WriteLine();
        }
        Console.WriteLine("=========================================================");
    }

    public static List<MenuItem> GetAppropiateMenu()
    {
        MenuItems.Clear();
        var allItems = LoadData();
        List<MenuItem> timeslotMenu = new List<MenuItem>();
        if (isDinner)
        {

        }
        else
        {

        }
        /*foreach (var item in allItems)
        {
            if (item.isDinner)
                timeslotMenu.Add(item);
            else

        }*/
            
        return timeslotMenu;
    }

    public static void Toggle() => isDinner = !isDinner;
}
