/*
Program Author: Tomas Nader
Assignment: CSC 317 Program 1 My Pizza App
Description: The program is a pizza ordering application that allows users to select various pizza sizes and additional items, 
automatically calculating the total cost of the order while dynamically updating the displayed total. 
Users can customize their orders with checkboxes for side items and view the total in real-time, enhancing the ordering experience.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pizza_Place_App
{
    public partial class mypizzaplace : Form
    { 

        // Declare the variables at the class level
        double total = 0.0;

        bool smallRadioAdd = false;
        bool mediumRadioAdd = false;
        bool largeRadioAdd = false;
        bool xlRadioAdd = false;

        string selectedOption = "";
        
        public mypizzaplace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void wings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                total += 12.00; // Price for wings
            }
            else
            {
                total -= 12.00; // Remove wings price if unchecked
            }
            UpdateTotalLabel();
        }

        private void BreadSticks_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                total += 6.99; // Price for breadsticks
            }
            else
            {
                total -= 6.99; // Remove breadsticks price if unchecked
            }
            UpdateTotalLabel();
        }

        private void Csalad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                total += 10.99; // Price for Caesar Salad
            }
            else
            {
                total -= 10.99; // Remove Caesar Salad price if unchecked
            }
            UpdateTotalLabel();
        }

        private void pasta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                total += 10.99; // Price for Oven-Baked pasta
            }
            else
            {
                total -= 10.99; // Remove Oven-Baked pasta price if unchecked
            }
            UpdateTotalLabel();

        }

        // Radio button for small pizza size
        private void smallRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !smallRadioAdd)
            {
                total += 7.00; 
                smallRadioAdd = true;
            }
            else if (!radioButton1.Checked && smallRadioAdd)
            {
                total -= 7.00; 
                smallRadioAdd = false;
            }
            UpdateTotalLabel();
        }

        // Radio button for medium pizza size
        private void mediumRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && !mediumRadioAdd)
            {
                total += 10.00; 
                mediumRadioAdd = true;
            }
            else if (!radioButton2.Checked && mediumRadioAdd)
            {
                total -= 10.00; 
                mediumRadioAdd = false;
            }
            UpdateTotalLabel();

        }

        // Radio button for large pizza size

        private void largeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && !largeRadioAdd)
            {
                total += 12.00; 
                largeRadioAdd = true;
            }
            else if (!radioButton3.Checked && largeRadioAdd)
            {
                total -= 12.00; 
                largeRadioAdd = false;
            }
            UpdateTotalLabel();

        }

        // Radio button for XL pizza size

        private void xlRadio_CheckedChanged(Object sender, EventArgs e)
        {
            if (radioButton4.Checked && !xlRadioAdd)
            {
                total += 14.00; 
                xlRadioAdd = true;
            }
            else if (!radioButton4.Checked && xlRadioAdd)
            {
                total -= 14.00; 
                xlRadioAdd = false;
            }
            UpdateTotalLabel();

        }

        // Order button
        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total cost for your order is: $" + total.ToString("F2"));
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // This method will update the total price label
        private void UpdateTotalLabel()
        {
            totalLabel.Text = " $" + total.ToString("F2");
        }
    }
}
