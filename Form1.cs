
using System;
using System.Windows.Forms;

namespace Q4_ProgrammingLanguages_QA_InventorySystemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateInventoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtNewItem.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                InventoryManager.AddItem(newItem);
                txtNewItem.Clear();
                UpdateInventoryList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex >= 0)
            {
                InventoryManager.RemoveItem(lstInventory.SelectedIndex, out _);
                UpdateInventoryList();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void UpdateInventoryList()
        {
            lstInventory.Items.Clear();
            foreach (var item in InventoryManager.Inventory)
            {
                lstInventory.Items.Add(item);
            }
        }

        private void txtNewItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
