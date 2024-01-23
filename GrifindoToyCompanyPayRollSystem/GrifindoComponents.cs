using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Drawing;

namespace GrifindoToyCompanyPayRollSystem
{

    /* 
        Reusable functions to handle the clean code
     
     */

    internal class GrifindoComponents
    {

        internal static string grifindoDatabaseConnectionString = @"Data Source=GAJEN\SQLEXPRESS;Initial Catalog = GrifindoDatabase; Integrated Security = True;";
        internal static string employeeTableName = "EmployeeInformation";
        internal static string adminTable = "AdminTable";

        /* Input Cleaner */
        internal static void EntryCleaning(TextBox[] entryArgs, NumericUpDown[] numberBoxArgs)
        {
            foreach (var entry in entryArgs)
            {
                entry.Clear();
            }

            foreach (var numBox in numberBoxArgs)
            {
                numBox.Value = 0;
            }


        }

        /* Create Employee Infromation Database Table */
        internal static bool CreateDatabaseForEmployeesInformation(TextBox[] entryArray, NumericUpDown[] numberBoxArray)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            SqlCommand cmd;
            conn.Open();
            try
            {
                cmd = new SqlCommand("CREATE TABLE EpmloyeeInformation(" +
                    "EmployeeID INT NOT NULL IDENTITY PRIMARY KEY," +
                    "Name VARCHAR(50) NOT NULL," +
                    "Email VARCHAR(100)," +
                    "Phone VARCHAR(30) NOT NULL," +
                    "NIC VARCHAR(50) NOT NULL," +
                    "Address VARCHAR(200)," +
                    "Gender VARCHAR(10)," +
                    "MaritalStatus VARCHAR(20)," +
                    "MonthlySalary REAL NOT NULL," +
                    "OverTimeRatesHourly REAL NOT NULL," +
                    "Allowances REAL NOT NULL" +
                    ")", conn);
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Grifindo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                EntryCleaning(entryArray, numberBoxArray);
            }
            return false;
        }

        internal static bool IsTheTableExists(string tableName)
        {

            SqlConnection connction = new SqlConnection(grifindoDatabaseConnectionString);
            connction.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName};", connction);
            DataSet ds = new DataSet();

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);

                bool IsloginSuccess = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
                if (IsloginSuccess)
                    return true;
                else
                    return false;

            } catch (Exception ex)
            {

            } finally { connction.Close(); }

            return false;
        }

        /* Get the all the inputs from user and it maintain database formate */
        internal static ArrayList GetEntryInputs(TextBox[] arrayStringValues, NumericUpDown[] arrayIntValues, string gender, string maritalStatus)
        {
            ArrayList list = new ArrayList();
            foreach (var array_val in arrayStringValues)
            {
                list.Add(array_val.Text);
            }

            list.Add(gender);
            list.Add(maritalStatus);

            foreach (var array_val in arrayIntValues)
            {
                list.Add(array_val.Value);
            }

            return list;
        }
        
        /* Store the employee information */
        internal static bool StoreTheEmployeeInformations(ArrayList employeeArray)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            SqlCommand cmd;
            conn.Open();

            try
            {
                cmd = new SqlCommand("INSERT INTO EpmloyeeInformation (Name, Email, Phone, NIC, Address, Gender, MaritalStatus, MonthlySalary, OverTimeRatesHourly, Allowances) " +
                    $"VALUES ('{employeeArray[0]}', '{employeeArray[1]}', '{employeeArray[2]}', '{employeeArray[3]}', '{employeeArray[4]}', '{employeeArray[5]}', '{employeeArray[6]}', '{employeeArray[7]}', '{employeeArray[8]}', '{employeeArray[9]}')", conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                conn.Close();
            }

            return false;
        }

        /* Store the employee information */
        internal static bool UpdateTheEmployeeInformations(ArrayList employeeArray, Object EmployeeID)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            SqlCommand cmd;
            conn.Open();

            try
            {
                cmd = new SqlCommand($"UPDATE EpmloyeeInformation SET " +
                    $"Name = '{employeeArray[0]}', " +
                    $"Email = '{employeeArray[1]}' , " +
                    $"Phone = '{employeeArray[2]}', " +
                    $"NIC =  '{employeeArray[3]}', " +
                    $"Address = '{employeeArray[4]}', " +
                    $"Gender = '{employeeArray[5]}', " +
                    $"MaritalStatus = '{employeeArray[6]}', " +
                    $"MonthlySalary = '{employeeArray[7]}', " +
                    $"OverTimeRatesHourly = '{employeeArray[8]}', " +
                    $"Allowances = '{employeeArray[9]}' WHERE EmployeeID = '{EmployeeID}' ", conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
    }
}
