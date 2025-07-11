using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockIn_ClockOut.Forms
{
    public partial class EditEmployeeForm : Form
    {
        EmployeeModel employee;
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public EditEmployeeForm(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            textBoxEmployeeId.Text = employee.Employee_Id.ToString();
            textBoxFirstName.Text = employee.First_Name;
            textBoxLastName.Text = employee.Last_Name;
            textBoxPosition.Text = employee.Position;
            textBoxPayPerHour.Text = employee.Pay_Per_Hour.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new EmployeeEditSelectForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxEmployeeId.Text, out _) || !double.TryParse(textBoxPayPerHour.Text, out _) || string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxPosition.Text))
            {
                string errorMessage = "";

                if (textBoxEmployeeId.Text == "" || textBoxPayPerHour.Text == "" || string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxPosition.Text))
                {
                    errorMessage += "Fields cannot be empty\n";
                }

                if (!int.TryParse(textBoxEmployeeId.Text, out _))
                {
                    errorMessage += "Please enter a numeric value for Employee ID\n";
                }

                if (!double.TryParse(textBoxPayPerHour.Text, out _))
                {
                    errorMessage += "Please enter a numeric value for Pay";
                }

                MessageBox.Show(errorMessage.Trim());
                return;
            }

            employee.Employee_Id = int.Parse(textBoxEmployeeId.Text);
            employee.First_Name = AddEmployeeForm.CapitalizeFirstLetter(textBoxFirstName.Text);
            employee.Last_Name = AddEmployeeForm.CapitalizeFirstLetter(textBoxLastName.Text);
            employee.Position = AddEmployeeForm.CapitalizeFirstLetter(textBoxPosition.Text);
            employee.Pay_Per_Hour = double.Parse(textBoxPayPerHour.Text);

            try
            {
                EmployeesDAO.updateEmployeeInfo(employee);
                MessageBox.Show("Employee information updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var form = new EmployeeEditSelectForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Employee Id is taken. Please Use another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"Information removed for {employee.First_Name} {employee.Last_Name} with id: {employee.Employee_Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeesDAO.removeEmployee(employee);
                this.Hide();
                var form = new EmployeeEditSelectForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
