using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class InventoryManager
    {
        private List<InventoryItem> inventory;

        public InventoryManager()
        {
            inventory = new List<InventoryItem>();
        }

        public void AddItem(InventoryItem item)
        {
            inventory.Add(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            inventory.Remove(item);
        }

        public void UpdateItem(InventoryItem item)
        {
            // Find the item in the list and update its properties
            InventoryItem existingItem = inventory.Find(i => i.Name == item.Name);
            existingItem.Quantity = item.Quantity;
            existingItem.Price = item.Price;
        }

        public void PrintInventory()
        {
            foreach (InventoryItem item in inventory)
            {
                Console.WriteLine("{0}: {1} (Price: {2:C})", item.Name, item.Quantity, item.Price);
            }
        }
    }
}
