using ClockIn_ClockOut.DAOs;
using ClockIn_ClockOut.Forms;
using ClockIn_ClockOut.Models;

namespace ClockIn_ClockOut
{
    public partial class ClockInClockOutForm : Form
    {
        TimeRecordModel time_record;
        EmployeeModel employee;
        public ClockInClockOutForm()
        {
            InitializeComponent();
        }

        public ClockInClockOutForm(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;

        }

        public void ClockInButtonClick(object sender, EventArgs e)
        {
            if (ClockInTime.Text != "")
            {
                MessageBox.Show($"Make sure to clock out first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                time_record = new TimeRecordModel(DateTime.Now, employee.Employee_Id);
                ClockInTime.Text = time_record.Start_Time.ToString();
                TimeRecordsDAO.ClockIn(time_record);
                MessageBox.Show("Good luck with your shift!");
                Hide();
                EmployeeSelectForm employeeInfoForm = new EmployeeSelectForm();
                employeeInfoForm.Closed += (s, args) => Close();
                employeeInfoForm.Show();
                return;
            }
        }

        public void ClockOutButtonClick(object sender, EventArgs e)
        {
            if (time_record == null || time_record.Start_Time == default)
            {
                MessageBox.Show("You haven't clocked in yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TipsBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter tip amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!double.TryParse(TipsBox.Text, out _))
            {
                MessageBox.Show("Tip isn't a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                time_record.End_Time = DateTime.Now;
                ClockOutTime.Text = time_record.End_Time.ToString();
                time_record.Tips = double.Parse(TipsBox.Text);
                TimeSpan duration = time_record.End_Time - time_record.Start_Time;
                time_record.Hours_Worked = duration.TotalHours;
                TipsBox.Clear();
                MessageBox.Show($"Total: {Math.Round(duration.TotalHours, 2)} hrs, ${time_record.Tips} tips, ${Math.Round(employee.Pay_Per_Hour * time_record.Hours_Worked + time_record.Tips, 2)} earned", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TimeRecordsDAO.ClockOut(time_record);
                PayrollDAO.insertIntoPayroll(time_record, employee);
                Hide();
                EmployeeSelectForm employeeInfoForm = new EmployeeSelectForm();
                employeeInfoForm.Closed += (s, args) => Close();
                employeeInfoForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (time_record == null || time_record.Start_Time == default)
            {
                time_record = TimeRecordsDAO.GetTimeRecordModel(employee.Employee_Id);
                TipsLabel.Visible = false;
                TipsBox.Visible = false;
            }

            if (time_record != null && time_record.Start_Time != default)
            {
                ClockInTime.Text = time_record.Start_Time.ToString();
                TipsLabel.Visible = true;
                TipsBox.Visible = true;

            }
            EmployeeFullName.Text = $"{employee.First_Name} {employee.Last_Name}";
            EmployeeId.Text = employee.Employee_Id.ToString();
            EmployeePosition.Text = employee.Position;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EmployeeSelectForm();
            form.Closed += (s, args) => Close();
            form.Show();
        }
    }
}
