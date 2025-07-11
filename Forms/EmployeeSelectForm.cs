using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockIn_ClockOut.Forms
{
    public partial class EmployeeSelectForm : Form
    {
        public static string password_for_admin;
        private BindingList<EmployeeModel> not_working_employees;
        private BindingList<EmployeeModel> clocked_in_employees;
        public EmployeeSelectForm()
        {
            InitializeComponent();
        }

        public void ListBoxItemDoubleClick(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedItem != null)
            {
                EmployeeModel employee = (EmployeeModel)EmployeeListBox.SelectedItem;
                this.Hide();
                var form = new EmployeeInfoForm(employee);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            if (listBoxClockIn.SelectedItem != null)
            {
                EmployeeModel employee = (EmployeeModel)listBoxClockIn.SelectedItem;
                this.Hide();
                var form = new EmployeeInfoForm(employee);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void EmployeeSelectForm_Load(object sender, EventArgs e)
        {
            clocked_in_employees = EmployeesDAO.GetAllClockedInEmployees();
            not_working_employees = EmployeesDAO.GetAllNotWorkingEmployees();
            listBoxClockIn.DataSource = clocked_in_employees;
            EmployeeListBox.DataSource = not_working_employees;
            listBoxClockIn.ClearSelected();
            EmployeeListBox.ClearSelected();

            using (StreamReader sr = new StreamReader("password.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    password_for_admin = line;
                }
            }
        }

        private void GotoAdminBtn_Click(object sender, EventArgs e)
        {

            string password = "";
            while (password != password_for_admin)
            {
                password = Interaction.InputBox("Enter Password", "Password Input", "");

                if (string.IsNullOrEmpty(password))
                {
                    return;
                }

                if (password == password_for_admin)
                {
                    this.Hide();
                    var form = new AdminPageForm();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                    return;
                }

                MessageBox.Show("Wrong password. Try again.");
            }
        }
    }
}
