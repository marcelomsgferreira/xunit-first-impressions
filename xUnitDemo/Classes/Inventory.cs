using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDemo.Classes
{
    public class Inventory
    {
        private readonly List<string> _items;
        public int Capacity { get; }

        public Inventory(int capacity)
        {
            if (capacity <= 0) throw new ArgumentException("Capacity must be greater than zero.");
            Capacity = capacity;
            _items = new List<string>();
        }

        public bool AddItem(string item)
        {
            if (string.IsNullOrEmpty(item)) throw new ArgumentException("Item cannot be null or empty.");
            if (_items.Count >= Capacity) return false;

            _items.Add(item);
            return true;
        }

        public bool RemoveItem(string item)
        {
            return _items.Remove(item);
        }

        public List<string> GetItems() => new List<string>(_items);

        public bool IsFull => _items.Count >= Capacity;
    }
}
