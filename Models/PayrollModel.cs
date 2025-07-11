using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockIn_ClockOut.Models
{
    public class PayrollModel
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public string Full_Name { get; set; }
        public string Position { get; set; }
        public double Tips { get; set; }
        public double Hours_Worked { get; set; }
        public double Pay_Per_Hour { get; set; }
        public string Day {  get; set; }

        public PayrollModel() { }

        public PayrollModel(int employee_Id, string full_Name, string position, double tips, double hours_worked, double pay_per_hour, string day)
        {
            Employee_Id = employee_Id;
            Full_Name = full_Name;
            Position = position;
            Tips = tips;
            Hours_Worked = hours_worked;
            Pay_Per_Hour = pay_per_hour;
            Day = day;
        }

        public override string ToString()
        {
            return $"{Full_Name} (ID: {Employee_Id}) worked {Hours_Worked:0.00} hrs on {Day}, earning ${(Hours_Worked * Pay_Per_Hour + Tips):0.00} total (${Tips:0.00} tips)";
        }
    }
}
