// InventoryDB.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp_C__Lab_Week10
{
    public static class InventoryDB
    {
        private static readonly string FilePath = @"C:\Users\siddh\OneDrive - Humber College\Documents\grocery_inventory_items.txt";
        private const char Delimiter = '|';

        public static List<InventoryItem> GetItems()
        {
            var items = new List<InventoryItem>();

            try
            {
                using (var reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(Delimiter);
                        if (parts.Length == 3)
                        {
                            var item = new InventoryItem
                            {
                                ID = int.Parse(parts[0]),
                                Item = parts[1],
                                Price = decimal.Parse(parts[2])
                            };
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }

            return items;
        }

        public static bool DeleteItem(int itemId)
        {
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(FilePath);

                // Rewrite the file excluding the line with the selected item ID
                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    foreach (string line in lines)
                    {
                        var parts = line.Split(Delimiter);
                        if (parts.Length == 3 && int.Parse(parts[0]) != itemId)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}");
                return false;
            }
        }

    }
}
