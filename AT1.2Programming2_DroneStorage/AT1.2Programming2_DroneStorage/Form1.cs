using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Robert Jacobs 30018755
// Date: 19/10/2020
// Project: Drone application to record and store drone names and information.
// Description: The user uses the text box to input the Engine, range, Accessories and Price information into the application.
// after the input the user can click a button to add the information to an array for storage.

namespace AT1._2Programming2_DroneStorage
{
    public partial class MyDronesForm : Form
    {
        // Global variables
        private int empty = 0;
        private static int max = 10;
        private string[] droneArray = new string[max];
        Drone[] drone = new Drone[10];
        Drone droneinstance = new Drone();

        public MyDronesForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Method to add what is in the boxes into the array.
        public void addButton_Click(object sender, EventArgs e)
        {
           
            droneinstance.gsEngine = engineTextBox.Text;
            droneinstance.gsRange = rangeTextBox.Text;
            droneinstance.gsAccessories = accessoriesTextBox.Text;
            droneinstance.gsPrice = priceTextBox.Text;

            // Put current class instance into the current index of the array.
            drone[empty] = droneinstance;

            // Calls the method from the drone class that combines all the strings.
            droneDisplayBox.Items.Add(droneinstance.combinestring());

            // Clears textboxes.
            clear();
            //Moves up array.
            empty++;

        }

        // Method to clear text boxes.
        public void clear()
        {
            engineTextBox.Clear();
            rangeTextBox.Clear();
            accessoriesTextBox.Clear();
            priceTextBox.Clear();

        }

        private void droneDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxclicky();
        }

        public void boxclicky()
        {
            engineTextBox.Text = drone[droneDisplayBox.SelectedIndex].gsEngine;
            rangeTextBox.Text = drone[droneDisplayBox.SelectedIndex].gsRange;
            accessoriesTextBox.Text = drone[droneDisplayBox.SelectedIndex].gsAccessories;
            priceTextBox.Text = drone[droneDisplayBox.SelectedIndex].gsPrice;
            return;
        }
    }

}

