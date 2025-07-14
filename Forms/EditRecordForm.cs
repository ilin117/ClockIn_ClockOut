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
    public partial class EditRecordForm : Form
    {
        PayrollModel payroll_record;
        public EditRecordForm()
        {
            InitializeComponent();
        }

        public EditRecordForm(PayrollModel payroll_record)
        {
            InitializeComponent();
            this.payroll_record = payroll_record;
        }

        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{payroll_record.Full_Name} on {payroll_record.Day}";
            employeeIdBox.Text = payroll_record.Employee_Id.ToString();
            nameBox.Text = payroll_record.Full_Name.ToString();
            positionBox.Text = payroll_record.Position.ToString();
            tipsBox.Text = payroll_record.Tips.ToString();
            hoursBox.Text = payroll_record.Hours_Worked.ToString();
            payBox.Text = payroll_record.Pay_Per_Hour.ToString();
            dayBox.Text = payroll_record.Day.ToString();
            dayBox.Enabled = false;
            payBox.Enabled = false;
            positionBox.Enabled = false;
            employeeIdBox.Enabled = false;
            nameBox.Enabled = false;


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AdminPageForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            payroll_record.Employee_Id = int.Parse(employeeIdBox.Text);
            payroll_record.Full_Name = AddEmployeeForm.CapitalizeFirstLetter(nameBox.Text);
            payroll_record.Position = AddEmployeeForm.CapitalizeFirstLetter(positionBox.Text);
            payroll_record.Tips = double.Parse(tipsBox.Text);
            payroll_record.Hours_Worked = double.Parse(hoursBox.Text); ;
            payroll_record.Pay_Per_Hour = double.Parse(payBox.Text); ;
            payroll_record.Day = dayBox.Text;

            if (!double.TryParse(tipsBox.Text, out _) || !double.TryParse(hoursBox.Text, out _))
            {
                MessageBox.Show("Both tips and hours must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PayrollDAO.updatePayrollRecord(payroll_record);
                MessageBox.Show("Record updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var form = new AdminPageForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"Record removed for {payroll_record.Full_Name}", "Employee Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PayrollDAO.deletePayrollRecord(payroll_record);
                this.Hide();
                var form = new AdminPageForm();
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
