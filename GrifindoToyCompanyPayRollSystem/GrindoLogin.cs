using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;


namespace GrifindoToyCompanyPayRollSystem
{
    public partial class GrindoLogin : Form
    {

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        
        public GrindoLogin()
        {
            InitializeComponent();
        }

        private void GrindoLogin_Load(object sender, EventArgs e)
        {
            /* set Radius to the window */
            setRadius(this, 10);
        }

        private void button_login_Click(object sender, EventArgs e)
        {

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


        /* Moveable Window */
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            setRadius(panel2, 20);
        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }


        /* Key down event for window close */
        private void button_close_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        /* Login Button Click Event */
        private void button_login_Click_1(object sender, EventArgs e)
        {
            loginUser();
        }

        /* Login Button Key Down Event for Enter */
        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginUser();
        }

        /* Login User to Database */
        private void loginUser()
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM AdminTable WHERE username = '{textBox_username.Text}' AND password = '{textBox_password.Text}';", conn);

            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(ds);

            conn.Close();

            bool IsloginSuccess = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            if (IsloginSuccess)
            {
                this.Hide();
                GrifindoMainWindow grifindoMainWindow = new GrifindoMainWindow();
                grifindoMainWindow.Show();
                
            } else
            {
                label_error.Text = "The Username or Password Incorrect";
            }

        }

        /* calling login user */
        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                loginUser();
        }


        /* Cryptography to decrypt and Encrypt the password */
        private static byte[] encrypt_string_to_byte(string plainText, byte[] key, byte[] iv)
        {
            byte[] encrypted_text;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        encrypted_text = memoryStream.ToArray();
                    }
                }
            }

            return encrypted_text;
        }

        private static string decrypt_string_to_byte(byte[] chihper_text, byte[] key, byte[] iv)
        {
            string decrypted_text;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream(chihper_text))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            decrypted_text = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted_text;
        }
    }
}
