namespace ClockIn_ClockOut.Forms
{
    partial class EmployeeSelectForm
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
            EmployeeListBox = new ListBox();
            GoToAdminBtn = new Button();
            label1 = new Label();
            listBoxClockIn = new ListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 18;
            EmployeeListBox.Location = new Point(12, 112);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(306, 202);
            EmployeeListBox.TabIndex = 0;
            EmployeeListBox.DoubleClick += ListBoxItemDoubleClick;
            // 
            // GoToAdminBtn
            // 
            GoToAdminBtn.Location = new Point(549, 37);
            GoToAdminBtn.Name = "GoToAdminBtn";
            GoToAdminBtn.Size = new Size(102, 26);
            GoToAdminBtn.TabIndex = 4;
            GoToAdminBtn.Text = "Admin Panel";
            GoToAdminBtn.UseVisualStyleBackColor = true;
            GoToAdminBtn.Click += GotoAdminBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 10F);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(223, 21);
            label1.TabIndex = 5;
            label1.Text = "Find your name and double click";
            // 
            // listBoxClockIn
            // 
            listBoxClockIn.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxClockIn.FormattingEnabled = true;
            listBoxClockIn.ItemHeight = 18;
            listBoxClockIn.Location = new Point(345, 112);
            listBoxClockIn.Name = "listBoxClockIn";
            listBoxClockIn.Size = new Size(306, 202);
            listBoxClockIn.TabIndex = 6;
            listBoxClockIn.DoubleClick += ListBoxItemDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(345, 88);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 7;
            label2.Text = "Clocked in";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 8;
            label3.Text = "Not working";
            // 
            // EmployeeSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(663, 342);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxClockIn);
            Controls.Add(label1);
            Controls.Add(GoToAdminBtn);
            Controls.Add(EmployeeListBox);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EmployeeSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Selection";
            Load += EmployeeSelectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EmployeeListBox;
        private Button GoToAdminBtn;
        private Label label1;
        private ListBox listBoxClockIn;
        private Label label2;
        private Label label3;
    }
}