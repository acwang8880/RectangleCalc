using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private double rectLength = Double.NaN;
        private double rectWidth = Double.NaN;

        private double area;
        private double perimeter;

        private bool calced = false;

        // informational messages
        private String infoInputLength = "Input a non-negative integer for the rectangle length.";
        private String infoInputWidth = "Input a non-negative integer for the rectangle width.";
        private String infoOK = "Confirm measurement.";
        private String infoUnits = "Select a unit of measurement.";

        public Form1()
        {
            InitializeComponent();
            this.Text = "RectangleCalc";
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.inputLength, infoInputLength);
            toolTip1.SetToolTip(this.inputWidth, infoInputWidth);
            toolTip1.SetToolTip(this.inputAreaUnit, infoUnits);
            toolTip1.SetToolTip(this.inputPerimeterUnit, infoUnits);
            toolTip1.SetToolTip(this.inputLengthUnit, infoUnits);
            toolTip1.SetToolTip(this.inputWidthUnit, infoUnits);
            toolTip1.SetToolTip(this.button1, infoOK);
            toolTip1.SetToolTip(this.button2, infoOK);

        }

        // Configure length
        private void button1_Click(object sender, EventArgs e)
        {
            errorLength.Visible = false;
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
                    errorLength.Text = "You did not input a valid unit of measurement";
                    errorLength.Visible = true;
                }
            }
            catch (Exception g)
            {
                String message = "";
                if (this.inputLength.Text.Equals(""))
                {
                    message += "You didn't input anything. ";
                }
                else if (isString(this.inputLength.Text))
                {
                    message += "Your input has a non-negative number. ";
                }
                message += "\nPlease input a valid non-negative number.";
                errorLength.Text = message;
                errorLength.Visible = true;
            }
        }
        // Configure width
        private void button2_Click(object sender, EventArgs e)
        {
            errorWidth.Visible = false;
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
                    errorWidth.Text = "You did not input a valid unit of measurement";
                    errorWidth.Visible = true;
                }
            }
            catch (Exception g)
            {
                String message = "";
                if (this.inputWidth.Text.Equals(""))
                {
                    message += "You didn't input anything. ";
                }
                else if (isString(this.inputWidth.Text))
                {
                    message += "Your input has a non-negative number. ";
                }
                message += "\nPlease input a valid non-negative number.";
                errorWidth.Text = message;
                errorWidth.Visible = true;
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

            /*
            if (outputArea.Text.Equals("NaN") || outputPerimeter.Text.Equals("Nan"))
            {
                //MessageBox.Show("You didn't input anything. \nPlease input a valid length and width");
            }
            */

            if (calced)
            {
                button3.Text = "Calculate! (Again!)";
            }
        }
    }
}
