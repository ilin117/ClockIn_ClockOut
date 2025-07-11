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
        }

        private void EmployeeSelectForm_Load(object sender, EventArgs e)
        {
            BindingList<EmployeeModel> employees = EmployeesDAO.GetAllEmployees();
            EmployeeListBox.DataSource = employees;
        }


        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            BindingList<EmployeeModel> employees = EmployeesDAO.GetAllEmployees();
            EmployeeListBox.DataSource = employees;
        }

        private void GotoAdminBtn_Click(object sender, EventArgs e)
        {
            string password = "";
            while (password != "Issac")
            {
                password = Interaction.InputBox("Enter Password", "Password Input", "");

                if (string.IsNullOrEmpty(password))
                {
                    return;
                }

                if (password == "Issac")
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
