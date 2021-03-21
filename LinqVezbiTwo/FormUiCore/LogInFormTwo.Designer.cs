namespace FormUiCore
{
    partial class LogInFormTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.btnLogInButton2 = new System.Windows.Forms.Button();
            this.buttonReset2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(15, 61);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(104, 32);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User ID:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(15, 134);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(128, 32);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Password:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(167, 66);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(583, 27);
            this.userTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(167, 139);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(583, 27);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTextBox_KeyPress);
            // 
            // btnLogInButton2
            // 
            this.btnLogInButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogInButton2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogInButton2.Location = new System.Drawing.Point(167, 296);
            this.btnLogInButton2.Name = "btnLogInButton2";
            this.btnLogInButton2.Size = new System.Drawing.Size(143, 53);
            this.btnLogInButton2.TabIndex = 2;
            this.btnLogInButton2.Text = "Log In";
            this.btnLogInButton2.UseVisualStyleBackColor = true;
            this.btnLogInButton2.Click += new System.EventHandler(this.btnLogInButton2_Click);
            // 
            // buttonReset2
            // 
            this.buttonReset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset2.Location = new System.Drawing.Point(343, 296);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(139, 53);
            this.buttonReset2.TabIndex = 3;
            this.buttonReset2.Text = "Reset";
            this.buttonReset2.UseVisualStyleBackColor = true;
            this.buttonReset2.Click += new System.EventHandler(this.buttonReset2_Click);
            // 
            // LogInFormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset2);
            this.Controls.Add(this.btnLogInButton2);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "LogInFormTwo";
            this.Text = "LogInFormTwo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button btnLogInButton2;
        private System.Windows.Forms.Button buttonReset2;
    }
}