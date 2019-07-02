using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab1
{
    public partial class FormMain : Form
    {
        //Some random counter
        int easterEggCounter;
        //Dont really know what to say here :<
        int daCounter;

        //button movement direction
        int direction = 1;

        //New window
        FormAbout formAbout;

        public FormMain()
        {
            InitializeComponent();
            easterEggCounter = 0;
            daCounter = 0;
        }
        /// <summary>
        /// Name button event listener. Closes main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Closes the window
            this.Close();
        }
        /// <summary>
        /// buttonClose action listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            //A little surprise
            if (easterEggCounter >= 5)
            {
                //Display the message
                labelName.Text = "GO AWAY!!!!!!11!111ONEONEONE";
                buttonChange.BackColor = Color.Red;
            }
            else
            {
                //Changes the text of labelName and the color of buttonClose
                labelName.Text = "Nothing offensive to be found here. Go away.";

                //Switches the color of buttonClose to red or blue
                if (buttonClose.BackColor == Color.Red)
                {
                    buttonClose.BackColor = Color.Blue;
                }
                else
                {
                    buttonClose.BackColor = Color.Red;
                }
                easterEggCounter++;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int textBoxInteger=0;
            //Parse an int from textBoxName and add it to the variable
            try
            {
                textBoxInteger = Int32.Parse(textBoxNumber.Text);
            }
            catch
            {
                labelName.Text = "Plz enter an INTEGER!!!!";
            }

            //Increment the counter
            daCounter += textBoxInteger;
          

            //Display a message
            if (daCounter > 5)
            {
                MessageBox.Show("DUDE CHILL. I DONT WANT THEM BIG NUMBERZ :<");
                daCounter = 0;
                MessageBox.Show(daCounter.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Incrementing the counter
            daCounter++;
            textBoxNumber.Text = daCounter.ToString();
            if (daCounter >= 10)
            {
                if(daCounter%10==0)
                    MessageBox.Show("Yay you've hit another 10!. Im moving that button away from ya...");
                if (buttonStart.Location.X > 200)
                    direction *= -1;
                if (buttonStart.Location.X < 10)
                    direction *= -1;
                buttonStart.Location = new Point(buttonStart.Location.X + 10 * direction, buttonStart.Location.Y);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerCounter.Start();
        }

        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                formAbout = new FormAbout();
                formAbout.Show();
            }
        }
    }
}
