using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileStoneProject
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        public string AddInventory(string inventory)
        {
            return inventory;
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = addInvtry.Text;
            string add;

            add = AddInventory(userInput);   
            
            inventoryListBox.Items.Add(add);  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedInventory;

            selectedInventory = (string)inventoryListBox.SelectedItem;
            
            inventoryListBox.Items.Remove(selectedInventory);
            
        }
    }
}
