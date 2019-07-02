using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace LukaszDrozdzLab2
    {
        /// <summary>
        /// statyczna klasa Prompt służąca do wyświetlenia 
        /// input field (textboxa) dla użytkownika
        /// zwraca wartosć wprowadzoną w pole
        /// </summary>
        public static class Prompt
        {
            public static string ShowDialog(string caption, string text)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = caption;

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.ShowDialog();

                return inputBox.Text;
            }
        }
    }


