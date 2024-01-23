using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrifindoToyCompanyPayRollSystem.EmployeePage;
using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;
using static GrifindoToyCompanyPayRollSystem.GrifindoMainWindow;
using static GrifindoToyCompanyPayRollSystem.SalaryPage;


namespace GrifindoToyCompanyPayRollSystem
{
    public partial class EmployeesUpdate : UserControl
    {
        private static ArrayList empoyeesInfo;

        static TextBox name;
        static TextBox email;
        static TextBox phone_num;
        static TextBox nic;
        static TextBox address;

        static NumericUpDown monthly_salary;
        static NumericUpDown overTime;
        static NumericUpDown allowance;

        static RadioButton male;
        static RadioButton female;
        static RadioButton married;
        static RadioButton unmarried;

        static string gender;
        static string marital_status;

        public EmployeesUpdate()
        {
            InitializeComponent();

            name = textBox_name;
            email = textBox_email;
            phone_num = textBox_phone_number;
            nic = textBox_nic;
            address = textBox_address;

            monthly_salary = numericUpDown_monthly_salary;
            overTime = numericUpDown_overttime_rates_hourly;
            allowance = numericUpDown_allowances;

            male = radioButton_male;
            female = radioButton_female;
            married = radioButton_married;
            unmarried = radioButton_unmarried;
        }

        internal static void UpdateEmployeesInfo(ArrayList EmployeesInfo)
        {
            empoyeesInfo = EmployeesInfo;

            allowance.Value = Convert.ToDecimal(EmployeesInfo[0]);
            overTime.Value = Convert.ToDecimal(EmployeesInfo[1]);
            monthly_salary.Value = Convert.ToDecimal(EmployeesInfo[2]);

            if (EmployeesInfo[3].ToString() == "Married")
                married.Checked = true;

            else if (EmployeesInfo[3].ToString() == "Unmarried")
                unmarried.Checked = true;


            if (EmployeesInfo[4].ToString() == "Male")
                male.Checked = true;

            else if (EmployeesInfo[4].ToString() == "Female")
                female.Checked = true;

            address.Text = EmployeesInfo[5].ToString();
            nic.Text = EmployeesInfo[6].ToString();
            phone_num.Text = EmployeesInfo[7].ToString();
            email.Text = EmployeesInfo[8].ToString();
            name.Text = EmployeesInfo[9].ToString();
        }

        private void button_delete_emp_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("You are about to delete," +
                $"\n\nEmployeeID: {empoyeesInfo[10]}" +
                $"\nEmployee Name: {empoyeesInfo[9]}" +
                "\r\n\nClick Yes to permanently delete these rows. You wont be able\r\nto undo those changes,", "Grifindo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (diaResult == DialogResult.Yes)
            {
                using SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand($"DELETE FROM EpmloyeeInformation WHERE EmployeeID = '{empoyeesInfo[10]}'", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }



        }

        private void button_update_employee_Click(object sender, EventArgs e)
        {
            TextBox[] entryArray = { textBox_name, textBox_email, textBox_phone_number, textBox_nic, textBox_address };
            NumericUpDown[] numBoxArray = { numericUpDown_monthly_salary, numericUpDown_overttime_rates_hourly, numericUpDown_allowances };



            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";


            if (married.Checked)
                marital_status = "Married";
            else if (unmarried.Checked)
                marital_status = "Unmarried";


            ArrayList empArray = GetEntryInputs(entryArray, numBoxArray, gender, marital_status);
            UpdateTheEmployeeInformations(empArray, empoyeesInfo[10]);
            EntryCleaning(entryArray, numBoxArray);
        }

        private void radioButton_male_Click(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton_female_Click(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton_married_Click(object sender, EventArgs e)
        {
            marital_status = "Married";
        }

        private void radioButton_unmarried_Click(object sender, EventArgs e)
        {
            marital_status = "Unmarried";
        }

        private void button_salary_gen_Click(object sender, EventArgs e)
        {
            call_salary();
            employee_info(empoyeesInfo);
        }
    }
}
