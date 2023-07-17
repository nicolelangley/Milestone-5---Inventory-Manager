using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Inventory_Project
{
        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }

        public class InventoryManager
        {
            private List<Item> inventory;

            public InventoryManager()
            {
                inventory = new List<Item>();
            }

            public void AddItem(Item item)
            {
                inventory.Add(item);
            }

            public void RemoveItem(Item item)
            {
                inventory.Remove(item);
            }

            public void RestockItem(Item item, int quantity)
            {
                item.Quantity += quantity;
            }

            public List<Item> SearchItems(string name, decimal price)
           {
                  var searchResults = inventory.Where(item =>
                  item.Name.Contains(name, StringComparison.OrdinalIgnoreCase) &&
                  item.Price <= price).ToList();

                return searchResults;
            }
        }
        public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
