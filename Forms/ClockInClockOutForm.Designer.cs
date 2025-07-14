namespace ClockIn_ClockOut
{
    partial class ClockInClockOutForm
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
            button1 = new Button();
            button2 = new Button();
            ClockInLabel = new Label();
            ClockOutLabel = new Label();
            TipsLabel = new Label();
            TipsBox = new TextBox();
            NameLabel = new Label();
            HeadingLabel = new Label();
            EmployeeIdLabel = new Label();
            PositionLabel = new Label();
            PayLabel = new Label();
            EmployeeId = new Label();
            EmployeeFullName = new Label();
            EmployeePosition = new Label();
            EmployeePay = new Label();
            ClockInTime = new Label();
            ClockOutTime = new Label();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 225);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 0;
            button1.Text = "Clock In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClockInButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(14, 328);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(79, 28);
            button2.TabIndex = 5;
            button2.Text = "Clock Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClockOutButtonClick;
            // 
            // ClockInLabel
            // 
            ClockInLabel.AutoSize = true;
            ClockInLabel.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClockInLabel.Location = new Point(12, 203);
            ClockInLabel.Name = "ClockInLabel";
            ClockInLabel.Size = new Size(95, 18);
            ClockInLabel.TabIndex = 6;
            ClockInLabel.Text = "Clock In Time:";
            // 
            // ClockOutLabel
            // 
            ClockOutLabel.AutoSize = true;
            ClockOutLabel.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClockOutLabel.Location = new Point(14, 304);
            ClockOutLabel.Name = "ClockOutLabel";
            ClockOutLabel.Size = new Size(106, 18);
            ClockOutLabel.TabIndex = 7;
            ClockOutLabel.Text = "Clock Out Time:";
            // 
            // TipsLabel
            // 
            TipsLabel.AutoSize = true;
            TipsLabel.Location = new Point(39, 257);
            TipsLabel.Name = "TipsLabel";
            TipsLabel.Size = new Size(34, 18);
            TipsLabel.TabIndex = 11;
            TipsLabel.Text = "Tips";
            // 
            // TipsBox
            // 
            TipsBox.Location = new Point(16, 278);
            TipsBox.Margin = new Padding(3, 4, 3, 4);
            TipsBox.Name = "TipsBox";
            TipsBox.Size = new Size(79, 23);
            TipsBox.TabIndex = 12;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(26, 90);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(74, 18);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Full Name:";
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeadingLabel.Location = new Point(14, 11);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(218, 30);
            HeadingLabel.TabIndex = 14;
            HeadingLabel.Text = "Employee Information";
            // 
            // EmployeeIdLabel
            // 
            EmployeeIdLabel.AutoSize = true;
            EmployeeIdLabel.Location = new Point(14, 60);
            EmployeeIdLabel.Name = "EmployeeIdLabel";
            EmployeeIdLabel.Size = new Size(88, 18);
            EmployeeIdLabel.TabIndex = 15;
            EmployeeIdLabel.Text = "Employee Id:";
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(39, 119);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(61, 18);
            PositionLabel.TabIndex = 16;
            PositionLabel.Text = "Position:";
            // 
            // PayLabel
            // 
            PayLabel.AutoSize = true;
            PayLabel.Location = new Point(9, 149);
            PayLabel.Name = "PayLabel";
            PayLabel.Size = new Size(94, 18);
            PayLabel.TabIndex = 17;
            PayLabel.Text = "Pay Per Hour:";
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSize = true;
            EmployeeId.Location = new Point(106, 60);
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Size = new Size(42, 18);
            EmployeeId.TabIndex = 18;
            EmployeeId.Text = "label1";
            // 
            // EmployeeFullName
            // 
            EmployeeFullName.AutoSize = true;
            EmployeeFullName.Location = new Point(106, 90);
            EmployeeFullName.Name = "EmployeeFullName";
            EmployeeFullName.Size = new Size(45, 18);
            EmployeeFullName.TabIndex = 19;
            EmployeeFullName.Text = "label2";
            // 
            // EmployeePosition
            // 
            EmployeePosition.AutoSize = true;
            EmployeePosition.Location = new Point(106, 119);
            EmployeePosition.Name = "EmployeePosition";
            EmployeePosition.Size = new Size(45, 18);
            EmployeePosition.TabIndex = 20;
            EmployeePosition.Text = "label3";
            // 
            // EmployeePay
            // 
            EmployeePay.AutoSize = true;
            EmployeePay.Location = new Point(106, 149);
            EmployeePay.Name = "EmployeePay";
            EmployeePay.Size = new Size(45, 18);
            EmployeePay.TabIndex = 21;
            EmployeePay.Text = "label4";
            // 
            // ClockInTime
            // 
            ClockInTime.AutoSize = true;
            ClockInTime.Location = new Point(135, 203);
            ClockInTime.Name = "ClockInTime";
            ClockInTime.Size = new Size(0, 18);
            ClockInTime.TabIndex = 23;
            // 
            // ClockOutTime
            // 
            ClockOutTime.AutoSize = true;
            ClockOutTime.Location = new Point(135, 304);
            ClockOutTime.Name = "ClockOutTime";
            ClockOutTime.Size = new Size(0, 18);
            ClockOutTime.TabIndex = 24;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(9, 454);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 25;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // EmployeeInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(355, 492);
            Controls.Add(BackBtn);
            Controls.Add(ClockOutTime);
            Controls.Add(ClockInTime);
            Controls.Add(EmployeePay);
            Controls.Add(EmployeePosition);
            Controls.Add(EmployeeFullName);
            Controls.Add(EmployeeId);
            Controls.Add(PayLabel);
            Controls.Add(PositionLabel);
            Controls.Add(EmployeeIdLabel);
            Controls.Add(HeadingLabel);
            Controls.Add(NameLabel);
            Controls.Add(TipsBox);
            Controls.Add(TipsLabel);
            Controls.Add(ClockOutLabel);
            Controls.Add(ClockInLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Information & Clock in-Clock out";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label ClockInLabel;
        private Label ClockOutLabel;
        private Label TipsLabel;
        private TextBox TipsBox;
        private Label NameLabel;
        private Label HeadingLabel;
        private Label EmployeeIdLabel;
        private Label PositionLabel;
        private Label PayLabel;
        private Label EmployeeId;
        private Label EmployeeFullName;
        private Label EmployeePosition;
        private Label EmployeePay;
        private Label ClockInTime;
        private Label ClockOutTime;
        private Button BackBtn;
    }
}
