using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using GrifindoToyCompanyPayRollSystem.Properties;
using System.Data.SqlClient;
using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;


namespace GrifindoToyCompanyPayRollSystem
{
    public partial class SettingPage : UserControl
    {

        private int admin_setting_panel_fixed_width = 10;
        private int admin_setting_panel_extended_width = 366;

        internal static NumericUpDown numericUpDown_date_range_st;
        internal static DateTimePicker dateTimePicker_salary_begin_date_st;
        internal static DateTimePicker dateTimePicker_salary_end_date_st;
        internal static NumericUpDown numericUpDown_no_of_leaves_st;
        internal static NumericUpDown numericUpDown_no_of_holiday_st;

        public SettingPage()
        {
            InitializeComponent();
            hiAdminFunction();

            numericUpDown_date_range_st = numericUpDown_date_range;
            dateTimePicker_salary_begin_date = dateTimePicker_salary_begin_date;
            dateTimePicker_salary_end_date_st = dateTimePicker_salary_end_date;
            numericUpDown_no_of_leaves = numericUpDown_no_of_leaves;
            numericUpDown_no_of_holiday = numericUpDown_no_of_holiday;
        }

        private void pictureBox_adminuser_icon_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox_adminuser_icon.Image = Resources.icons8_user__1_;
            this.pictureBox_adminuser_icon.BackColor = Color.FromArgb(195, 195, 195);
        }

        private void pictureBox_adminuser_icon_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox_adminuser_icon.BackColor = Color.FromArgb(240, 240, 240);
        }


        /* Radius Methods */
        private void setRadius(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Create rounded rectangle path
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(control.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(control.Width - radius * 2, control.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, control.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();

            // Set the form's region to the rounded rectangle path
            control.Region = new Region(path);
        }

        private void pictureBox_adminuser_icon_Paint(object sender, PaintEventArgs e)
        {
            setRadius(this.pictureBox_adminuser_icon, 10);
        }

        private void panel_side_user_setting_Paint(object sender, PaintEventArgs e)
        {
            setRadius(this.panel_side_user_setting, 10);
        }

        private void pictureBox_adminuser_icon_Click(object sender, EventArgs e)
        {

            int value = 0;

            if (this.panel_side_for_admin_setting.Width == admin_setting_panel_fixed_width)
                value = admin_setting_panel_extended_width;

            else
            {
                this.pictureBox_adminuser_icon.Image = Resources.icons8_user_48;
                value = admin_setting_panel_fixed_width;
            }

            this.panel_side_for_admin_setting.Width = value;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM AdminTable WHERE password = '{textBox_current_password.Text}';", conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);

            bool isPasswordCurrect = ((data.Tables.Count > 0) && (data.Tables[0].Rows.Count > 0));
            if (isPasswordCurrect)
            {
                if (textBox_username.Text != "" && textBox_email.Text != "" && textBox_new_password.Text != "")
                {
                    if (textBox_username.Text != "")
                    {
                        SqlCommand username_cmd = new SqlCommand($"UPDATE AdminTable SET username = '{textBox_username.Text}' WHERE password = {textBox_current_password.Text}", conn);
                        username_cmd.ExecuteNonQuery();
                    }

                    if (textBox_email.Text != "")
                    {
                        SqlCommand email_cmd = new SqlCommand($"UPDATE AdminTable SET email = '{textBox_email.Text}' WHERE password = {textBox_current_password.Text}", conn);
                        email_cmd.ExecuteNonQuery();
                    }

                    if (textBox_new_password.Text != "")
                    {
                        SqlCommand pass_cmd = new SqlCommand($"UPDATE AdminTable SET password = '{textBox_new_password.Text}' WHERE password = {textBox_current_password.Text}", conn);
                        pass_cmd.ExecuteNonQuery();
                    }

                    textBox_current_password.Clear();
                    textBox_email.Clear();
                    textBox_username.Clear();
                    textBox_new_password.Clear();

                }
                else
                    MessageBox.Show("At least one must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                MessageBox.Show("Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            conn.Close();

        }

        private void button_setting_clear_Click(object sender, EventArgs e)
        {
            textBox_current_password.Clear();
            textBox_email.Clear();
            textBox_username.Clear();
            textBox_new_password.Clear();
        }

        private void hiAdminFunction()
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT username FROM AdminTable", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string username = reader.GetString("username");

                label_admin_name.Text = username;

            }

            conn.Close();
        }

        private void dateTimePicker_salary_end_date_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker_salary_end_date.Value - dateTimePicker_salary_begin_date.Value;
            numericUpDown_date_range.Value = Convert.ToDecimal(ts.Days);
        }

        private void dateTimePicker_salary_begin_date_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker_salary_end_date.Value - dateTimePicker_salary_begin_date.Value;
            numericUpDown_date_range.Value = Convert.ToDecimal(ts.Days);
        }

        private void button_save_salary_settings_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeSetting (DateRange, SalaryCycleBegin, SalaryCycleEnd, NumberOfLeaves, NumberOfHolidays) " +
                $"VALUES ( {Convert.ToInt32(numericUpDown_date_range.Value)}, " +
                $"{Convert.ToDateTime(dateTimePicker_salary_begin_date.Value)}, " +
                $"{Convert.ToDateTime(dateTimePicker_salary_end_date.Value)}, {Convert.ToInt32(numericUpDown_no_of_leaves.Value)}, {Convert.ToInt32(numericUpDown_no_of_holiday.Value)} )", conn);
            cmd.ExecuteNonQuery();


            conn.Close();
        }
    }
}
