namespace ClockIn_ClockOut.Forms
{
    partial class EditEmployeeForm
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
            updateBtn = new Button();
            removeBtn = new Button();
            backBtn = new Button();
            label4 = new Label();
            textBoxPhone = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxSSN = new TextBox();
            label1 = new Label();
            textBoxAddress = new TextBox();
            LastNameLabel = new Label();
            textBoxLastName = new TextBox();
            FirstNameLabel = new Label();
            EmployeeIdLabel = new Label();
            textBoxFirstName = new TextBox();
            textBoxEmployeeId = new TextBox();
            PayLabel = new Label();
            textBoxPay = new TextBox();
            PositionNameLabel = new Label();
            textBoxPosition = new TextBox();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(106, 316);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(86, 28);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(242, 316);
            removeBtn.Margin = new Padding(3, 4, 3, 4);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(86, 28);
            removeBtn.TabIndex = 12;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(14, 316);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(86, 28);
            backBtn.TabIndex = 10;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 49;
            label4.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(14, 184);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(132, 23);
            textBoxPhone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 162);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 47;
            label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(153, 184);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(131, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 212);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 45;
            label2.Text = "SSN";
            // 
            // textBoxSSN
            // 
            textBoxSSN.Location = new Point(15, 234);
            textBoxSSN.Margin = new Padding(3, 4, 3, 4);
            textBoxSSN.Name = "textBoxSSN";
            textBoxSSN.Size = new Size(132, 23);
            textBoxSSN.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 113);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 43;
            label1.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(151, 135);
            textBoxAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(133, 23);
            textBoxAddress.TabIndex = 6;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(152, 15);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(73, 18);
            LastNameLabel.TabIndex = 42;
            LastNameLabel.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = SystemColors.Window;
            textBoxLastName.Location = new Point(152, 37);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(132, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(14, 15);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(75, 18);
            FirstNameLabel.TabIndex = 41;
            FirstNameLabel.Text = "First Name";
            // 
            // EmployeeIdLabel
            // 
            EmployeeIdLabel.AutoSize = true;
            EmployeeIdLabel.Location = new Point(11, 64);
            EmployeeIdLabel.Name = "EmployeeIdLabel";
            EmployeeIdLabel.Size = new Size(84, 18);
            EmployeeIdLabel.TabIndex = 40;
            EmployeeIdLabel.Text = "Employee Id";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = SystemColors.Window;
            textBoxFirstName.Location = new Point(14, 37);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(132, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(14, 86);
            textBoxEmployeeId.Margin = new Padding(3, 4, 3, 4);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(132, 23);
            textBoxEmployeeId.TabIndex = 3;
            // 
            // PayLabel
            // 
            PayLabel.AutoSize = true;
            PayLabel.Location = new Point(14, 113);
            PayLabel.Name = "PayLabel";
            PayLabel.Size = new Size(90, 18);
            PayLabel.TabIndex = 36;
            PayLabel.Text = "Pay Per Hour";
            // 
            // textBoxPay
            // 
            textBoxPay.Location = new Point(14, 135);
            textBoxPay.Margin = new Padding(3, 4, 3, 4);
            textBoxPay.Name = "textBoxPay";
            textBoxPay.Size = new Size(133, 23);
            textBoxPay.TabIndex = 5;
            // 
            // PositionNameLabel
            // 
            PositionNameLabel.AutoSize = true;
            PositionNameLabel.Location = new Point(152, 64);
            PositionNameLabel.Name = "PositionNameLabel";
            PositionNameLabel.Size = new Size(57, 18);
            PositionNameLabel.TabIndex = 34;
            PositionNameLabel.Text = "Position";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(152, 86);
            textBoxPosition.Margin = new Padding(3, 4, 3, 4);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(132, 23);
            textBoxPosition.TabIndex = 4;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(334, 352);
            Controls.Add(label4);
            Controls.Add(textBoxPhone);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxSSN);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            Controls.Add(LastNameLabel);
            Controls.Add(textBoxLastName);
            Controls.Add(FirstNameLabel);
            Controls.Add(EmployeeIdLabel);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(PayLabel);
            Controls.Add(textBoxPay);
            Controls.Add(PositionNameLabel);
            Controls.Add(textBoxPosition);
            Controls.Add(backBtn);
            Controls.Add(removeBtn);
            Controls.Add(updateBtn);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Employee";
            Load += EditEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateBtn;
        private Button removeBtn;
        private Button backBtn;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxSSN;
        private Label label1;
        private TextBox textBoxAddress;
        private Label LastNameLabel;
        private TextBox textBoxLastName;
        private Label FirstNameLabel;
        private Label EmployeeIdLabel;
        private TextBox textBoxFirstName;
        private TextBox textBoxEmployeeId;
        private Label PayLabel;
        private TextBox textBoxPay;
        private Label PositionNameLabel;
        private TextBox textBoxPosition;
    }
}