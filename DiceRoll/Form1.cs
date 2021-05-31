using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        int sides;
        DiceDriver drive;
        int numRolls;

        public Form1()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(numSides.Text))
            {
                if(int.TryParse(numSides.Text, out sides))
                {
                    sides = int.Parse(numSides.Text);
                    //make sure number entered is between 1 and 20
                    if (sides >= 1 && sides <= 20)
                    {
                        //create driver object, pass sides
                        drive = new DiceDriver(sides);

                        //set visibility correctly for labels and buttons
                        numSides.Visible = false;
                        setButton.Visible = false;
                        rollButton.Visible = true;
                        sidesText.Text = "Sides set to " + sides;
                    }
                    else
                    {
                        sidesText.Text = "Please enter a number between 1 and 20";
                    }
                }

                else
                {
                    sidesText.Text = "Please enter a number";
                }

            }
            else
            {

            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //keep track of the number of rolls
            numRolls++;

            //start driver
            Boolean driver = drive.drive();

            //check if values are both 1
            if (driver == false)
            {
                //set labels to face values
                dice1Label.Text = drive.getFace1().ToString();
                dice2Label.Text = drive.getFace2().ToString();
            }
            else
            {
                //set values, remove roll button, show how many rolls
                dice1Label.Text = drive.getFace1().ToString();
                dice2Label.Text = drive.getFace2().ToString();
                rollButton.Visible = false;
                snakeEyes.Text = "It took " + numRolls + " rolls to get snake eyes!";
                snakeEyes.Visible = true;

            }
            
        }
    }
}
