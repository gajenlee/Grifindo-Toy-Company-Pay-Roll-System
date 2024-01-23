
using static GrifindoToyCompanyPayRollSystem.GrifindoMainWindow;

namespace GrifindoToyCompanyPayRollSystem
{
    public partial class EmployeePage : UserControl
    {

        internal static EmployeesInsert emp_insert;
        internal static EmployeesUpdate emp_update;

        public EmployeePage()
        {
            InitializeComponent();

            emp_insert = employeesInsert;
            emp_update = employeesUpdate1;

            employeesInsert.Show();
            employeesUpdate1.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        internal static void call_update_page()
        {
            emp_insert.Hide();
            emp_update.Show();
            call_employee();
        }

    }
}
