using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUiCore
{
    public partial class LogInFormTwo : Form
    {
        public LogInFormTwo()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogInButton2_Click(object sender, EventArgs e)
        {
            LogInFormsShowMessage();
        }
        private void LogInFormsShowMessage()
        {
            string id = userTextBox.Text;
            string pass = passTextBox.Text;

            if (id == "vik37" && pass == "123456")
            {
                this.Hide();
                Form1 firstLogForm = new Form1();
                firstLogForm.Show();
            }
            else
            {
                
                if(MessageBox.Show("User or Password is incorect....","Do you want to continue?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetMyForm();
                    //Process.Start("mspaint");
                }
                else
                {
                    this.Hide();
                }
            }
        }
        private void buttonReset2_Click(object sender, EventArgs e)
        {
            ResetMyForm();
        }
        private void ResetMyForm()
        {
            userTextBox.Text = "";
            passTextBox.Text = "";
        }

        private void passTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                LogInFormsShowMessage();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetMyForm();
            }
        }
    }
}
