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
            label1 = new Label();
            textBoxAddress = new TextBox();
            label2 = new Label();
            textBoxSSN = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // PositionNameBox
            // 
            PositionNameBox.Location = new Point(153, 80);
            PositionNameBox.Margin = new Padding(3, 4, 3, 4);
            PositionNameBox.Name = "PositionNameBox";
            PositionNameBox.Size = new Size(132, 23);
            PositionNameBox.TabIndex = 4;
            // 
            // PositionNameLabel
            // 
            PositionNameLabel.AutoSize = true;
            PositionNameLabel.Location = new Point(153, 58);
            PositionNameLabel.Name = "PositionNameLabel";
            PositionNameLabel.Size = new Size(57, 18);
            PositionNameLabel.TabIndex = 1;
            PositionNameLabel.Text = "Position";
            // 
            // PayLabel
            // 
            PayLabel.AutoSize = true;
            PayLabel.Location = new Point(15, 107);
            PayLabel.Name = "PayLabel";
            PayLabel.Size = new Size(90, 18);
            PayLabel.TabIndex = 3;
            PayLabel.Text = "Pay Per Hour";
            // 
            // PayBox
            // 
            PayBox.Location = new Point(15, 129);
            PayBox.Margin = new Padding(3, 4, 3, 4);
            PayBox.Name = "PayBox";
            PayBox.Size = new Size(133, 23);
            PayBox.TabIndex = 5;
            // 
            // EmployeeSubmitBtn
            // 
            EmployeeSubmitBtn.Location = new Point(202, 272);
            EmployeeSubmitBtn.Margin = new Padding(3, 4, 3, 4);
            EmployeeSubmitBtn.Name = "EmployeeSubmitBtn";
            EmployeeSubmitBtn.Size = new Size(86, 28);
            EmployeeSubmitBtn.TabIndex = 11;
            EmployeeSubmitBtn.Text = "Submit";
            EmployeeSubmitBtn.UseVisualStyleBackColor = true;
            EmployeeSubmitBtn.Click += SubmitEmployeeInfo;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(153, 9);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(73, 18);
            LastNameLabel.TabIndex = 20;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameBox
            // 
            LastNameBox.BackColor = SystemColors.Window;
            LastNameBox.Location = new Point(153, 31);
            LastNameBox.Margin = new Padding(3, 4, 3, 4);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(132, 23);
            LastNameBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(15, 9);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(75, 18);
            FirstNameLabel.TabIndex = 18;
            FirstNameLabel.Text = "First Name";
            // 
            // EmployeeIdLabel
            // 
            EmployeeIdLabel.AutoSize = true;
            EmployeeIdLabel.Location = new Point(12, 58);
            EmployeeIdLabel.Name = "EmployeeIdLabel";
            EmployeeIdLabel.Size = new Size(84, 18);
            EmployeeIdLabel.TabIndex = 17;
            EmployeeIdLabel.Text = "Employee Id";
            // 
            // FirstNameBox
            // 
            FirstNameBox.BackColor = SystemColors.Window;
            FirstNameBox.Location = new Point(15, 31);
            FirstNameBox.Margin = new Padding(3, 4, 3, 4);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(132, 23);
            FirstNameBox.TabIndex = 1;
            // 
            // EmployeeIdBox
            // 
            EmployeeIdBox.Location = new Point(15, 80);
            EmployeeIdBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeIdBox.Name = "EmployeeIdBox";
            EmployeeIdBox.Size = new Size(132, 23);
            EmployeeIdBox.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(15, 272);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 107);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 25;
            label1.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(152, 129);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(133, 23);
            textBoxAddress.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 206);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 27;
            label2.Text = "SSN";
            // 
            // textBoxSSN
            // 
            textBoxSSN.Location = new Point(16, 228);
            textBoxSSN.Margin = new Padding(3, 4, 3, 4);
            textBoxSSN.Name = "textBoxSSN";
            textBoxSSN.Size = new Size(132, 23);
            textBoxSSN.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 156);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(154, 178);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(131, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 156);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 31;
            label4.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(15, 178);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(132, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(299, 322);
            Controls.Add(label4);
            Controls.Add(textBoxPhone);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxSSN);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
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
        private Label label1;
        private TextBox textBoxAddress;
        private Label label2;
        private TextBox textBoxSSN;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxPhone;
    }
}