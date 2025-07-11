using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Models;
using CsvHelper;
using Microsoft.VisualBasic;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockIn_ClockOut.Forms
{
    public partial class AdminPageForm : Form
    {
        BindingList<PayrollModel> payrolls;
        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void AdminPageForm_Load(object sender, EventArgs e)
        {
            StartDatePicker.Enabled = false;
            EndDatePicker.Enabled = false;
            textBoxEmployeeId.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPosition.Enabled = false;
            FilterBtn.Enabled = false;

            checkBoxEmployeeId.Tag = textBoxEmployeeId;
            checkBoxName.Tag = textBoxName;
            checkBoxPosition.Tag = textBoxPosition;

            payrolls = PayrollDAO.GetAllPayrolls();
            TimeRecordsFromDate.DataSource = payrolls;
        }

        private void Filter(object sender, EventArgs e)
        {
            Dictionary<string, object> filters = new Dictionary<string, object>();
            if (checkBoxDate.Checked)
            {
                filters.Add("Start_Date", StartDatePicker.Value.ToString("yyyy-MM-dd 00:00:00"));
                filters.Add("End_Date", EndDatePicker.Value.ToString("yyyy-MM-dd 00:00:00"));
            }
            if (checkBoxEmployeeId.Checked)
            {
                filters.Add("Employee_Id", int.Parse(textBoxEmployeeId.Text));
            }
            if (checkBoxPosition.Checked)
            {
                filters.Add("Position", textBoxPosition.Text);
            }
            if (checkBoxName.Checked)
            {
                filters.Add("Name", textBoxName.Text);
            }


            payrolls = PayrollDAO.Filter(filters);
            TimeRecordsFromDate.DataSource = payrolls;
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddEmployeeForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new EmployeeSelectForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void TimeRecordsFromDate_DoubleClick(object sender, EventArgs e)
        {
            if (TimeRecordsFromDate.SelectedItem != null)
            {
                PayrollModel employee = (PayrollModel)TimeRecordsFromDate.SelectedItem;
                this.Hide();
                var form = new ViewRecordForm(employee);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new EmployeeEditSelectForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Tag is TextBox textBox)
                {
                    textBox.Enabled = checkBox.Checked;
                }

                if (checkBox == checkBoxDate)
                {
                    StartDatePicker.Enabled = checkBox.Checked;
                    EndDatePicker.Enabled = checkBox.Checked;
                }

                bool anyChecked =
                    checkBoxEmployeeId.Checked ||
                    checkBoxName.Checked ||
                    checkBoxPosition.Checked ||
                    checkBoxDate.Checked;

                FilterBtn.Enabled = anyChecked;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            checkBoxDate.Checked = false;
            checkBoxEmployeeId.Checked = false;
            checkBoxName.Checked = false;
            checkBoxPosition.Checked = false;

            textBoxEmployeeId.Enabled = false;
            textBoxName.Enabled = false;
            textBoxPosition.Enabled = false;
            textBoxEmployeeId.Text = "";
            textBoxName.Text = "";
            textBoxPosition.Text = "";

            StartDatePicker.Enabled = false;
            EndDatePicker.Enabled = false;

            FilterBtn.Enabled = false;
            payrolls = PayrollDAO.GetAllPayrolls();
            TimeRecordsFromDate.DataSource = payrolls;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var document = new Document();
            var section = document.AddSection();

            var title = section.AddParagraph("Payroll Summary");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = "0.25in";

            string periodText;
            if (checkBoxDate.Checked)
            {
                periodText = $"For the period of {StartDatePicker.Value:MM/dd/yyyy} to {EndDatePicker.Value:MM/dd/yyyy}";
            }
            else
            {
                periodText = $"Exported on {DateTime.Now:MM/dd/yyyy}";
            }

            section.AddParagraph(periodText).Format.SpaceAfter = "0.3in";

            var grouped = payrolls
                .GroupBy(p => new { p.Employee_Id, p.Full_Name })
                .OrderBy(g => g.Key.Employee_Id);

            foreach (var employeeGroup in grouped)
            {
                var empTitle = section.AddParagraph($"{employeeGroup.Key.Full_Name} (ID: {employeeGroup.Key.Employee_Id})");
                empTitle.Format.Font.Bold = true;
                empTitle.Format.SpaceBefore = "0.2in";
                empTitle.Format.SpaceAfter = "0.1in";

                var table = section.AddTable();
                table.Borders.Width = 0.75;

                var columns = new[] { "3cm", "3cm", "3cm", "3cm", "3cm" };
                foreach (var width in columns)
                {
                    table.AddColumn(width);
                }

                var header = table.AddRow();
                header.Shading.Color = Colors.LightGray;
                header.Cells[0].AddParagraph("Position");
                header.Cells[1].AddParagraph("Hours Worked");
                header.Cells[2].AddParagraph("Pay Rate");
                header.Cells[3].AddParagraph("Tips");
                header.Cells[4].AddParagraph("Earnings");

                double totalHours = 0, totalTips = 0, totalEarnings = 0;

                var positionGroups = employeeGroup.GroupBy(e => e.Position);
                foreach (var job in positionGroups)
                {
                    var row = table.AddRow();
                    double jobHours = job.Sum(x => x.Hours_Worked);
                    double jobTips = job.Sum(x => x.Tips);
                    double rate = job.First().Pay_Per_Hour;
                    double earnings = job.Sum(x => (x.Hours_Worked * x.Pay_Per_Hour) + x.Tips);

                    row.Cells[0].AddParagraph(job.Key);
                    row.Cells[1].AddParagraph(jobHours.ToString("0.00"));
                    row.Cells[2].AddParagraph(rate.ToString("0.00"));
                    row.Cells[3].AddParagraph(jobTips.ToString("0.00"));
                    row.Cells[4].AddParagraph(earnings.ToString("0.00"));

                    totalHours += jobHours;
                    totalTips += jobTips;
                    totalEarnings += earnings;
                }

                var subtotal = table.AddRow();
                subtotal.Shading.Color = Colors.LightYellow;
                subtotal.Cells[0].AddParagraph("Subtotal");
                subtotal.Cells[1].AddParagraph(totalHours.ToString("0.00"));
                subtotal.Cells[2].AddParagraph("");
                subtotal.Cells[3].AddParagraph(totalTips.ToString("0.00"));
                subtotal.Cells[4].AddParagraph(totalEarnings.ToString("0.00"));
            }

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Payroll_Records");
            Directory.CreateDirectory(folderPath);
            string filename = Path.Combine(folderPath, $"Payroll_Summary_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.pdf");

            var pdfRenderer = new PdfDocumentRenderer(true);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(filename);

            Clipboard.SetText(filename);
            MessageBox.Show($"PDF saved to:\n{filename}\n\nFile path copied to clipboard", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                Process.Start("explorer.exe", filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open file: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                PayrollDAO.deleteSelectedPayrollRecords(payrolls.ToList());
                TimeRecordsDAO.deleteWithSelectedPayrollRecords(payrolls.ToList());
                payrolls = PayrollDAO.GetAllPayrolls();

                TimeRecordsFromDate.DataSource = payrolls;

                buttonClear_Click(sender, e);
                MessageBox.Show($"Selected records has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            string new_password = Interaction.InputBox("Enter new password", "Password Input", "");

            if (string.IsNullOrEmpty(new_password))
            {
                return;
            }
            else
            {
                EmployeeSelectForm.password_for_admin = new_password;
                MessageBox.Show("New password set");
            }
            
        }
    }
}
