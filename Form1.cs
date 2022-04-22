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
            string input = addInvtry.Text;
            inventory = input;
            return inventory;
        }
       
        public void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = "";
            string add;

            add = AddInventory(userInput);   
            
            inventoryListBox.Items.Add(add);  
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedInventory = (string)inventoryListBox.SelectedItem;

            inventoryListBox.Items.Remove(selectedInventory);

        }
    }
}
