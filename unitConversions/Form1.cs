/* Gurvir Uppal
 * Unit Conversions
 * Mr. T
 * ICS3U
 * May 20, 2021 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            //figure out what conversion we must do
            double choice = Convert.ToDouble(conversionChoiceInput.Text);

            //get number inputed to convert
            double number = Convert.ToDouble(valueInput.Text);

            if (choice == 1)
            {
                InchToCm(number);
            }
            else if (choice == 2)
            {
                FeetToCm(number);
            }
            else if (choice == 3)
            {
                YardsToMetres(number);
            }
            else if (choice == 4)
            {
                MilesToKm(number);
            }
            else
            {
                outputLabel.Text = "Please use 1-4 to select their corresponding conversions";
            }
        }
        public void InchToCm(double inches)
        {
            double cm = inches * 2.54;

            outputLabel.Text = $"{inches} inches is {cm.ToString("#.##")} cms";
        }             //method to convert inches to centimetres
        public void FeetToCm(double feet)
        {
            double cm = feet * 30.48;

            outputLabel.Text = $"{feet} feet is {cm.ToString("#.##")} cms";
        }               //method to convert Feet to centimetres
        public void YardsToMetres(double yards)
        {
            double metres = yards * 0.91;

            outputLabel.Text = $"{yards} yards is {metres.ToString("#.##")} metres";
        }         //method to convert yards to metres
        public void MilesToKm(double miles)
        {
            double km = miles * 1.609;

            outputLabel.Text = $"{miles} miles is {km.ToString("#.##")} km";
        }             //method to convert miles to kilomtres
    }
}
