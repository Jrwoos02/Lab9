/* Chris Burgin
 * Cis 199-75
 *  Lab 9
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hold;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Used to get the current date from the date class. 
            var DateClass = new Date(); 
            dateLabel.Text = DateClass.CurrentDate();
        }

        private void updateDayButton_Click(object sender, EventArgs e)
        {
            
            var DateClass = new Date(); // Declares The Date Class Inside Our Current Class
            DateClass.Day(int.Parse(dayTextBox.Text)); // Calls the DateClass.Date and sends it the information entered in the day textbox
            dateLabel.Text = DateClass.ToString(); // Updates The Label
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            var DateClass = new Date();
            DateClass.Month(int.Parse(monthTextBox.Text));
            dateLabel.Text = DateClass.ToString();
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            var DateClass = new Date();
            DateClass.Year(int.Parse(yearTextBox.Text));
            dateLabel.Text = DateClass.ToString();
        }
    }
}
