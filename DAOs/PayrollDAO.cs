using ClockIn_ClockOut.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace ClockIn_ClockOut.DAOs
{
    internal class PayrollDAO
    {

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


        public static void insertIntoPayroll(TimeRecordModel time_record, EmployeeModel employee)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new
                {
                    Employee_Id = employee.Employee_Id,
                    Full_Name = $"{employee.First_Name} {employee.Last_Name}",
                    Position = employee.Position,
                    Tips = time_record.Tips,
                    Hours_Worked = time_record.Hours_Worked,
                    Pay_Per_Hour = employee.Pay_Per_Hour,
                    Day = time_record.Start_Time.Date.ToString("yyyy-MM-dd")
                };
                connection.Execute(@"
                    INSERT INTO Payrolls (
                        Employee_Id,
                        Full_Name,
                        Position,
                        Tips,
                        Hours_Worked,
                        Pay_Per_Hour,
                        Day
                    ) 
                    VALUES (
                        @Employee_Id,
                        @Full_Name,
                        @Position,
                        @Tips,
                        @Hours_Worked,
                        @Pay_Per_Hour,
                        @Day
                    );
                ", parameters);

            }
        }

        public static BindingList<PayrollModel> GetAllPayrolls()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<PayrollModel>(@"Select * from Payrolls order by Day desc").ToList();
                return new BindingList<PayrollModel>(output);
            }
        }

        public static void updatePayrollRecord(PayrollModel payroll_info)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"update Payrolls set 
                                    Employee_Id = @Employee_Id,
                                    Full_Name = @Full_Name,
                                    Position = @Position,
                                    Tips = @Tips,
                                    Hours_Worked = @Hours_Worked,
                                    Pay_Per_Hour = @Pay_Per_Hour,
                                    Day = @Day
                                    where Id = @Id", payroll_info);
            }
        }

        public static void deletePayrollRecord(PayrollModel payroll_info)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"delete from Payrolls where Id = @Id", payroll_info);
            }
        }

        public static void deleteSelectedPayrollRecords(List<PayrollModel> payrolls)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var ids = payrolls.Select(p => p.Id).ToList();
                connection.Execute("delete from Payrolls where Id in @Ids", new { Ids = ids });
            }
        }

        public static BindingList<PayrollModel> Filter(Dictionary<string, object> filters)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var conditions = new List<string>();
                var parameters = new DynamicParameters();
                
                if (filters.ContainsKey("Start_Date") && filters.ContainsKey("End_Date"))
                {
                    conditions.Add("Day between DATE(@Start_Date) and DATE(@End_Date)");
                    parameters.Add("@Start_Date", filters["Start_Date"]);
                    parameters.Add("@End_Date", filters["End_Date"]);
                }
                if (filters.ContainsKey("Employee_Id"))
                {
                    conditions.Add("Employee_Id = @Employee_Id");
                    parameters.Add("@Employee_Id", filters["Employee_Id"]);
                }
                if (filters.ContainsKey("Position"))
                {
                    conditions.Add("Position like @Position");
                    parameters.Add("@Position", $"%{filters["Position"]}");
                }
                if (filters.ContainsKey("Name"))
                {
                    conditions.Add("Full_Name like @Name");
                    parameters.Add("@Name", $"%{filters["Name"]}%");
                }

                string clause = string.Join(" and ", conditions);
                string sql = "select * from Payrolls";
                if (clause.Length > 0)
                {
                    sql += " WHERE " + clause;
                }

                var output = connection.Query<PayrollModel>(sql + " order by Day desc", parameters).ToList();
                return new BindingList<PayrollModel>(output);
            }
        }

    }
}
