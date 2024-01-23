namespace GrifindoToyCompanyPayRollSystem
{
    partial class EmployeePage
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
            panel1 = new Panel();
            panel11 = new Panel();
            employeesInsert = new EmployeesInsert();
            employeesUpdate = new EmployeesUpdate();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            panel7 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            radioButton3 = new RadioButton();
            employeesUpdate1 = new EmployeesUpdate();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(employeesUpdate1);
            panel1.Controls.Add(panel11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(920, 765);
            panel1.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(employeesInsert);
            panel11.Controls.Add(employeesUpdate);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(20, 20);
            panel11.Name = "panel11";
            panel11.Size = new Size(880, 725);
            panel11.TabIndex = 3;
            // 
            // employeesInsert
            // 
            employeesInsert.Dock = DockStyle.Fill;
            employeesInsert.Location = new Point(0, 0);
            employeesInsert.Name = "employeesInsert";
            employeesInsert.Size = new Size(880, 725);
            employeesInsert.TabIndex = 1;
            // 
            // employeesUpdate
            // 
            employeesUpdate.Dock = DockStyle.Fill;
            employeesUpdate.Location = new Point(0, 0);
            employeesUpdate.Name = "employeesUpdate";
            employeesUpdate.Size = new Size(880, 725);
            employeesUpdate.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Full Time";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 41);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Job Title or Position";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5917168F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4082832F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel6.Controls.Add(radioButton3, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(1, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Part Time";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // employeesUpdate1
            // 
            employeesUpdate1.Dock = DockStyle.Fill;
            employeesUpdate1.Location = new Point(20, 20);
            employeesUpdate1.Name = "employeesUpdate1";
            employeesUpdate1.Size = new Size(880, 725);
            employeesUpdate1.TabIndex = 2;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EmployeePage";
            Size = new Size(920, 765);
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton radioButton3;
        private Panel panel11;
        private EmployeesInsert employeesInsert;
        private EmployeesUpdate employeesUpdate;
        private EmployeesUpdate employeesUpdate1;
    }
}
