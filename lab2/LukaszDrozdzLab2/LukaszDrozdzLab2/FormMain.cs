using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2
{
    public partial class FormMain : Form
    {
        //Shape container
        private Shape shape;
        public FormMain()
        {
            InitializeComponent();
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();
            comboBoxShape.Items.Add(square);
            comboBoxShape.Items.Add(circle);
            comboBoxShape.Items.Add(triangle);
        }


        private void buttonArea_Click(object sender, EventArgs e)
        {
            try { 
                textBoxArea.Text = shape.Area().ToString();
            }catch(NullReferenceException exception)
            {
                MessageBox.Show("Plz select a shape!", "Error");
            }
           
        }

        /// <summary>
        /// Selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = (Shape)comboBoxShape.SelectedItem;
        }

        private void buttonChangeSize_Click(object sender, EventArgs e)
        {
            if(shape is IResizeable)
            {
                shape.ChangeSize();
            }
        }

        private void buttonPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxPerimeter.Text = shape.Perimeter().ToString();
            }catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
