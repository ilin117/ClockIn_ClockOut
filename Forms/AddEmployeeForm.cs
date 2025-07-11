using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Forms;
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

namespace ClockIn_ClockOut
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public void SubmitEmployeeInfo(object sender, EventArgs e)
        {
            int employee_id;
            string first_name = CapitalizeFirstLetter(FirstNameBox.Text);
            string last_name = CapitalizeFirstLetter(LastNameBox.Text);
            string position = CapitalizeFirstLetter(PositionNameBox.Text);
            double pay;


            
            if (!int.TryParse(EmployeeIdBox.Text, out employee_id) || !double.TryParse(PayBox.Text, out pay) || string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(position))
            {
                string errorMessage = "";

                if (EmployeeIdBox.Text == "" || PayBox.Text == "" || string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(position))
                {
                    errorMessage += "Fields cannot be empty\n";
                }

                if (!int.TryParse(EmployeeIdBox.Text, out _))
                {
                    errorMessage += "Please enter a numeric value for Employee ID\n";
                }

                if (!double.TryParse(PayBox.Text, out _))
                {
                    errorMessage += "Please enter a numeric value for Pay";
                }

                MessageBox.Show(errorMessage.Trim(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeModel employee = new EmployeeModel(employee_id, first_name, last_name, position, pay);
            try
            {
                EmployeesDAO.InsertEmployee(employee);
                MessageBox.Show($"{employee.First_Name} {employee.Last_Name} has been added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeIdBox.Clear();
                FirstNameBox.Clear();
                LastNameBox.Clear();
                PositionNameBox.Clear();
                PayBox.Clear();
                this.Hide();
                var form = new AdminPageForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Employee Id is taken. Please Use another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            return string.Join(" ", words);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AdminPageForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
