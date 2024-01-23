using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToyCompanyPayRollSystem
{
    public partial class GrindoSignup : Form
    {

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private string grifindoDatabaseConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gajen\Desktop\GrifindoToyCompanyPayRollSystem\GrifindoToyCompanyPayRollSystem\GrifindoDatabase.mdf;Integrated Security=True";

        public GrindoSignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* Mobeable Window */
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }

        /* Radius Method */
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

        private void GrindoSignup_Load(object sender, EventArgs e)
        {
            setRadius((Control)sender, 10);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            setRadius((Control)sender, 20);
        }


        /* click event for signup button */
        private void button_signup_Click(object sender, EventArgs e)
        {
            signup_user();
        }

        /* Key down event for  sign button */
        private void button_signup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signup_user();
        }

        /* Signup User Method */
        private void signup_user()
        {
            SqlCommand cmd_AdminTable_Creation;
            SqlCommand cmd_EmployeeTable_Creation;
            SqlCommand cmd_SalaryTable_Creation;

            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            if (checkUsername(this.textBox_username.Text))
            {
                if (checkPassword(this.textBox_password.Text))
                {
                    if (this.textBox_password.Text == this.textBox_confirm_pass.Text)
                    {
                        string username = this.textBox_username.Text;
                        string password = this.textBox_password.Text;
                        string email = this.textBox_email.Text;

                        conn.Open();

                        cmd_AdminTable_Creation = new SqlCommand("CREATE TABLE AdminTable(" +
                            "username varchar(50)," +
                            "password varchar(50)," +
                            "email varchar(100)" +
                            ");", conn);
                        cmd_AdminTable_Creation.ExecuteNonQuery();

                        cmd_EmployeeTable_Creation = new SqlCommand("CREATE TABLE EmployeeInformation(" +
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
                        cmd_EmployeeTable_Creation.ExecuteNonQuery();

                        SqlCommand cmd_two = new SqlCommand($"INSERT INTO AdminTable (username, password, email) VALUES ('{username} ', '{password} ', '{email}');", conn);
                        cmd_two.ExecuteNonQuery();

                        conn.Close();

                        this.Hide();
                        GrindoLogin loginWindow = new GrindoLogin();
                        loginWindow.Show();

                        
                    }
                    else
                        this.label_error.Text = "Password doesn't match";
                }
                else
                    this.label_error.Text = "Password is innorrect. The passowrd should be (At least contain 4 characters )";

            }else
                this.label_error.Text = "Username is innorrect. The username should be (first letter is Lowercase, At least contain 3 letters) )";
            
        }

        /* calling close */
        private void button_close_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        /* calling signup */
        private void textBox_confirm_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signup_user();
        }

        private bool checkUsername(string username)
        {
            if (char.IsLower(username[0]) && username.Length >= 3)
                return true;
            return false;
        }

        private bool checkPassword(string pass)
        {
            if (pass.Length >= 4)
                return true;
            return false;
        }
    }
}
