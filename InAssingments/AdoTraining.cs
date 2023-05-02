using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/// <summary>
///  Ado dotnet is a data access model for .net apps to talk to databases
///  System.Data class is used to connect to sql client
///  Db -> SqlClinet -> Execute classes to execute different queries Execute <Reader, NonQuery, Scaler>.
///  Execute NonQuery is used to delete the db.
///  Execute Scaler is used to get the single value out of the db.
/// </summary>

namespace AdoTraining
{
    internal static class Program
    {
        private const string connectionString = "Data Source=W-674PY03-1;Initial Catalog=kandarpDb;User ID=sa;Password=Password@12345";
        private const string selectall = "Select * from tblEmployee";

        private static void Main()
        {
            //ReadRecordsFromDb();
            //! InsertNewRecord("Sunder", 7843574234, 6534, 2, 1);
            //InsertRecordsUsingProc("Oingies", 6437343342, 58798, 1, 3);
            //DeleteRecordsUsingProcs(1020);
            //UpdateRecordsUsingProcs(1019, "Oingies", 6437343342, 58798, 1, 3);
            //FindRecordsUsingProcs(1019);
            //ReadRecordsFromDb();
            FindRecordsUsingProcs(1019);
        }

        private static void FindRecordsUsingProcs(int empId)
        {
            var connection = GetConnection();
            var statement = "findEmployee";
            var sqlCommand = new SqlCommand(statement, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@empId", empId);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmpId"]} {reader["EmpName"]} {reader["EmpSalary"]}  {reader["CityId"]}");
                }
                reader.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static void UpdateRecordsUsingProcs(int empId, string name, long phone, int salary, int deptId, int cityId)
        {
            var connection = GetConnection();

            var statement = "updateEmployee";

            var sqlCommand = new SqlCommand(statement, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@empName", name);
            sqlCommand.Parameters.AddWithValue("@empSalary", salary);
            sqlCommand.Parameters.AddWithValue("@empPhone", phone);
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@cityId", cityId);
            sqlCommand.Parameters.AddWithValue("@empId", empId);
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Updated successfully");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static SqlCommand AddParams(SqlCommand command, Dictionary<string, object> pairs)
        {
            foreach (var item in pairs)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            return command;
        }

        private static void InsertRecordsUsingProc(string name, long phone, int salary, int deptId, int cityId)
        {
            var connection = GetConnection();

            var statement = "insertEmployee";

            var sqlCommand = new SqlCommand(statement, connection);
            Int32 iGeneratedId = 0;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@empName", name);
            sqlCommand.Parameters.AddWithValue("@empSalary", salary);
            sqlCommand.Parameters.AddWithValue("@empPhone", phone);
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@cityId", cityId);
            sqlCommand.Parameters.AddWithValue("@empId", iGeneratedId);
            sqlCommand.Parameters[5].Direction = ParameterDirection.Output;
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine(sqlCommand.Parameters[5].Value);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static void DeleteRecordsUsingProcs(int empId)
        {
            var connection = GetConnection();
            var statement = "deleteEmployee";
            var sqlCommand = new SqlCommand(statement, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@empId", empId);
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static void InsertNewRecord(string name, long phone, int salary, int deptId, int cityId)
        {
            var connection = GetConnection();
            var statement = $"Insert into tblEmployee values('{name}',{phone},{salary},{deptId},{cityId})";
            var command = new SqlCommand(statement, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static void ReadRecordsFromDb()
        {
            var connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(selectall, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmpId"]} {reader["EmpName"]} {reader["EmpSalary"]}  {reader["CityId"]}");
                }
                reader.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection
            {
                ConnectionString = connectionString
            };
        }
    }
}
