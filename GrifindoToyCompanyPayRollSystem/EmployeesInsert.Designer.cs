namespace GrifindoToyCompanyPayRollSystem
{
    partial class EmployeesInsert
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_personal = new GroupBox();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox_address = new TextBox();
            groupBox_marital = new GroupBox();
            radioButton_unmarried = new RadioButton();
            radioButton_married = new RadioButton();
            textBox_nic = new TextBox();
            groupBox_gender = new GroupBox();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            textBox_name = new TextBox();
            textBox_email = new TextBox();
            textBox_phone_number = new TextBox();
            groupBox1 = new GroupBox();
            numericUpDown_allowances = new NumericUpDown();
            numericUpDown_overttime_rates_hourly = new NumericUpDown();
            numericUpDown_monthly_salary = new NumericUpDown();
            label_allowances = new Label();
            label_overtime_rates_hourly = new Label();
            label_monthly_salary = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            button_insert_employees = new Button();
            button_clear_entrys = new Button();
            groupBox_personal.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            groupBox_marital.SuspendLayout();
            groupBox_gender.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_allowances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_overttime_rates_hourly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_monthly_salary).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_personal
            // 
            groupBox_personal.Controls.Add(panel4);
            groupBox_personal.Controls.Add(groupBox1);
            groupBox_personal.Controls.Add(panel3);
            groupBox_personal.Controls.Add(panel2);
            groupBox_personal.Dock = DockStyle.Fill;
            groupBox_personal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_personal.Location = new Point(0, 0);
            groupBox_personal.Name = "groupBox_personal";
            groupBox_personal.Size = new Size(905, 572);
            groupBox_personal.TabIndex = 1;
            groupBox_personal.TabStop = false;
            groupBox_personal.Text = "Personal ";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(48, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 242);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_address);
            panel5.Controls.Add(groupBox_marital);
            panel5.Controls.Add(textBox_nic);
            panel5.Controls.Add(groupBox_gender);
            panel5.Controls.Add(textBox_name);
            panel5.Controls.Add(textBox_email);
            panel5.Controls.Add(textBox_phone_number);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(100, 0, 0, 0);
            panel5.Size = new Size(781, 242);
            panel5.TabIndex = 1;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(14, 176);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.PlaceholderText = "Address";
            textBox_address.Size = new Size(487, 51);
            textBox_address.TabIndex = 100;
            // 
            // groupBox_marital
            // 
            groupBox_marital.Controls.Add(radioButton_unmarried);
            groupBox_marital.Controls.Add(radioButton_married);
            groupBox_marital.Location = new Point(526, 112);
            groupBox_marital.Name = "groupBox_marital";
            groupBox_marital.Size = new Size(247, 86);
            groupBox_marital.TabIndex = 27;
            groupBox_marital.TabStop = false;
            groupBox_marital.Text = "Marital Status";
            // 
            // radioButton_unmarried
            // 
            radioButton_unmarried.AutoSize = true;
            radioButton_unmarried.Checked = true;
            radioButton_unmarried.Location = new Point(126, 32);
            radioButton_unmarried.Name = "radioButton_unmarried";
            radioButton_unmarried.Size = new Size(101, 24);
            radioButton_unmarried.TabIndex = 23;
            radioButton_unmarried.TabStop = true;
            radioButton_unmarried.Text = "Unmarried";
            radioButton_unmarried.UseVisualStyleBackColor = true;
            radioButton_unmarried.CheckedChanged += radioButton_unmarried_CheckedChanged;
            // 
            // radioButton_married
            // 
            radioButton_married.AutoSize = true;
            radioButton_married.Location = new Point(13, 32);
            radioButton_married.Name = "radioButton_married";
            radioButton_married.Size = new Size(82, 24);
            radioButton_married.TabIndex = 22;
            radioButton_married.Text = "Married";
            radioButton_married.UseVisualStyleBackColor = true;
            radioButton_married.CheckedChanged += radioButton_married_CheckedChanged;
            // 
            // textBox_nic
            // 
            textBox_nic.Location = new Point(14, 131);
            textBox_nic.Name = "textBox_nic";
            textBox_nic.PlaceholderText = "NIC";
            textBox_nic.Size = new Size(487, 27);
            textBox_nic.TabIndex = 14;
            // 
            // groupBox_gender
            // 
            groupBox_gender.Controls.Add(radioButton_male);
            groupBox_gender.Controls.Add(radioButton_female);
            groupBox_gender.Location = new Point(526, 6);
            groupBox_gender.Name = "groupBox_gender";
            groupBox_gender.Size = new Size(247, 86);
            groupBox_gender.TabIndex = 26;
            groupBox_gender.TabStop = false;
            groupBox_gender.Text = "Gender";
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Location = new Point(15, 38);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(61, 24);
            radioButton_male.TabIndex = 17;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            radioButton_male.CheckedChanged += radioButton_male_CheckedChanged;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(94, 38);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(76, 24);
            radioButton_female.TabIndex = 18;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            radioButton_female.CheckedChanged += radioButton_female_CheckedChanged;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(14, 6);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "Name";
            textBox_name.Size = new Size(487, 27);
            textBox_name.TabIndex = 11;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(14, 44);
            textBox_email.Name = "textBox_email";
            textBox_email.PlaceholderText = "Email";
            textBox_email.Size = new Size(487, 27);
            textBox_email.TabIndex = 12;
            // 
            // textBox_phone_number
            // 
            textBox_phone_number.Location = new Point(14, 86);
            textBox_phone_number.Name = "textBox_phone_number";
            textBox_phone_number.PlaceholderText = "Phone Number";
            textBox_phone_number.Size = new Size(487, 27);
            textBox_phone_number.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown_allowances);
            groupBox1.Controls.Add(numericUpDown_overttime_rates_hourly);
            groupBox1.Controls.Add(numericUpDown_monthly_salary);
            groupBox1.Controls.Add(label_allowances);
            groupBox1.Controls.Add(label_overtime_rates_hourly);
            groupBox1.Controls.Add(label_monthly_salary);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 200);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Offical ";
            // 
            // numericUpDown_allowances
            // 
            numericUpDown_allowances.DecimalPlaces = 2;
            numericUpDown_allowances.Location = new Point(304, 139);
            numericUpDown_allowances.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown_allowances.Name = "numericUpDown_allowances";
            numericUpDown_allowances.Size = new Size(447, 27);
            numericUpDown_allowances.TabIndex = 8;
            numericUpDown_allowances.ThousandsSeparator = true;
            // 
            // numericUpDown_overttime_rates_hourly
            // 
            numericUpDown_overttime_rates_hourly.DecimalPlaces = 2;
            numericUpDown_overttime_rates_hourly.Location = new Point(304, 94);
            numericUpDown_overttime_rates_hourly.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown_overttime_rates_hourly.Name = "numericUpDown_overttime_rates_hourly";
            numericUpDown_overttime_rates_hourly.Size = new Size(447, 27);
            numericUpDown_overttime_rates_hourly.TabIndex = 7;
            numericUpDown_overttime_rates_hourly.ThousandsSeparator = true;
            // 
            // numericUpDown_monthly_salary
            // 
            numericUpDown_monthly_salary.DecimalPlaces = 2;
            numericUpDown_monthly_salary.Location = new Point(304, 47);
            numericUpDown_monthly_salary.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown_monthly_salary.Name = "numericUpDown_monthly_salary";
            numericUpDown_monthly_salary.Size = new Size(447, 27);
            numericUpDown_monthly_salary.TabIndex = 6;
            numericUpDown_monthly_salary.ThousandsSeparator = true;
            // 
            // label_allowances
            // 
            label_allowances.AutoSize = true;
            label_allowances.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_allowances.Location = new Point(70, 146);
            label_allowances.Name = "label_allowances";
            label_allowances.Size = new Size(85, 20);
            label_allowances.TabIndex = 2;
            label_allowances.Text = "Allowances";
            // 
            // label_overtime_rates_hourly
            // 
            label_overtime_rates_hourly.AutoSize = true;
            label_overtime_rates_hourly.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_overtime_rates_hourly.Location = new Point(70, 101);
            label_overtime_rates_hourly.Name = "label_overtime_rates_hourly";
            label_overtime_rates_hourly.Size = new Size(160, 20);
            label_overtime_rates_hourly.TabIndex = 1;
            label_overtime_rates_hourly.Text = "Overtime rates-hourly";
            // 
            // label_monthly_salary
            // 
            label_monthly_salary.AutoSize = true;
            label_monthly_salary.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_monthly_salary.Location = new Point(70, 54);
            label_monthly_salary.Name = "label_monthly_salary";
            label_monthly_salary.Size = new Size(112, 20);
            label_monthly_salary.TabIndex = 0;
            label_monthly_salary.Text = "Monthly salary";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(885, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 546);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 546);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 513);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 59);
            panel1.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(button_insert_employees);
            panel6.Controls.Add(button_clear_entrys);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(546, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 59);
            panel6.TabIndex = 2;
            // 
            // button_insert_employees
            // 
            button_insert_employees.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_insert_employees.Location = new Point(29, 11);
            button_insert_employees.Name = "button_insert_employees";
            button_insert_employees.Size = new Size(147, 39);
            button_insert_employees.TabIndex = 0;
            button_insert_employees.Text = "Insert";
            button_insert_employees.UseVisualStyleBackColor = true;
            button_insert_employees.Click += button_insert_employees_Click;
            // 
            // button_clear_entrys
            // 
            button_clear_entrys.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_clear_entrys.Location = new Point(191, 11);
            button_clear_entrys.Name = "button_clear_entrys";
            button_clear_entrys.Size = new Size(143, 39);
            button_clear_entrys.TabIndex = 1;
            button_clear_entrys.Text = "Clear";
            button_clear_entrys.UseVisualStyleBackColor = true;
            button_clear_entrys.Click += button_clear_entrys_Click;
            // 
            // EmployeesInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox_personal);
            Name = "EmployeesInsert";
            Size = new Size(905, 572);
            groupBox_personal.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox_marital.ResumeLayout(false);
            groupBox_marital.PerformLayout();
            groupBox_gender.ResumeLayout(false);
            groupBox_gender.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_allowances).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_overttime_rates_hourly).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_monthly_salary).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_personal;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox_address;
        private GroupBox groupBox_marital;
        private RadioButton radioButton_unmarried;
        private RadioButton radioButton_married;
        private TextBox textBox_nic;
        private GroupBox groupBox_gender;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private TextBox textBox_name;
        private TextBox textBox_email;
        private TextBox textBox_phone_number;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label_allowances;
        private Label label_overtime_rates_hourly;
        private Label label_monthly_salary;
        private Panel panel1;
        private Panel panel6;
        private Button button_insert_employees;
        private Button button_clear_entrys;
        private NumericUpDown numericUpDown_allowances;
        private NumericUpDown numericUpDown_overttime_rates_hourly;
        private NumericUpDown numericUpDown_monthly_salary;
    }
}
