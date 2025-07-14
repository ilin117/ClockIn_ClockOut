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
            buttonClockIn = new Button();
            buttonClockOut = new Button();
            ClockInLabel = new Label();
            ClockOutLabel = new Label();
            TipsLabel = new Label();
            TipsBox = new TextBox();
            NameLabel = new Label();
            HeadingLabel = new Label();
            EmployeeIdLabel = new Label();
            PositionLabel = new Label();
            EmployeeId = new Label();
            EmployeeFullName = new Label();
            EmployeePosition = new Label();
            ClockInTime = new Label();
            ClockOutTime = new Label();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // buttonClockIn
            // 
            buttonClockIn.Location = new Point(12, 182);
            buttonClockIn.Margin = new Padding(3, 4, 3, 4);
            buttonClockIn.Name = "buttonClockIn";
            buttonClockIn.Size = new Size(79, 28);
            buttonClockIn.TabIndex = 0;
            buttonClockIn.Text = "Clock In";
            buttonClockIn.UseVisualStyleBackColor = true;
            buttonClockIn.Click += ClockInButtonClick;
            // 
            // buttonClockOut
            // 
            buttonClockOut.Location = new Point(12, 308);
            buttonClockOut.Margin = new Padding(3, 4, 3, 4);
            buttonClockOut.Name = "buttonClockOut";
            buttonClockOut.Size = new Size(79, 28);
            buttonClockOut.TabIndex = 5;
            buttonClockOut.Text = "Clock Out";
            buttonClockOut.UseVisualStyleBackColor = true;
            buttonClockOut.Click += ClockOutButtonClick;
            // 
            // ClockInLabel
            // 
            ClockInLabel.AutoSize = true;
            ClockInLabel.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClockInLabel.Location = new Point(10, 160);
            ClockInLabel.Name = "ClockInLabel";
            ClockInLabel.Size = new Size(95, 18);
            ClockInLabel.TabIndex = 6;
            ClockInLabel.Text = "Clock In Time:";
            // 
            // ClockOutLabel
            // 
            ClockOutLabel.AutoSize = true;
            ClockOutLabel.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClockOutLabel.Location = new Point(10, 286);
            ClockOutLabel.Name = "ClockOutLabel";
            ClockOutLabel.Size = new Size(106, 18);
            ClockOutLabel.TabIndex = 7;
            ClockOutLabel.Text = "Clock Out Time:";
            // 
            // TipsLabel
            // 
            TipsLabel.AutoSize = true;
            TipsLabel.Location = new Point(36, 227);
            TipsLabel.Name = "TipsLabel";
            TipsLabel.Size = new Size(34, 18);
            TipsLabel.TabIndex = 11;
            TipsLabel.Text = "Tips";
            // 
            // TipsBox
            // 
            TipsBox.Location = new Point(12, 249);
            TipsBox.Margin = new Padding(3, 4, 3, 4);
            TipsBox.Name = "TipsBox";
            TipsBox.Size = new Size(79, 23);
            TipsBox.TabIndex = 1;
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
            HeadingLabel.Location = new Point(12, 9);
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
            // ClockInTime
            // 
            ClockInTime.AutoSize = true;
            ClockInTime.Location = new Point(105, 160);
            ClockInTime.Name = "ClockInTime";
            ClockInTime.Size = new Size(0, 18);
            ClockInTime.TabIndex = 23;
            // 
            // ClockOutTime
            // 
            ClockOutTime.AutoSize = true;
            ClockOutTime.Location = new Point(122, 286);
            ClockOutTime.Name = "ClockOutTime";
            ClockOutTime.Size = new Size(0, 18);
            ClockOutTime.TabIndex = 24;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 377);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 25;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ClockInClockOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(327, 415);
            Controls.Add(BackBtn);
            Controls.Add(ClockOutTime);
            Controls.Add(ClockInTime);
            Controls.Add(EmployeePosition);
            Controls.Add(EmployeeFullName);
            Controls.Add(EmployeeId);
            Controls.Add(PositionLabel);
            Controls.Add(EmployeeIdLabel);
            Controls.Add(HeadingLabel);
            Controls.Add(NameLabel);
            Controls.Add(TipsBox);
            Controls.Add(TipsLabel);
            Controls.Add(ClockOutLabel);
            Controls.Add(ClockInLabel);
            Controls.Add(buttonClockOut);
            Controls.Add(buttonClockIn);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClockInClockOutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Information & Clock in-Clock out";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClockIn;
        private Button buttonClockOut;
        private Label ClockInLabel;
        private Label ClockOutLabel;
        private Label TipsLabel;
        private TextBox TipsBox;
        private Label NameLabel;
        private Label HeadingLabel;
        private Label EmployeeIdLabel;
        private Label PositionLabel;
        private Label EmployeeId;
        private Label EmployeeFullName;
        private Label EmployeePosition;
        private Label ClockInTime;
        private Label ClockOutTime;
        private Button BackBtn;
    }
}
