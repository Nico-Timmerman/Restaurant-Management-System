﻿using System;
using System.Windows.Forms;

namespace GUI_Module
{
    public partial class inventoryControl1 : UserControl
    {
        public inventoryControl1()
        {
            InitializeComponent1();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Click reorder button
        {
            // pop - label 12 - box 14
            // water - label 11 - box 15
            // salad - label 10 - box 16
            // fries - label 9 - box 17
            // chicken burger - label 8 - box 18
            // hamburger - label 7 - box 19

            int[] itemsToAdd = { 0, 0, 0, 0, 0, 0 }; // New array of 6 ints

            if (textBox14.Text == "")
                itemsToAdd[inventory.popIndex] = 0;
            else
            {
                itemsToAdd[inventory.popIndex] = int.Parse(textBox14.Text);
                textBox14.Text = string.Empty;
            }

            if (textBox15.Text == "")
                itemsToAdd[inventory.waterIndex] = 0;
            else
            {
                itemsToAdd[inventory.waterIndex] = int.Parse(textBox15.Text);
                textBox15.Text = string.Empty;
            }

            if (textBox16.Text == "")
                itemsToAdd[inventory.saladIndex] = 0;
            else
            {
                itemsToAdd[inventory.saladIndex] = int.Parse(textBox16.Text);
                textBox16.Text = string.Empty;
            }

            if (textBox17.Text == "")
                itemsToAdd[inventory.friesIndex] = 0;
            else
            {
                itemsToAdd[inventory.friesIndex] = int.Parse(textBox17.Text);
                textBox17.Text = string.Empty;
            }

            if (textBox18.Text == "")
                itemsToAdd[inventory.chickenBurgerIndex] = 0;
            else
            {
                itemsToAdd[inventory.chickenBurgerIndex] = int.Parse(textBox18.Text);
                textBox18.Text = string.Empty;
            }

            if (textBox19.Text == "")
                itemsToAdd[inventory.burgerIndex] = 0;
            else
            { 
                itemsToAdd[inventory.burgerIndex] = int.Parse(textBox19.Text);
                textBox19.Text = string.Empty;
            }

            inventoryControl1.inventory.addItemToStock(itemsToAdd);

            this.label12.Text = inventory.arrayOfItems[inventory.popIndex].getQuantity().ToString();
            this.label11.Text = inventory.arrayOfItems[inventory.waterIndex].getQuantity().ToString();
            this.label10.Text = inventory.arrayOfItems[inventory.saladIndex].getQuantity().ToString();
            this.label9.Text = inventory.arrayOfItems[inventory.friesIndex].getQuantity().ToString();
            this.label8.Text = inventory.arrayOfItems[inventory.chickenBurgerIndex].getQuantity().ToString();
            this.label7.Text = inventory.arrayOfItems[inventory.burgerIndex].getQuantity().ToString();

            Form formBackground = new Form();
            try
            {
                using (ReorderPopUp uu = new ReorderPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    //formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // inventoryControl1
            // 
            this.Name = "inventoryControl1";
            this.Load += new System.EventHandler(this.inventoryControl1_Load);
            this.ResumeLayout(false);

        }

        private void inventoryControl1_Load(object sender, EventArgs e)
        {

        }
    }
}