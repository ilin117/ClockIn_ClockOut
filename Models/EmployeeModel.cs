using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockIn_ClockOut.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Position { get; set; }
        public double Pay_Per_Hour {  get; set; }

        public EmployeeModel() { }

        public EmployeeModel(int employee_id, string first_name, string last_name, string position, double pay) {
            this.Employee_Id = employee_id;
            this.First_Name = first_name;
            this.Last_Name = last_name;
            this.Position = position;
            this.Pay_Per_Hour = pay; 
        }

        public override string ToString()
        {
            return $"{this.First_Name} {this.Last_Name}";
        }
    }
}
