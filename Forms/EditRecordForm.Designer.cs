namespace ClockIn_ClockOut.Forms
{
    partial class ViewRecordForm
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
            BackBtn = new Button();
            updateBtn = new Button();
            idLabel = new Label();
            fullNameLabel = new Label();
            positionLabel = new Label();
            tipsLabel = new Label();
            dayLabel = new Label();
            hoursLabel = new Label();
            totalPayLabel = new Label();
            nameBox = new TextBox();
            employeeIdBox = new TextBox();
            dayBox = new TextBox();
            payBox = new TextBox();
            positionBox = new TextBox();
            tipsBox = new TextBox();
            hoursBox = new TextBox();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 380);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(104, 380);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(86, 28);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(14, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(84, 18);
            idLabel.TabIndex = 3;
            idLabel.Text = "Employee Id";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(14, 64);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(70, 18);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(14, 116);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(57, 18);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Position";
            // 
            // tipsLabel
            // 
            tipsLabel.AutoSize = true;
            tipsLabel.Location = new Point(14, 169);
            tipsLabel.Name = "tipsLabel";
            tipsLabel.Size = new Size(34, 18);
            tipsLabel.TabIndex = 6;
            tipsLabel.Text = "Tips";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(14, 328);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(31, 18);
            dayLabel.TabIndex = 7;
            dayLabel.Text = "Day";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(14, 222);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(98, 18);
            hoursLabel.TabIndex = 8;
            hoursLabel.Text = "Hours Worked";
            // 
            // totalPayLabel
            // 
            totalPayLabel.AutoSize = true;
            totalPayLabel.Location = new Point(14, 275);
            totalPayLabel.Name = "totalPayLabel";
            totalPayLabel.Size = new Size(63, 18);
            totalPayLabel.TabIndex = 9;
            totalPayLabel.Text = "Total Pay";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(14, 85);
            nameBox.Margin = new Padding(3, 4, 3, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(176, 23);
            nameBox.TabIndex = 2;
            // 
            // employeeIdBox
            // 
            employeeIdBox.Location = new Point(14, 32);
            employeeIdBox.Margin = new Padding(3, 4, 3, 4);
            employeeIdBox.Name = "employeeIdBox";
            employeeIdBox.Size = new Size(176, 23);
            employeeIdBox.TabIndex = 1;
            // 
            // dayBox
            // 
            dayBox.Location = new Point(14, 349);
            dayBox.Margin = new Padding(3, 4, 3, 4);
            dayBox.Name = "dayBox";
            dayBox.Size = new Size(176, 23);
            dayBox.TabIndex = 7;
            // 
            // payBox
            // 
            payBox.Location = new Point(14, 296);
            payBox.Margin = new Padding(3, 4, 3, 4);
            payBox.Name = "payBox";
            payBox.Size = new Size(176, 23);
            payBox.TabIndex = 6;
            // 
            // positionBox
            // 
            positionBox.Location = new Point(14, 138);
            positionBox.Margin = new Padding(3, 4, 3, 4);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(176, 23);
            positionBox.TabIndex = 3;
            // 
            // tipsBox
            // 
            tipsBox.Location = new Point(14, 191);
            tipsBox.Margin = new Padding(3, 4, 3, 4);
            tipsBox.Name = "tipsBox";
            tipsBox.Size = new Size(176, 23);
            tipsBox.TabIndex = 4;
            // 
            // hoursBox
            // 
            hoursBox.Location = new Point(14, 244);
            hoursBox.Margin = new Padding(3, 4, 3, 4);
            hoursBox.Name = "hoursBox";
            hoursBox.Size = new Size(176, 23);
            hoursBox.TabIndex = 5;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(326, 380);
            buttonDel.Margin = new Padding(3, 4, 3, 4);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(86, 28);
            buttonDel.TabIndex = 10;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += deleteBtn_Click;
            // 
            // ViewRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(424, 428);
            Controls.Add(buttonDel);
            Controls.Add(hoursBox);
            Controls.Add(tipsBox);
            Controls.Add(positionBox);
            Controls.Add(payBox);
            Controls.Add(dayBox);
            Controls.Add(employeeIdBox);
            Controls.Add(nameBox);
            Controls.Add(totalPayLabel);
            Controls.Add(hoursLabel);
            Controls.Add(dayLabel);
            Controls.Add(tipsLabel);
            Controls.Add(positionLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(idLabel);
            Controls.Add(updateBtn);
            Controls.Add(BackBtn);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Record";
            Load += ViewRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button updateBtn;
        private Label idLabel;
        private Label fullNameLabel;
        private Label positionLabel;
        private Label tipsLabel;
        private Label dayLabel;
        private Label hoursLabel;
        private Label totalPayLabel;
        private TextBox nameBox;
        private TextBox employeeIdBox;
        private TextBox dayBox;
        private TextBox payBox;
        private TextBox positionBox;
        private TextBox tipsBox;
        private TextBox hoursBox;
        private Button buttonDel;
    }
}