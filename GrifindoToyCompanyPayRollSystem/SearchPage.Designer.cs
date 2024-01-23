namespace GrifindoToyCompanyPayRollSystem
{
    partial class SearchPage
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
            panel2 = new Panel();
            textBox_search = new TextBox();
            panel3 = new Panel();
            button_search = new Button();
            panel_result = new Panel();
            dataGridView_search_result = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_search_result).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 133);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_search);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 50, 0, 50);
            panel2.Size = new Size(621, 133);
            panel2.TabIndex = 4;
            // 
            // textBox_search
            // 
            textBox_search.Dock = DockStyle.Fill;
            textBox_search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_search.Location = new Point(10, 50);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(611, 33);
            textBox_search.TabIndex = 3;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_search);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(621, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 50, 10, 48);
            panel3.Size = new Size(200, 133);
            panel3.TabIndex = 2;
            // 
            // button_search
            // 
            button_search.Dock = DockStyle.Fill;
            button_search.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_search.Location = new Point(10, 50);
            button_search.Name = "button_search";
            button_search.Size = new Size(180, 35);
            button_search.TabIndex = 0;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // panel_result
            // 
            panel_result.Controls.Add(dataGridView_search_result);
            panel_result.Dock = DockStyle.Fill;
            panel_result.Location = new Point(0, 133);
            panel_result.Name = "panel_result";
            panel_result.Padding = new Padding(20);
            panel_result.Size = new Size(821, 441);
            panel_result.TabIndex = 3;
            // 
            // dataGridView_search_result
            // 
            dataGridView_search_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_search_result.Dock = DockStyle.Fill;
            dataGridView_search_result.Location = new Point(20, 20);
            dataGridView_search_result.Name = "dataGridView_search_result";
            dataGridView_search_result.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView_search_result.RowTemplate.Height = 25;
            dataGridView_search_result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_search_result.Size = new Size(781, 401);
            dataGridView_search_result.TabIndex = 0;
            dataGridView_search_result.CellClick += dataGridView_search_result_CellClick;
            dataGridView_search_result.Paint += dataGridView1_Paint;
            // 
            // SearchPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_result);
            Controls.Add(panel1);
            Name = "SearchPage";
            Size = new Size(821, 574);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_search_result).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel_result;
        private Panel panel3;
        private TextBox textBox_search;
        private Button button_search;
        private Panel panel2;
        private DataGridView dataGridView_search_result;
    }
}
