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
                double cm = InchToCm(number);
                outputLabel.Text = $"{number} inches is {cm.ToString("0.00")} cms";
            }
            else if (choice == 2)
            {
                double result = FeetToCm(number);
                outputLabel.Text = $"{number} feet is {result.ToString("0.00")} cms";
            }
            else if (choice == 3)
            {
                double metres = YardsToMetres(number);
                outputLabel.Text = $"{number} yards is {metres.ToString("0.00")} metres";
            }
            else if (choice == 4)
            {
                double km = MilesToKm(number);
                outputLabel.Text = $"{number} miles is {km.ToString("0.00")} km";
            }
            else
            {
                outputLabel.Text = "Please use 1-4 to select their corresponding conversions";
            }
        }
        /// <summary>
        /// Converts Inches to Centimetres
        /// </summary>
        /// <param name="inches"> The double value that is being converted to centimetres</param> 
        /// <returns> double returned of operations inches * 2.54</returns> 
        public double InchToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }
        /// <summary>
        /// Converts Feet to Centimetres
        /// </summary>
        /// <param name="feet"> The double value that is being converted to centimetres</param>
        /// <returns> double returned of operations feet * 30.48</returns>
        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }
        /// <summary>
        /// Converts Yards to Metres
        /// </summary>
        /// <param name="yards"> The double value that is being converted to metres</param>
        /// <returns> double returned of operations yards * 0.91</returns>
        public double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres;
        }
        /// <summary>
        /// Converts Miles to Kilometres
        /// </summary>
        /// <param name="miles"> The double value that is being converted to kilometres</param>
        /// <returns> double returned of operations miles * 1.609</returns>
        public double MilesToKm(double miles)
        {
            double km = miles * 1.609;
            return km;
        }
    }
}
