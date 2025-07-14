using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Models;
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
    public partial class AdminSelectForm : Form
    {
        public AdminSelectForm()
        {
            InitializeComponent();
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            BindingList<EmployeeModel> employees = EmployeesDAO.GetAllEmployees();
            employeeListbox.DataSource = employees;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AdminPageForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void employeeListbox_DoubleClick(object sender, EventArgs e)
        {

            if (employeeListbox.SelectedItem != null)
            {
                EmployeeModel employee = (EmployeeModel)employeeListbox.SelectedItem;
                this.Hide();
                var form = new EditEmployeeForm(employee);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

    }
}
