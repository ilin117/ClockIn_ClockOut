using ClockIn_ClockOut.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClockIn_ClockOut.DAOs
{
    internal class TimeRecordsDAO
    {

        public static TimeRecordModel GetTimeRecordModel(int employee_id)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                TimeRecordModel? output = connection.QueryFirstOrDefault<TimeRecordModel>("select * from Time_Records where Employee_Id=@employee_id and End_Time is null limit 1", new DynamicParameters(new { employee_id }));
                return output;
            }
        }

        public static void ClockIn(TimeRecordModel time_record)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Time_Records (Start_Time, Employee_Id) values (@Start_Time, @Employee_Id)", time_record);
            }
        }

        public static void ClockOut(TimeRecordModel time_record)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("update Time_Records set End_Time = @End_Time, Hours_Worked = @Hours_Worked, Tips = @Tips where Employee_Id = @Employee_Id and Start_Time = @Start_Time", time_record);
                connection.Execute("delete from Time_Records where End_Time = @End_Time and Hours_Worked = @Hours_Worked and Tips = @Tips and Employee_Id = @Employee_Id and Start_Time = @Start_Time", time_record);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
