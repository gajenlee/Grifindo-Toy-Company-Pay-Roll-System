using System;
using System.Data.SqlClient;
using GrifindoToyCompanyPayRollSystem.Properties;
using System.Data;

using static GrifindoToyCompanyPayRollSystem.EmployeePage;


namespace GrifindoToyCompanyPayRollSystem
{
    public partial class GrifindoMainWindow : Form
    {
        private int expand_side_panel_width = 200;
        private int normal_side_panel_width = 76;

        private Tuple<int, int, int> activeColorForButtons = Tuple.Create(243, 243, 243);
        private Tuple<int, int, int> normalColorForButtons = Tuple.Create(195, 195, 195);


        static SalaryPage salary;
        static EmployeePage employee;
        static SearchPage search;
        static SettingPage setting;


        public GrifindoMainWindow()
        {
            InitializeComponent();
            employee = employeePage1;
            salary = salaryPage1;
            search = searchPage1;
            setting = settingPage1;
        }

        internal static void call_employee()
        {
            employee.Show();
            salary.Hide();
            search.Hide();
            setting.Hide();
        }

        internal static void call_salary()
        {
            employee.Hide();
            salary.Show();
            search.Hide();
            setting.Hide();
        }

        /* Initialize The Employee Page */
        private void GrifindoMainWindow_Load(object sender, EventArgs e)
        {

            employeePage1.Show();
            salaryPage1.Hide();
            settingPage1.Hide();
            searchPage1.Hide();
            changeBackColor(button_employee, otherButton: [button_setting, button_search]);
        }

        /* Menu expand function */
        private void button1_Click(object sender, EventArgs e)
        {
            int value = 0;
            if (panel_left.Width == expand_side_panel_width)
                value = normal_side_panel_width;
            else
                value = expand_side_panel_width;
            panel_left.Width = value;

        }


        /* Change the backcolor of the button after clicking */
        private void changeBackColor(Button targetButton, Button[] otherButton)
        {
            foreach (Button btn in otherButton)
            {
                btn.BackColor = Color.FromArgb(normalColorForButtons.Item1, normalColorForButtons.Item2, normalColorForButtons.Item3);
            }
            targetButton.BackColor = Color.FromArgb(activeColorForButtons.Item1, activeColorForButtons.Item2, activeColorForButtons.Item3);

        }

        /* =========== Menu Buttons =========== */
        private void button_employee_Click(object sender, EventArgs e)
        {
            changeBackColor(button_employee, otherButton: [button_setting, button_search]);
            employeePage1.Show();
            salaryPage1.Hide();
            settingPage1.Hide();
            searchPage1.Hide();

            emp_insert.Show();
            emp_update.Hide();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            changeBackColor(button_search, otherButton: [button_setting, button_employee]);
            employeePage1.Hide();
            salaryPage1.Hide();
            settingPage1.Hide();
            searchPage1.Show();
        }

        private void button_setting_Click(object sender, EventArgs e)
        {
            changeBackColor(button_setting, otherButton: [button_setting, button_search, button_employee]);
            employeePage1.Hide();
            salaryPage1.Hide();
            settingPage1.Show();
            searchPage1.Hide();
        }

        private void employeePage1_Load(object sender, EventArgs e)
        {

        }
        /* =============================== */
    }
}