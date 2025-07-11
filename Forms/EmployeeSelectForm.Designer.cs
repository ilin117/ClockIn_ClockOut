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
            RefreshBtn = new Button();
            GoToAdminBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 18;
            EmployeeListBox.Location = new Point(22, 94);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(503, 166);
            EmployeeListBox.TabIndex = 0;
            EmployeeListBox.DoubleClick += ListBoxItemDoubleClick;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(450, 266);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 26);
            RefreshBtn.TabIndex = 3;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // GoToAdminBtn
            // 
            GoToAdminBtn.Location = new Point(22, 24);
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
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(191, 17);
            label1.TabIndex = 5;
            label1.Text = "Find your name and double click";
            // 
            // EmployeeSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(547, 305);
            Controls.Add(label1);
            Controls.Add(GoToAdminBtn);
            Controls.Add(RefreshBtn);
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
        private Button RefreshBtn;
        private Button GoToAdminBtn;
        private Label label1;
    }
}