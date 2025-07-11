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
            labelEmployeeId = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelPosition = new Label();
            labelPayPerHour = new Label();
            textBoxEmployeeId = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxPosition = new TextBox();
            textBoxPayPerHour = new TextBox();
            updateBtn = new Button();
            removeBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.AutoSize = true;
            labelEmployeeId.Location = new Point(14, 11);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(84, 18);
            labelEmployeeId.TabIndex = 0;
            labelEmployeeId.Text = "Employee Id";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(14, 64);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(75, 18);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(14, 116);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(73, 18);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(14, 169);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(57, 18);
            labelPosition.TabIndex = 3;
            labelPosition.Text = "Position";
            // 
            // labelPayPerHour
            // 
            labelPayPerHour.AutoSize = true;
            labelPayPerHour.Location = new Point(14, 222);
            labelPayPerHour.Name = "labelPayPerHour";
            labelPayPerHour.Size = new Size(90, 18);
            labelPayPerHour.TabIndex = 4;
            labelPayPerHour.Text = "Pay Per Hour";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(14, 32);
            textBoxEmployeeId.Margin = new Padding(3, 4, 3, 4);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(178, 23);
            textBoxEmployeeId.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(14, 138);
            textBoxLastName.Margin = new Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(178, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(14, 85);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(178, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(14, 191);
            textBoxPosition.Margin = new Padding(3, 4, 3, 4);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(178, 23);
            textBoxPosition.TabIndex = 4;
            // 
            // textBoxPayPerHour
            // 
            textBoxPayPerHour.Location = new Point(14, 244);
            textBoxPayPerHour.Margin = new Padding(3, 4, 3, 4);
            textBoxPayPerHour.Name = "textBoxPayPerHour";
            textBoxPayPerHour.Size = new Size(178, 23);
            textBoxPayPerHour.TabIndex = 5;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(106, 316);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(86, 28);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(274, 316);
            removeBtn.Margin = new Padding(3, 4, 3, 4);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(86, 28);
            removeBtn.TabIndex = 8;
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
            backBtn.TabIndex = 9;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(372, 352);
            Controls.Add(backBtn);
            Controls.Add(removeBtn);
            Controls.Add(updateBtn);
            Controls.Add(textBoxPayPerHour);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxEmployeeId);
            Controls.Add(labelPayPerHour);
            Controls.Add(labelPosition);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelEmployeeId);
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

        private Label labelEmployeeId;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelPosition;
        private Label labelPayPerHour;
        private TextBox textBoxEmployeeId;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxPosition;
        private TextBox textBoxPayPerHour;
        private Button updateBtn;
        private Button removeBtn;
        private Button backBtn;
    }
}