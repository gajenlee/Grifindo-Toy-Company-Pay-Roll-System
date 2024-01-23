using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;
using System.Web;
using System.Collections;
using System.Threading;

namespace GrifindoToyCompanyPayRollSystem
{
    public partial class EmployeesInsert : UserControl
    {

        private string gender;
        private string maritalStatus;
        

        public EmployeesInsert()
        {
            InitializeComponent();
        }

        /* Insert the employees */
        private void button_insert_employees_Click(object sender, EventArgs e)
        {

            TextBox[] entryArray = { textBox_name, textBox_email, textBox_phone_number, textBox_nic, textBox_address };
            NumericUpDown[] numBoxArray = { numericUpDown_monthly_salary, numericUpDown_overttime_rates_hourly, numericUpDown_allowances };

            if (radioButton_male.Checked)
                gender = "Male";
            else if (radioButton_female.Checked)
                gender = "Female";


            if (radioButton_married.Checked)
                maritalStatus = "Married";
            else if (radioButton_unmarried.Checked)
                maritalStatus = "Unmarried";

            ArrayList empArray = GetEntryInputs(entryArray, numBoxArray, gender, maritalStatus);
            StoreTheEmployeeInformations(empArray);
            EntryCleaning(entryArray, numBoxArray);
            

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton_married_CheckedChanged(object sender, EventArgs e)
        {
            maritalStatus = "Married";
        }

        private void radioButton_unmarried_CheckedChanged(object sender, EventArgs e)
        {
            maritalStatus = "Unmarried";
        }

        private void button_clear_entrys_Click(object sender, EventArgs e)
        {
            TextBox[] entryArray = { textBox_name, textBox_email, textBox_phone_number, textBox_nic, textBox_address };
            NumericUpDown[] numBoxArray = { numericUpDown_monthly_salary, numericUpDown_overttime_rates_hourly, numericUpDown_allowances };
            EntryCleaning(entryArray, numBoxArray);
        }
    }
}
