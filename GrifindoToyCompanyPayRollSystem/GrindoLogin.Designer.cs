namespace GrifindoToyCompanyPayRollSystem
{
    partial class GrindoLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label_title_name = new Label();
            pictureBox_title_icon = new PictureBox();
            button_close = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox_grifindo_intro = new PictureBox();
            button_login = new Button();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            pictureBox_back_image = new PictureBox();
            label_error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_title_icon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_grifindo_intro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_back_image).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label_title_name
            // 
            label_title_name.AutoSize = true;
            label_title_name.BackColor = Color.Transparent;
            label_title_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title_name.ForeColor = Color.Transparent;
            label_title_name.Image = Properties.Resources.Hot_Glowing_Geometric_Background_HD_for_Motion_Graphics;
            label_title_name.Location = new Point(41, 0);
            label_title_name.Name = "label_title_name";
            label_title_name.Padding = new Padding(5);
            label_title_name.Size = new Size(129, 31);
            label_title_name.TabIndex = 0;
            label_title_name.Text = "Grifindo Login ";
            label_title_name.MouseDown += panel_title_MouseDown;
            label_title_name.MouseMove += pictureBox1_MouseMove;
            label_title_name.MouseUp += pictureBox1_MouseUp;
            // 
            // pictureBox_title_icon
            // 
            pictureBox_title_icon.BackColor = Color.Transparent;
            pictureBox_title_icon.BackgroundImage = Properties.Resources.Hot_Glowing_Geometric_Background_HD_for_Motion_Graphics;
            pictureBox_title_icon.Image = Properties.Resources.grifindo_high_resolution_logo_LIF_removebg_preview;
            pictureBox_title_icon.Location = new Point(0, 0);
            pictureBox_title_icon.Name = "pictureBox_title_icon";
            pictureBox_title_icon.Size = new Size(35, 31);
            pictureBox_title_icon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_title_icon.TabIndex = 2;
            pictureBox_title_icon.TabStop = false;
            pictureBox_title_icon.MouseDown += panel_title_MouseDown;
            pictureBox_title_icon.MouseMove += pictureBox1_MouseMove;
            pictureBox_title_icon.MouseUp += pictureBox1_MouseUp;
            // 
            // button_close
            // 
            button_close.BackColor = Color.Transparent;
            button_close.BackgroundImage = Properties.Resources.Hot_Glowing_Geometric_Background_HD_for_Motion_Graphics;
            button_close.FlatAppearance.BorderSize = 0;
            button_close.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_close.FlatAppearance.MouseOverBackColor = Color.Red;
            button_close.FlatStyle = FlatStyle.Flat;
            button_close.ForeColor = SystemColors.Desktop;
            button_close.Image = Properties.Resources.Close;
            button_close.Location = new Point(957, 2);
            button_close.Name = "button_close";
            button_close.Size = new Size(35, 27);
            button_close.TabIndex = 0;
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += button_close_Click;
            button_close.KeyDown += button_close_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox_title_icon);
            panel1.Controls.Add(label_title_name);
            panel1.Controls.Add(button_close);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox_back_image);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 506);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label_error);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox_grifindo_intro);
            panel2.Controls.Add(button_login);
            panel2.Controls.Add(textBox_password);
            panel2.Controls.Add(textBox_username);
            panel2.Location = new Point(475, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 383);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.Enter += button_login_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.Password;
            pictureBox5.Location = new Point(29, 277);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.How_to_Change_Username_on_Windows_11_1_750x422_removebg_preview1;
            pictureBox4.Location = new Point(29, 234);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox_grifindo_intro
            // 
            pictureBox_grifindo_intro.Image = Properties.Resources.Gr_removebg_preview;
            pictureBox_grifindo_intro.Location = new Point(141, 3);
            pictureBox_grifindo_intro.Name = "pictureBox_grifindo_intro";
            pictureBox_grifindo_intro.Size = new Size(172, 170);
            pictureBox_grifindo_intro.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_grifindo_intro.TabIndex = 3;
            pictureBox_grifindo_intro.TabStop = false;
            // 
            // button_login
            // 
            button_login.FlatAppearance.BorderSize = 0;
            button_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.Black;
            button_login.Location = new Point(29, 333);
            button_login.Name = "button_login";
            button_login.Size = new Size(388, 38);
            button_login.TabIndex = 2;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click_1;
            button_login.KeyDown += button_login_KeyDown;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.WhiteSmoke;
            textBox_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(74, 277);
            textBox_password.Name = "textBox_password";
            textBox_password.PlaceholderText = "Password";
            textBox_password.Size = new Size(343, 33);
            textBox_password.TabIndex = 1;
            textBox_password.UseSystemPasswordChar = true;
            textBox_password.KeyDown += textBox_password_KeyDown;
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.WhiteSmoke;
            textBox_username.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_username.Location = new Point(74, 234);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Username";
            textBox_username.Size = new Size(343, 33);
            textBox_username.TabIndex = 0;
            // 
            // pictureBox_back_image
            // 
            pictureBox_back_image.Dock = DockStyle.Fill;
            pictureBox_back_image.Image = Properties.Resources.Hot_Glowing_Geometric_Background_HD_for_Motion_Graphics;
            pictureBox_back_image.Location = new Point(0, 0);
            pictureBox_back_image.Name = "pictureBox_back_image";
            pictureBox_back_image.Size = new Size(992, 506);
            pictureBox_back_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_back_image.TabIndex = 0;
            pictureBox_back_image.TabStop = false;
            pictureBox_back_image.MouseDown += panel_title_MouseDown;
            pictureBox_back_image.MouseMove += pictureBox1_MouseMove;
            pictureBox_back_image.MouseUp += pictureBox1_MouseUp;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_error.ForeColor = Color.Brown;
            label_error.Location = new Point(29, 188);
            label_error.Name = "label_error";
            label_error.Size = new Size(0, 20);
            label_error.TabIndex = 6;
            // 
            // GrindoLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GrindoLogin";
            Text = "Grindo Login";
            Load += GrindoLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_title_icon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_grifindo_intro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_back_image).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Panel panel2;
        private Label label_title_name;
        private PictureBox pictureBox_title_icon;
        private Button button_close;
        private PictureBox pictureBox_grifindo_intro;
        private Button button_login;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox_back_image;
        private Label label_error;
    }
}