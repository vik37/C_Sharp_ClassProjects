
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            Hello_textBox1.Text = "Hello finaly... GOCE. Here is VIKTOR!!!";
            Hello_textBox1.BackColor = Color.FromArgb(82, 3, 160);
        }
    }
}
