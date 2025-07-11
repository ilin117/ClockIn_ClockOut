namespace ClockIn_ClockOut.Forms
{
    partial class EmployeeEditSelectForm
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
            employeeListbox = new ListBox();
            label1 = new Label();
            backBtn = new Button();
            SuspendLayout();
            // 
            // employeeListbox
            // 
            employeeListbox.Font = new Font("Inter", 10F);
            employeeListbox.FormattingEnabled = true;
            employeeListbox.ItemHeight = 18;
            employeeListbox.Location = new Point(14, 61);
            employeeListbox.Margin = new Padding(3, 4, 3, 4);
            employeeListbox.Name = "employeeListbox";
            employeeListbox.Size = new Size(886, 382);
            employeeListbox.TabIndex = 0;
            employeeListbox.DoubleClick += employeeListbox_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 1;
            label1.Text = "Choose an employee (Double click)";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(14, 451);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(86, 28);
            backBtn.TabIndex = 2;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // EmployeeEditSelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(914, 492);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(employeeListbox);
            Font = new Font("Inter", 10F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeEditSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeEditForm";
            Load += EmployeeEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox employeeListbox;
        private Label label1;
        private Button backBtn;
    }
}