namespace Presentacion.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            picMinimizar = new PictureBox();
            pictureBox2 = new PictureBox();
            picCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            lblError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 42, 47);
            panel1.Controls.Add(picMinimizar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(picCerrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1368, 90);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // picMinimizar
            // 
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(1289, 0);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(35, 36);
            picMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picMinimizar.TabIndex = 10;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1151, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1330, 0);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(35, 36);
            picCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCerrar.TabIndex = 9;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(459, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(478, 378);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(71, 43);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 51);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Sitka Heading", 12.7499981F);
            txtUsuario.Location = new Point(13, 16);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(316, 38);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtContra
            // 
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Sitka Heading", 12.7499981F);
            txtContra.Location = new Point(10, 70);
            txtContra.Multiline = true;
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(319, 36);
            txtContra.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(600, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 97);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 144, 239);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 141);
            button1.Name = "button1";
            button1.Size = new Size(321, 38);
            button1.TabIndex = 7;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblError);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtContra);
            panel3.Location = new Point(535, 366);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 182);
            panel3.TabIndex = 8;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(13, 109);
            lblError.Name = "lblError";
            lblError.Size = new Size(223, 21);
            lblError.TabIndex = 8;
            lblError.Text = "!Usuario o Contraseña Incorrectos¡";
            lblError.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 246);
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label lblError;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
    }
}