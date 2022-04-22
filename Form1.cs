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
    // create inventory class
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        // create AddInventory() method to get the new inventory input and add to the list
        public string AddInventory(string inventory)
        {
            string input = addInvtry.Text;
            inventory = input;
            return inventory;
        }
       
        // create button that will add the AddInventory() method, and the button will add the inventory to the list.
        public void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = "";
            string add;

            add = AddInventory(userInput);   
            
            inventoryListBox.Items.Add(add);  
        }

        // this button will allow the user to delete an inventory item of the list. 
        public void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedInventory = (string)inventoryListBox.SelectedItem;

            inventoryListBox.Items.Remove(selectedInventory);

        }
    }
}
