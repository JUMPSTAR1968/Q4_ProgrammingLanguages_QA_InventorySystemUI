
using System.Collections.Generic;

namespace Q4_ProgrammingLanguages_QA_InventorySystemUI
{
    public static class InventoryManager
    {
        public static List<string> Inventory = new List<string>();

        public static void AddItem(string item)
        {
            Inventory.Add(item);
        }

        public static bool RemoveItem(int index, out string removedItem)
        {
            if (index >= 0 && index < Inventory.Count)
            {
                removedItem = Inventory[index];
                Inventory.RemoveAt(index);
                return true;
            }
            removedItem = null;
            return false;
        }
    }
}
