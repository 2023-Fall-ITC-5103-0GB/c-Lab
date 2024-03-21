using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp_C__Lab_Week10
{
    public partial class NewInventoryItem : Form
    {
        private static readonly string FilePath = @"C:\Users\siddh\OneDrive - Humber College\Documents\grocery_inventory_items.txt";
        private const char Delimiter = '|';

        public NewInventoryItem()
        {
            InitializeComponent();
        }

        private void NewInventoryItem_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                int itemNo = int.Parse(textBox_itemNO.Text);
                string desc = textBox_Desc.Text;
                decimal price = decimal.Parse(textBox_Price.Text);

                // Write new item to file
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine($"{itemNo}{Delimiter}{desc}{Delimiter}{price}");
                }

                MessageBox.Show("Item added successfully.");
                this.Close(); // Close the form after adding the item
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

    }
}
