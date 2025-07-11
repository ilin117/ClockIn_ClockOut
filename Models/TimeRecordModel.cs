using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockIn_ClockOut.Models
{
    public class TimeRecordModel
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public double Tips { get; set; }
        public double Hours_Worked { get; set; }


        public TimeRecordModel() { }

        public TimeRecordModel(DateTime start_Time, int employee_Id)
        {
            Start_Time = start_Time;
            Employee_Id = employee_Id;
        }

        public TimeRecordModel(DateTime start_Time, DateTime end_Time)
        {
            Start_Time = start_Time;
            End_Time = end_Time;
        }

        public override string ToString()
        {
            return $"Employee with Id of {Employee_Id} started at {Start_Time} and ended at {End_Time}. They worked {Math.Round(Hours_Worked, 2)} hours and made ${Tips} in tips";
        }
    }
}
