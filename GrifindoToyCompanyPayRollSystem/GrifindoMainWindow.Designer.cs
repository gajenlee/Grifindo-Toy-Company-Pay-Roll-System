namespace GrifindoToyCompanyPayRollSystem
{
    partial class GrifindoMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrifindoMainWindow));
            panel_left = new Panel();
            panel_center = new Panel();
            panel3 = new Panel();
            button_search = new Button();
            panel1 = new Panel();
            button_employee = new Button();
            panel_blow_btns = new Panel();
            button_setting = new Button();
            panel_top_btns = new Panel();
            button1 = new Button();
            panel_status_bar = new Panel();
            panel_main = new Panel();
            searchPage1 = new SearchPage();
            salaryPage1 = new SalaryPage();
            employeePage1 = new EmployeePage();
            settingPage1 = new SettingPage();
            panel_left.SuspendLayout();
            panel_center.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel_blow_btns.SuspendLayout();
            panel_top_btns.SuspendLayout();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(195, 195, 195);
            panel_left.Controls.Add(panel_center);
            panel_left.Controls.Add(panel_blow_btns);
            panel_left.Controls.Add(panel_top_btns);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(76, 689);
            panel_left.TabIndex = 0;
            // 
            // panel_center
            // 
            panel_center.Controls.Add(panel3);
            panel_center.Controls.Add(panel1);
            panel_center.Dock = DockStyle.Fill;
            panel_center.Location = new Point(0, 75);
            panel_center.Name = "panel_center";
            panel_center.Size = new Size(76, 514);
            panel_center.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_search);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 56);
            panel3.TabIndex = 2;
            // 
            // button_search
            // 
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_search.Image = Properties.Resources.Search48;
            button_search.ImageAlign = ContentAlignment.MiddleLeft;
            button_search.Location = new Point(0, 0);
            button_search.Name = "button_search";
            button_search.Padding = new Padding(10, 0, 50, 0);
            button_search.Size = new Size(200, 56);
            button_search.TabIndex = 1;
            button_search.Text = "Search";
            button_search.TextAlign = ContentAlignment.MiddleRight;
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_employee);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 56);
            panel1.TabIndex = 0;
            // 
            // button_employee
            // 
            button_employee.FlatAppearance.BorderSize = 0;
            button_employee.FlatStyle = FlatStyle.Flat;
            button_employee.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_employee.Image = Properties.Resources.MySpace48;
            button_employee.ImageAlign = ContentAlignment.MiddleLeft;
            button_employee.Location = new Point(0, 0);
            button_employee.Name = "button_employee";
            button_employee.Padding = new Padding(10, 0, 20, 0);
            button_employee.Size = new Size(200, 56);
            button_employee.TabIndex = 0;
            button_employee.Text = "Employee";
            button_employee.TextAlign = ContentAlignment.MiddleRight;
            button_employee.UseVisualStyleBackColor = true;
            button_employee.Click += button_employee_Click;
            // 
            // panel_blow_btns
            // 
            panel_blow_btns.Controls.Add(button_setting);
            panel_blow_btns.Dock = DockStyle.Bottom;
            panel_blow_btns.Location = new Point(0, 589);
            panel_blow_btns.Name = "panel_blow_btns";
            panel_blow_btns.Size = new Size(76, 100);
            panel_blow_btns.TabIndex = 1;
            // 
            // button_setting
            // 
            button_setting.FlatAppearance.BorderSize = 0;
            button_setting.FlatStyle = FlatStyle.Flat;
            button_setting.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_setting.Image = Properties.Resources.Settings48;
            button_setting.ImageAlign = ContentAlignment.MiddleLeft;
            button_setting.Location = new Point(0, 32);
            button_setting.Name = "button_setting";
            button_setting.Padding = new Padding(10, 0, 50, 0);
            button_setting.Size = new Size(200, 56);
            button_setting.TabIndex = 2;
            button_setting.Text = "Setting";
            button_setting.TextAlign = ContentAlignment.MiddleRight;
            button_setting.UseVisualStyleBackColor = true;
            button_setting.Click += button_setting_Click;
            // 
            // panel_top_btns
            // 
            panel_top_btns.Controls.Add(button1);
            panel_top_btns.Dock = DockStyle.Top;
            panel_top_btns.Location = new Point(0, 0);
            panel_top_btns.Name = "panel_top_btns";
            panel_top_btns.Size = new Size(76, 75);
            panel_top_btns.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.Menu48;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 12);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(200, 57);
            button1.TabIndex = 0;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel_status_bar
            // 
            panel_status_bar.BackColor = Color.WhiteSmoke;
            panel_status_bar.Dock = DockStyle.Bottom;
            panel_status_bar.Location = new Point(76, 664);
            panel_status_bar.Name = "panel_status_bar";
            panel_status_bar.Size = new Size(1052, 25);
            panel_status_bar.TabIndex = 1;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.FromArgb(243, 243, 243);
            panel_main.Controls.Add(searchPage1);
            panel_main.Controls.Add(salaryPage1);
            panel_main.Controls.Add(employeePage1);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(76, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1052, 664);
            panel_main.TabIndex = 2;
            // 
            // searchPage1
            // 
            searchPage1.Dock = DockStyle.Fill;
            searchPage1.Location = new Point(0, 0);
            searchPage1.Name = "searchPage1";
            searchPage1.Size = new Size(1052, 664);
            searchPage1.TabIndex = 3;
            // 
            // salaryPage1
            // 
            salaryPage1.Dock = DockStyle.Fill;
            salaryPage1.Location = new Point(0, 0);
            salaryPage1.Name = "salaryPage1";
            salaryPage1.Size = new Size(1052, 664);
            salaryPage1.TabIndex = 3;
            // 
            // employeePage1
            // 
            employeePage1.Dock = DockStyle.Fill;
            employeePage1.Location = new Point(0, 0);
            employeePage1.Name = "employeePage1";
            employeePage1.Size = new Size(1052, 664);
            employeePage1.TabIndex = 0;
            employeePage1.Load += employeePage1_Load;
            // 
            // settingPage1
            // 
            settingPage1.Dock = DockStyle.Fill;
            settingPage1.Location = new Point(76, 0);
            settingPage1.Name = "settingPage1";
            settingPage1.Size = new Size(1052, 664);
            settingPage1.TabIndex = 3;
            // 
            // GrifindoMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(1128, 689);
            Controls.Add(settingPage1);
            Controls.Add(panel_main);
            Controls.Add(panel_status_bar);
            Controls.Add(panel_left);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GrifindoMainWindow";
            Text = "Grifindo Toy Company";
            Load += GrifindoMainWindow_Load;
            panel_left.ResumeLayout(false);
            panel_center.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel_blow_btns.ResumeLayout(false);
            panel_top_btns.ResumeLayout(false);
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_status_bar;
        private Panel panel_main;
        private Panel panel_top_btns;
        private Panel panel_center;
        private Panel panel_blow_btns;
        private Button button1;
        private Panel panel3;
        private Button button_search;
        private Panel panel1;
        private Button button_employee;
        private Button button_setting;
        private EmployeePage employeePage1;
        private SalaryPage salaryPage1;
        private SearchPage searchPage1;
        private SettingPage settingPage1;
    }
}