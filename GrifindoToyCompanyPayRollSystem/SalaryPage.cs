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

using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;
using static GrifindoToyCompanyPayRollSystem.GrifindoMainWindow;
using static GrifindoToyCompanyPayRollSystem.SettingPage;
using static GrifindoToyCompanyPayRollSystem.SettingPage;

namespace GrifindoToyCompanyPayRollSystem
{
    public partial class SalaryPage : UserControl
    {

        static Label label_emp_name;
        static ArrayList arrayObj = new ArrayList();
        static bool proceess = false;


        public SalaryPage()
        {
            InitializeComponent();
            label_emp_name = label_name_of_emp;
        }

        private void SalaryPage_Load(object sender, EventArgs e)
        {

        }

        internal static void employee_info(ArrayList obj)
        {
            arrayObj = obj;
            proceess = true;

            label_emp_name.Text = "Employee Name: " + arrayObj[9].ToString();
        }

        private void button_update_generate_salary_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeSalary( EmployeeId, EmployeeName, TotalNoPayValue, BAsePayValue, GrossPay ) " +
                $"VALUES ({arrayObj[10]}, {arrayObj[9]}, {noPayValue()}, {basePayValue()}, {grossPayValue()})", conn);

            conn.Close();

            label_salary_display.Text = $"No Pay Value: {noPayValue()}\nBass Pay Value: {basePayValue()}\nGross Pay Value: {grossPayValue()}";
        }

        private double noPayValue()
        {

            /*
             * No - pay - value = (Total_Salary / salary_cycle_date_range) * No_of_absent_days
             */
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;

            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM EmployeeSetting", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);



            double noPayValue = 0;
            decimal leavesForMonth = Decimal.Round(numericUpDown_no_of_leaves_st.Value / 12);
            decimal days = numericUpDown_date_range_st.Value;
            decimal salary = Convert.ToDecimal(arrayObj[2]);
            decimal absent = numericUpDown_no_of_absent_day.Value;
            decimal hollday = numericUpDown_no_of_holiday_st.Value;

            conn.Close();


            
            if ((absent - leavesForMonth) > 0)
            {
                noPayValue = Convert.ToDouble((salary / (days - hollday)) * (absent - leavesForMonth));
                return noPayValue;
            }
            else
            {
                return noPayValue;
            }


        }

        private double basePayValue()
        {
            /* 
             * Base Pay value = Monthly_Salary + Allowances + (Over_time_rate*no_of_overtime_hours) 
             */

            double salary = Convert.ToDouble(arrayObj[2]);
            double allowances = Convert.ToDouble(arrayObj[0]);
            double overTimeValue = Convert.ToDouble(Convert.ToDecimal(arrayObj[1]) * numericUpDown_no_of_overtime_hours.Value);

            double bassSalary = salary + allowances + overTimeValue;

            return bassSalary;

        }

        private double grossPayValue()
        {
            /*
             * Gross Pay = Base_Pay_value – (No_pay_value + Base_Pay_value*government_tax_rate)
             */

            double bassSalary = Convert.ToDouble(basePayValue());
            double noPay = noPayValue();
            double gov_txt = Convert.ToDouble(numericUpDown_gov_tax_rate.Value);

            double GrossPay = bassSalary - (noPay + bassSalary + gov_txt);

            return GrossPay;
        }
    }
}
