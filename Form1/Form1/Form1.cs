using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            theButton.Text = "I've Been Clicked!";
            theButton.BackColor = Color.LavenderBlush;
            this.Location = new Point(this.Location.X + 25, this.Location.Y + 25);
        }
    }
}
