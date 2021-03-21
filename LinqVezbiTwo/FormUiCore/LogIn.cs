using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUiCore
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello There";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello There again....";           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text can be cancelled";
            lblHello.ForeColor = Color.Red;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInFormTwo secondLogForm = new LogInFormTwo();
            secondLogForm.Show();
        }
    }
}
