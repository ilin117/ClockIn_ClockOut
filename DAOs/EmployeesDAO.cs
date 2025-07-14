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
    internal class EmployeesDAO
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static BindingList<EmployeeModel> GetAllClockedInEmployees()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<EmployeeModel>("select * from Employees where Employee_Id in (select Employee_Id from Time_Records where End_Time is null)", new DynamicParameters()).ToList();
                return new BindingList<EmployeeModel>(output.ToList());
            }
        }

        public static BindingList<EmployeeModel> GetAllNotWorkingEmployees()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<EmployeeModel>("select * from Employees where Employee_Id not in (select Employee_Id from Time_Records where End_Time is null)", new DynamicParameters()).ToList();
                return new BindingList<EmployeeModel>(output.ToList());
            }
        }

        public static BindingList<EmployeeModel> GetAllEmployees()
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<EmployeeModel>("select * from Employees", new DynamicParameters()).ToList();
                return new BindingList<EmployeeModel>(output);
            }
        }

        public static void InsertEmployee(EmployeeModel employee)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("insert into Employees (Employee_Id, First_Name, Last_Name, Position, Pay_Per_Hour, Address, Email, Phone_Number, SSN) values (@Employee_Id, @First_Name, @Last_Name, @Position, @Pay_Per_Hour, @Address, @Email, @Phone_Number, @SSN)", employee);
            }
        }

        public static void updateEmployeeInfo(EmployeeModel employee)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute(@"update Employees set 
                                    Employee_Id = @Employee_Id,
                                    First_Name = @First_Name,
                                    Last_Name = @Last_Name,
                                    Position = @Position,
                                    Pay_Per_Hour = @Pay_Per_Hour,
                                    Address = @Address,
                                    Phone_Number = @Phone_Number,
                                    Email = @Email,
                                    SSN = @SSN
                                    where id = @Id", employee);
            }
        }

        public static void removeEmployee(EmployeeModel employee)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {

                connection.Open();
                connection.Execute("PRAGMA foreign_keys = ON;");
                connection.Execute(@"delete from Employees where Employee_Id = @Employee_Id", employee);

            }
        }

    }
}
