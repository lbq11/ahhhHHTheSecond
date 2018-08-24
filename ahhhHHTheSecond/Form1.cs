using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahhhHHTheSecond
{
    public partial class Form1 : Form
    {
        int youClickedme;
        public Form1()
        {
            youClickedme = 1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "You clicked me "  + youClickedme++;
        }
    }
}
