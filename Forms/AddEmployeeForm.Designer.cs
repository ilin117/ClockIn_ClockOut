namespace ClockIn_ClockOut
{
    partial class AddEmployeeForm
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
            PositionNameBox = new TextBox();
            PositionNameLabel = new Label();
            PayLabel = new Label();
            PayBox = new TextBox();
            EmployeeSubmitBtn = new Button();
            LastNameLabel = new Label();
            LastNameBox = new TextBox();
            FirstNameLabel = new Label();
            EmployeeIdLabel = new Label();
            FirstNameBox = new TextBox();
            EmployeeIdBox = new TextBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // PositionNameBox
            // 
            PositionNameBox.Location = new Point(15, 216);
            PositionNameBox.Margin = new Padding(3, 4, 3, 4);
            PositionNameBox.Name = "PositionNameBox";
            PositionNameBox.Size = new Size(209, 23);
            PositionNameBox.TabIndex = 4;
            // 
            // PositionNameLabel
            // 
            PositionNameLabel.AutoSize = true;
            PositionNameLabel.Location = new Point(15, 194);
            PositionNameLabel.Name = "PositionNameLabel";
            PositionNameLabel.Size = new Size(97, 18);
            PositionNameLabel.TabIndex = 1;
            PositionNameLabel.Text = "Position Name";
            // 
            // PayLabel
            // 
            PayLabel.AutoSize = true;
            PayLabel.Location = new Point(14, 254);
            PayLabel.Name = "PayLabel";
            PayLabel.Size = new Size(90, 18);
            PayLabel.TabIndex = 3;
            PayLabel.Text = "Pay Per Hour";
            // 
            // PayBox
            // 
            PayBox.Location = new Point(14, 276);
            PayBox.Margin = new Padding(3, 4, 3, 4);
            PayBox.Name = "PayBox";
            PayBox.Size = new Size(210, 23);
            PayBox.TabIndex = 5;
            // 
            // EmployeeSubmitBtn
            // 
            EmployeeSubmitBtn.Location = new Point(138, 307);
            EmployeeSubmitBtn.Margin = new Padding(3, 4, 3, 4);
            EmployeeSubmitBtn.Name = "EmployeeSubmitBtn";
            EmployeeSubmitBtn.Size = new Size(86, 28);
            EmployeeSubmitBtn.TabIndex = 23;
            EmployeeSubmitBtn.Text = "Submit";
            EmployeeSubmitBtn.UseVisualStyleBackColor = true;
            EmployeeSubmitBtn.Click += SubmitEmployeeInfo;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(15, 134);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(73, 18);
            LastNameLabel.TabIndex = 20;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameBox
            // 
            LastNameBox.BackColor = SystemColors.Window;
            LastNameBox.Location = new Point(15, 156);
            LastNameBox.Margin = new Padding(3, 4, 3, 4);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(209, 23);
            LastNameBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(15, 78);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(75, 18);
            FirstNameLabel.TabIndex = 18;
            FirstNameLabel.Text = "First Name";
            // 
            // EmployeeIdLabel
            // 
            EmployeeIdLabel.AutoSize = true;
            EmployeeIdLabel.Location = new Point(14, 25);
            EmployeeIdLabel.Name = "EmployeeIdLabel";
            EmployeeIdLabel.Size = new Size(84, 18);
            EmployeeIdLabel.TabIndex = 17;
            EmployeeIdLabel.Text = "Employee Id";
            // 
            // FirstNameBox
            // 
            FirstNameBox.BackColor = SystemColors.Window;
            FirstNameBox.Location = new Point(15, 100);
            FirstNameBox.Margin = new Padding(3, 4, 3, 4);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(209, 23);
            FirstNameBox.TabIndex = 2;
            // 
            // EmployeeIdBox
            // 
            EmployeeIdBox.Location = new Point(14, 47);
            EmployeeIdBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeIdBox.Name = "EmployeeIdBox";
            EmployeeIdBox.Size = new Size(210, 23);
            EmployeeIdBox.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(15, 307);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 24;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(239, 345);
            Controls.Add(BackBtn);
            Controls.Add(EmployeeSubmitBtn);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(EmployeeIdLabel);
            Controls.Add(FirstNameBox);
            Controls.Add(EmployeeIdBox);
            Controls.Add(PayLabel);
            Controls.Add(PayBox);
            Controls.Add(PositionNameLabel);
            Controls.Add(PositionNameBox);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PositionNameBox;
        private Label PositionNameLabel;
        private Label PayLabel;
        private TextBox PayBox;
        private Button EmployeeSubmitBtn;
        private Label LastNameLabel;
        private TextBox LastNameBox;
        private Label FirstNameLabel;
        private Label EmployeeIdLabel;
        private TextBox FirstNameBox;
        private TextBox EmployeeIdBox;
        private Button BackBtn;
    }
}