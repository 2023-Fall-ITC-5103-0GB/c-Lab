using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_C__Lab_Week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Call the method to populate the DataGridView on page load
            PopulateDataGridView();
        }


        private void PopulateDataGridView()
        {
            // Set up DataGridView columns
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Item", "Item");
            dataGridView.Columns.Add("Price", "Price");

            // Get items from InventoryDB
            List<InventoryItem> items = InventoryDB.GetItems();

            // Add items to DataGridView
            foreach (var item in items)
            {
                dataGridView.Rows.Add(item.ID, item.Item, item.Price);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            NewInventoryItem newItemForm = new NewInventoryItem();
            newItemForm.FormClosed += NewItemForm_FormClosed;
            this.Hide();
            newItemForm.Show();

        }

        private void NewItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            PopulateDataGridView();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            // Prompt for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Get the ID of the selected item
                int selectedItemId = (int)dataGridView.SelectedRows[0].Cells["ID"].Value;

                // Delete item from the database
                if (InventoryDB.DeleteItem(selectedItemId))
                {
                    MessageBox.Show("Item deleted successfully.");
                    PopulateDataGridView(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete item.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
