using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        double rectLength = Double.NaN;
        double rectWidth = Double.NaN;

        double area;
        double perimeter;

        bool calced = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = "RectangleCalc";
        }

        // Configure length
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rectLength = Double.Parse(this.inputLength.Text);

                if (rectLength < 0)
                {
                    rectLength = Double.NaN;
                    throw new InvalidCastException();
                }

                else if (inputLengthUnit.Text.Equals("km"))
                {
                    rectLength *= 1000;
                }
                else if (inputLengthUnit.Text.Equals("m"))
                {
                    // shouldnt do anything
                    rectLength *= 1;
                }
                else if (inputLengthUnit.Text.Equals("cm"))
                {
                    rectLength /= 100;
                }
                else if (inputLengthUnit.Text.Equals("mm"))
                {
                    rectLength /= 1000;
                }
                else
                {
                    MessageBox.Show("You did not input a valid unit of measurement");
                }
            }
            catch (Exception g)
            {
                String message = "";
                if (this.inputLength.Text.Equals(""))
                {
                    message += "You didn't input anything.\n";
                }
                else if (isString(this.inputLength.Text))
                {
                    message += "Your input has a non-negative number\n";
                }
                message += "Please input a valid non-negative number";
                MessageBox.Show(
                    message + "\n" + g.Message
                    );
            }
        }
        // Configure width
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rectWidth = Double.Parse(this.inputWidth.Text);

                if (rectWidth < 0)
                {
                    rectWidth = Double.NaN;
                    throw new InvalidCastException();
                }

                else if (inputWidthUnit.Text.Equals("km"))
                {
                    rectWidth *= 1000;
                }
                else if (inputWidthUnit.Text.Equals("m"))
                {
                    // shouldnt do anything
                    rectWidth *= 1;
                }
                else if (inputWidthUnit.Text.Equals("cm"))
                {
                    rectWidth /= 100;
                } 
                else if (inputWidthUnit.Text.Equals("mm"))
                {
                    rectWidth /= 1000;
                }
                else
                {
                    MessageBox.Show("You did not input a valid unit of measurement");
                }
            }
            catch (Exception g)
            {
                String message = "";
                if (this.inputWidth.Text.Equals(""))
                {
                    message += "You didn't input anything.\n";
                }
                else if (isString(this.inputWidth.Text))
                {
                    message += "Your input has a non-negative number\n";
                }
                message += "Please input a valid non-negative number";
                MessageBox.Show(
                    message + "\n" + g.Message
                    );
            }
        }

        private bool isString(string text)
        {
            return text.All(Char.IsLetter);
        }

        private double calcArea(double a, double b)
        {
            return a * b;
        }

        private double calcPerimeter(double a, double b)
        {
            return (2 * a) + (2 * b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calced = true;
            area = calcArea(rectLength, rectWidth);
            perimeter = calcPerimeter(rectLength, rectWidth);
            /*
            // Uncomment to Debug!
            MessageBox.Show(
                "length: " + rectLength + "\n" +
                "width: " + rectWidth + "\n" +
                "area: " + area + "\n" +
                "perimeter: " + perimeter);
            */

            //area units
            if (inputAreaUnit.Text.Equals("km"))
            {
                area /= 1000;
            }
            else if (inputAreaUnit.Text.Equals("m"))
            {
                // shouldnt do anything
                area *= 1;
            }
            else if (inputAreaUnit.Text.Equals("cm"))
            {
                area *= 100;
            }
            else if (inputAreaUnit.Text.Equals("mm"))
            {
                area *= 1000;
            }
            else
            {
                MessageBox.Show("You did not input a valid unit of measurement");
            }

            //perimeter units
            if (inputPerimeterUnit.Text.Equals("km"))
            {
                perimeter /= 1000;
            }
            else if (inputPerimeterUnit.Text.Equals("m"))
            {
                // shouldnt do anything
                perimeter *= 1;
            }
            else if (inputPerimeterUnit.Text.Equals("cm"))
            {
                perimeter *= 100;
            }
            else if (inputPerimeterUnit.Text.Equals("mm"))
            {
                perimeter *= 1000;
            }
            else
            {
                MessageBox.Show("You did not input a valid unit of measurement");
            }

            outputArea.Text = area.ToString();
            outputPerimeter.Text = perimeter.ToString();

            if (outputArea.Text.Equals("NaN") || outputPerimeter.Text.Equals("Nan"))
            {
                MessageBox.Show("You didn't input anything. \nPlease input a valid length and width");
            }

            if (calced)
            {
                button3.Text = "Calculate! (Again!)";
            }
        }
    }
}
