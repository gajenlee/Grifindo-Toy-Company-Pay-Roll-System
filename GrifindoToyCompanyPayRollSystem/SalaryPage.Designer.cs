namespace GrifindoToyCompanyPayRollSystem
{
    partial class SalaryPage
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
            groupBox1 = new GroupBox();
            label_name_of_emp = new Label();
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown_gov_tax_rate = new NumericUpDown();
            numericUpDown_no_of_overtime_hours = new NumericUpDown();
            numericUpDown_no_of_absent_day = new NumericUpDown();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            button_update_generate_salary = new Button();
            label_salary_display = new Label();
            panel5 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_gov_tax_rate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_no_of_overtime_hours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_no_of_absent_day).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_name_of_emp);
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(696, 511);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Salary Calculation";
            // 
            // label_name_of_emp
            // 
            label_name_of_emp.AutoSize = true;
            label_name_of_emp.Dock = DockStyle.Top;
            label_name_of_emp.Location = new Point(15, 41);
            label_name_of_emp.Name = "label_name_of_emp";
            label_name_of_emp.Size = new Size(153, 25);
            label_name_of_emp.TabIndex = 1;
            label_name_of_emp.Text = "Employee Name";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(15, 99);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(numericUpDown_gov_tax_rate);
            splitContainer1.Panel2.Controls.Add(numericUpDown_no_of_overtime_hours);
            splitContainer1.Panel2.Controls.Add(numericUpDown_no_of_absent_day);
            splitContainer1.Size = new Size(666, 324);
            splitContainer1.SplitterDistance = 278;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 198);
            label5.Margin = new Padding(5, 10, 5, 10);
            label5.Name = "label5";
            label5.Size = new Size(186, 25);
            label5.TabIndex = 3;
            label5.Text = "Govrnment Tax Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 155);
            label4.Margin = new Padding(5, 10, 5, 10);
            label4.Name = "label4";
            label4.Size = new Size(256, 25);
            label4.TabIndex = 2;
            label4.Text = "Number of Over-time hours ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 108);
            label3.Margin = new Padding(5, 10, 5, 10);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 1;
            label3.Text = "Number of absent days";
            // 
            // numericUpDown_gov_tax_rate
            // 
            numericUpDown_gov_tax_rate.DecimalPlaces = 2;
            numericUpDown_gov_tax_rate.Location = new Point(5, 196);
            numericUpDown_gov_tax_rate.Margin = new Padding(5, 10, 5, 10);
            numericUpDown_gov_tax_rate.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown_gov_tax_rate.Name = "numericUpDown_gov_tax_rate";
            numericUpDown_gov_tax_rate.Size = new Size(374, 33);
            numericUpDown_gov_tax_rate.TabIndex = 3;
            numericUpDown_gov_tax_rate.ThousandsSeparator = true;
            // 
            // numericUpDown_no_of_overtime_hours
            // 
            numericUpDown_no_of_overtime_hours.Location = new Point(5, 153);
            numericUpDown_no_of_overtime_hours.Margin = new Padding(5, 10, 5, 10);
            numericUpDown_no_of_overtime_hours.Name = "numericUpDown_no_of_overtime_hours";
            numericUpDown_no_of_overtime_hours.Size = new Size(374, 33);
            numericUpDown_no_of_overtime_hours.TabIndex = 2;
            numericUpDown_no_of_overtime_hours.ThousandsSeparator = true;
            // 
            // numericUpDown_no_of_absent_day
            // 
            numericUpDown_no_of_absent_day.DecimalPlaces = 2;
            numericUpDown_no_of_absent_day.Location = new Point(5, 106);
            numericUpDown_no_of_absent_day.Margin = new Padding(5, 5, 5, 8);
            numericUpDown_no_of_absent_day.Name = "numericUpDown_no_of_absent_day";
            numericUpDown_no_of_absent_day.Size = new Size(374, 33);
            numericUpDown_no_of_absent_day.TabIndex = 1;
            numericUpDown_no_of_absent_day.ThousandsSeparator = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(756, 571);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label_salary_display);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 443);
            panel6.Name = "panel6";
            panel6.Size = new Size(756, 128);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(button_update_generate_salary);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(506, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 40, 10, 40);
            panel7.Size = new Size(250, 128);
            panel7.TabIndex = 4;
            // 
            // button_update_generate_salary
            // 
            button_update_generate_salary.Dock = DockStyle.Fill;
            button_update_generate_salary.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_update_generate_salary.Location = new Point(10, 40);
            button_update_generate_salary.Name = "button_update_generate_salary";
            button_update_generate_salary.Size = new Size(230, 48);
            button_update_generate_salary.TabIndex = 2;
            button_update_generate_salary.Text = "Update and Generate";
            button_update_generate_salary.UseVisualStyleBackColor = true;
            button_update_generate_salary.Click += button_update_generate_salary_Click;
            // 
            // label_salary_display
            // 
            label_salary_display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_salary_display.AutoSize = true;
            label_salary_display.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_salary_display.Location = new Point(33, 52);
            label_salary_display.Name = "label_salary_display";
            label_salary_display.Size = new Size(399, 25);
            label_salary_display.TabIndex = 3;
            label_salary_display.Text = "Total No Pay Value, Base Pay Value, Gross Pay";
            label_salary_display.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30);
            panel5.Size = new Size(756, 571);
            panel5.TabIndex = 4;
            // 
            // SalaryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Name = "SalaryPage";
            Size = new Size(756, 571);
            Load += SalaryPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_gov_tax_rate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_no_of_overtime_hours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_no_of_absent_day).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Panel panel4;
        private Button button_update_generate_salary;
        private Label label_salary_display;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown_no_of_absent_day;
        private NumericUpDown numericUpDown_no_of_overtime_hours;
        private NumericUpDown numericUpDown_gov_tax_rate;
        private Label label_name_of_emp;
    }
}
