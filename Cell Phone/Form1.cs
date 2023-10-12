using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone
{
    public partial class Form1 : Form

    {
     List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void GetPhoneData(CellPhone phone)

        {
            // Temporary variable to hold the price.
            decimal price;

            // Get the phone's brand.
            phone.Brand = brandTextBox.Text;

            
            phone.Model = modelTextBox.Text;

            
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                
                MessageBox.Show("Invalid price");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CellPhone object.
            CellPhone myPhone = new CellPhone();

            
            GetPhoneData(myPhone);

            // Display the phone data.
            label7.Text = myPhone.Brand;
            label8.Text = myPhone.Model;
            label9.Text = myPhone.Price.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;
           
            // Display the selected item's price.

            MessageBox.Show(phoneList[index].Price.ToString("c"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
            CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

             phoneList.Add(myPhone);

            // Add an entry to the list box.
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();
            brandTextBox.Focus();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.Show();
            frm.label1.Text=textBox1.Text;
        }
    }
}
