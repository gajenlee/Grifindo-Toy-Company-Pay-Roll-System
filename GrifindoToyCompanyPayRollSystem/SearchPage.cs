using System;
using System.Collections;
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

using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;
using static GrifindoToyCompanyPayRollSystem.EmployeePage;
using static GrifindoToyCompanyPayRollSystem.EmployeesUpdate;


namespace GrifindoToyCompanyPayRollSystem
{
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            setRadius(this.dataGridView_search_result, 10);
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

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM EpmloyeeInformation WHERE Name LIKE '{textBox_search.Text}'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);

            dataGridView_search_result.DataSource = ds;
            conn.Close();
        }

        private void dataGridView_search_result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList EmployeeInfo = new ArrayList();

            if (e.RowIndex >= 0)
            {
                

                DataGridViewRow row = dataGridView_search_result.Rows[e.RowIndex];
                int count = row.Cells.Count-1;
                while (count >= 0)
                {
                    EmployeeInfo.Add(row.Cells[count].Value);
                    count--;
                }
            }

            call_update_page();

            /* Update the current values in the Updata Page */
            UpdateEmployeesInfo(EmployeeInfo);

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(grifindoDatabaseConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM EpmloyeeInformation WHERE Name LIKE '{textBox_search.Text}'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);

            dataGridView_search_result.DataSource = ds;
            conn.Close();
        }
    }
}
