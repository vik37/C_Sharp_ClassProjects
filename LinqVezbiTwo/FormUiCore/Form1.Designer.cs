namespace FormUiCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updatePersonButton_Click = new System.Windows.Forms.Button();
            this.initializeBindings = new System.Windows.Forms.ComboBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.yearExperiencePicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filteredList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NAmesOFBirth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearExperiencePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePersonButton_Click
            // 
            this.updatePersonButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePersonButton_Click.Location = new System.Drawing.Point(223, 121);
            this.updatePersonButton_Click.Name = "updatePersonButton_Click";
            this.updatePersonButton_Click.Size = new System.Drawing.Size(128, 56);
            this.updatePersonButton_Click.TabIndex = 0;
            this.updatePersonButton_Click.Text = "Update";
            this.toolTip1.SetToolTip(this.updatePersonButton_Click, "This button is for filtering list changes");
            this.updatePersonButton_Click.UseVisualStyleBackColor = true;
            this.updatePersonButton_Click.Click += new System.EventHandler(this.updatePersonButton_Click_Click);
            // 
            // initializeBindings
            // 
            this.initializeBindings.AllowDrop = true;
            this.initializeBindings.FormattingEnabled = true;
            this.initializeBindings.Location = new System.Drawing.Point(14, 135);
            this.initializeBindings.Name = "initializeBindings";
            this.initializeBindings.Size = new System.Drawing.Size(182, 28);
            this.initializeBindings.TabIndex = 1;
            this.initializeBindings.SelectedIndexChanged += new System.EventHandler(this.initializeBindings_SelectedIndexChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.domainUpDown1.AllowDrop = true;
            this.domainUpDown1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.domainUpDown1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.domainUpDown1.ForeColor = System.Drawing.Color.OldLace;
            this.domainUpDown1.Items.Add("January");
            this.domainUpDown1.Items.Add("February");
            this.domainUpDown1.Items.Add("March");
            this.domainUpDown1.Items.Add("April");
            this.domainUpDown1.Items.Add("Maj");
            this.domainUpDown1.Items.Add("Juni");
            this.domainUpDown1.Items.Add("July");
            this.domainUpDown1.Items.Add("August");
            this.domainUpDown1.Items.Add("September");
            this.domainUpDown1.Items.Add("October");
            this.domainUpDown1.Items.Add("November");
            this.domainUpDown1.Items.Add("December");
            this.domainUpDown1.Location = new System.Drawing.Point(14, 396);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(182, 34);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.TabStop = false;
            this.domainUpDown1.Text = "Month";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.domainUpDown1, "Show Month");
            this.domainUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // yearExperiencePicker
            // 
            this.yearExperiencePicker.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.yearExperiencePicker.Location = new System.Drawing.Point(47, 234);
            this.yearExperiencePicker.Name = "yearExperiencePicker";
            this.yearExperiencePicker.Size = new System.Drawing.Size(74, 27);
            this.yearExperiencePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIST OF STUDENTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Years Experience";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(379, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filtered List";
            // 
            // filteredList
            // 
            this.filteredList.BackColor = System.Drawing.SystemColors.InfoText;
            this.filteredList.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.filteredList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filteredList.FormattingEnabled = true;
            this.filteredList.ItemHeight = 22;
            this.filteredList.Location = new System.Drawing.Point(379, 184);
            this.filteredList.Name = "filteredList";
            this.filteredList.Size = new System.Drawing.Size(191, 180);
            this.filteredList.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(2, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 61);
            this.button1.TabIndex = 30;
            this.button1.Text = "Show Month";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(202, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 224);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NAmesOFBirth
            // 
            this.NAmesOFBirth.AutoSize = true;
            this.NAmesOFBirth.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NAmesOFBirth.Location = new System.Drawing.Point(379, 394);
            this.NAmesOFBirth.Name = "NAmesOFBirth";
            this.NAmesOFBirth.Size = new System.Drawing.Size(210, 32);
            this.NAmesOFBirth.TabIndex = 32;
            this.NAmesOFBirth.Text = "<- BIRTH DAY";
            this.NAmesOFBirth.Click += new System.EventHandler(this.NAmesOFBirth_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 435);
            this.Controls.Add(this.NAmesOFBirth);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filteredList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearExperiencePicker);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.initializeBindings);
            this.Controls.Add(this.updatePersonButton_Click);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.yearExperiencePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatePersonButton_Click;
        private System.Windows.Forms.ComboBox initializeBindings;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.NumericUpDown yearExperiencePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox filteredList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label NAmesOFBirth;
    }
}

