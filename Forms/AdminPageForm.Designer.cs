namespace ClockIn_ClockOut.Forms
{
    partial class AdminPageForm
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
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            FilterBtn = new Button();
            AddEmployeeBtn = new Button();
            editBtn = new Button();
            checkBoxDate = new CheckBox();
            checkBoxEmployeeId = new CheckBox();
            checkBoxName = new CheckBox();
            checkBoxPosition = new CheckBox();
            BackBtn = new Button();
            buttonExport = new Button();
            TimeRecordsFromDate = new ListBox();
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxPosition = new TextBox();
            textBoxEmployeeId = new TextBox();
            buttonClear = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("Inter", 10F);
            StartDatePicker.Location = new Point(128, 13);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(228, 24);
            StartDatePicker.TabIndex = 0;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(391, 13);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(228, 24);
            EndDatePicker.TabIndex = 3;
            // 
            // FilterBtn
            // 
            FilterBtn.Location = new Point(186, 144);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(86, 28);
            FilterBtn.TabIndex = 6;
            FilterBtn.Text = "Filter";
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += Filter;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.Location = new Point(721, 10);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new Size(137, 28);
            AddEmployeeBtn.TabIndex = 14;
            AddEmployeeBtn.Text = "Add Employee";
            AddEmployeeBtn.UseVisualStyleBackColor = true;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(721, 44);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(137, 28);
            editBtn.TabIndex = 16;
            editBtn.Text = "Edit Employee";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // checkBoxDate
            // 
            checkBoxDate.AccessibleDescription = "";
            checkBoxDate.AccessibleName = "Day";
            checkBoxDate.AutoSize = true;
            checkBoxDate.Location = new Point(12, 12);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(60, 25);
            checkBoxDate.TabIndex = 17;
            checkBoxDate.Text = "Date";
            checkBoxDate.UseVisualStyleBackColor = true;
            checkBoxDate.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxEmployeeId
            // 
            checkBoxEmployeeId.AccessibleDescription = "";
            checkBoxEmployeeId.AccessibleName = "Employee_Id";
            checkBoxEmployeeId.AutoSize = true;
            checkBoxEmployeeId.Location = new Point(12, 73);
            checkBoxEmployeeId.Name = "checkBoxEmployeeId";
            checkBoxEmployeeId.Size = new Size(110, 25);
            checkBoxEmployeeId.TabIndex = 18;
            checkBoxEmployeeId.Tag = "";
            checkBoxEmployeeId.Text = "Employee Id";
            checkBoxEmployeeId.UseVisualStyleBackColor = true;
            checkBoxEmployeeId.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxName
            // 
            checkBoxName.AccessibleDescription = "";
            checkBoxName.AccessibleName = "Full_Name";
            checkBoxName.AutoSize = true;
            checkBoxName.Location = new Point(12, 103);
            checkBoxName.Name = "checkBoxName";
            checkBoxName.Size = new Size(68, 25);
            checkBoxName.TabIndex = 19;
            checkBoxName.Tag = "";
            checkBoxName.Text = "Name";
            checkBoxName.UseVisualStyleBackColor = true;
            checkBoxName.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBoxPosition
            // 
            checkBoxPosition.AccessibleName = "Position";
            checkBoxPosition.AutoSize = true;
            checkBoxPosition.Location = new Point(12, 43);
            checkBoxPosition.Name = "checkBoxPosition";
            checkBoxPosition.Size = new Size(80, 25);
            checkBoxPosition.TabIndex = 20;
            checkBoxPosition.Tag = "textBoxPosition";
            checkBoxPosition.Text = "Position";
            checkBoxPosition.UseVisualStyleBackColor = true;
            checkBoxPosition.CheckedChanged += checkBox_CheckedChanged;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 456);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 28);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(785, 456);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(116, 28);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "Export as PDF";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // TimeRecordsFromDate
            // 
            TimeRecordsFromDate.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeRecordsFromDate.FormattingEnabled = true;
            TimeRecordsFromDate.HorizontalExtent = 100;
            TimeRecordsFromDate.HorizontalScrollbar = true;
            TimeRecordsFromDate.ItemHeight = 18;
            TimeRecordsFromDate.Location = new Point(12, 195);
            TimeRecordsFromDate.Name = "TimeRecordsFromDate";
            TimeRecordsFromDate.Size = new Size(889, 256);
            TimeRecordsFromDate.TabIndex = 1;
            TimeRecordsFromDate.DoubleClick += TimeRecordsFromDate_DoubleClick;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(128, 104);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(144, 24);
            textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 14);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 24;
            label1.Text = "to";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(128, 44);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(144, 24);
            textBoxPosition.TabIndex = 1;
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(128, 74);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(144, 24);
            textBoxEmployeeId.TabIndex = 2;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 144);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(86, 28);
            buttonClear.TabIndex = 26;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(693, 457);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 28);
            buttonDelete.TabIndex = 27;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdminPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(913, 514);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(textBoxPosition);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(checkBoxPosition);
            Controls.Add(checkBoxName);
            Controls.Add(checkBoxEmployeeId);
            Controls.Add(checkBoxDate);
            Controls.Add(editBtn);
            Controls.Add(BackBtn);
            Controls.Add(AddEmployeeBtn);
            Controls.Add(FilterBtn);
            Controls.Add(buttonExport);
            Controls.Add(EndDatePicker);
            Controls.Add(TimeRecordsFromDate);
            Controls.Add(StartDatePicker);
            Font = new Font("Inter", 10F);
            ForeColor = Color.Black;
            Name = "AdminPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Load += AdminPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Button FilterBtn;
        private Button AddEmployeeBtn;
        private Button editBtn;
        private CheckBox checkBoxDate;
        private CheckBox checkBoxEmployeeId;
        private CheckBox checkBoxName;
        private CheckBox checkBoxPosition;
        private Button BackBtn;
        private Button buttonExport;
        private ListBox TimeRecordsFromDate;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPosition;
        private TextBox textBoxEmployeeId;
        private Button buttonClear;
        private Button buttonDelete;
    }
}