namespace Presentacion.Vistas.Vistas_Principales
{
    partial class FormPerfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilAdmin));
            imagesAdmins = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblImagen = new Label();
            lblNombres = new Label();
            lblApellidos = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblEstado = new Label();
            label6 = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imagesAdmins
            // 
            imagesAdmins.ColorDepth = ColorDepth.Depth32Bit;
            imagesAdmins.ImageStream = (ImageListStreamer)resources.GetObject("imagesAdmins.ImageStream");
            imagesAdmins.TransparentColor = Color.Transparent;
            imagesAdmins.Images.SetKeyName(0, "Screenshot_43.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(820, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblImagen);
            panel1.Controls.Add(lblNombres);
            panel1.Controls.Add(lblApellidos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblUsuario);
            panel1.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 700);
            panel1.TabIndex = 32;
            // 
            // lblImagen
            // 
            lblImagen.ImageList = imagesAdmins;
            lblImagen.Location = new Point(55, 68);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(150, 150);
            lblImagen.TabIndex = 12;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Sitka Display", 15F);
            lblNombres.ForeColor = Color.White;
            lblNombres.Location = new Point(35, 408);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(61, 29);
            lblNombres.TabIndex = 27;
            lblNombres.Text = "label2";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Sitka Display", 15F);
            lblApellidos.ForeColor = Color.White;
            lblApellidos.Location = new Point(35, 516);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(61, 29);
            lblApellidos.TabIndex = 26;
            lblApellidos.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 456);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 25;
            label5.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 361);
            label4.Name = "label4";
            label4.Size = new Size(89, 29);
            label4.TabIndex = 24;
            label4.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 566);
            label3.Name = "label3";
            label3.Size = new Size(71, 29);
            label3.TabIndex = 23;
            label3.Text = "Estado";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Sitka Display", 15F);
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(35, 618);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(61, 29);
            lblEstado.TabIndex = 22;
            lblEstado.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(35, 272);
            label6.Name = "label6";
            label6.Size = new Size(79, 29);
            label6.TabIndex = 20;
            label6.Text = "Usuario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Sitka Display", 15F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(35, 312);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(61, 29);
            lblUsuario.TabIndex = 19;
            lblUsuario.Text = "label2";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(202, 198, 194);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 20.25F);
            label2.Location = new Point(570, 201);
            label2.Name = "label2";
            label2.Size = new Size(235, 31);
            label2.TabIndex = 36;
            label2.Text = "ADMINISTRADOR";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(202, 198, 194);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 36F);
            label1.Location = new Point(363, 113);
            label1.Name = "label1";
            label1.Size = new Size(324, 57);
            label1.TabIndex = 35;
            label1.Text = "BIENVENIDO";
            // 
            // FormPerfilAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1094, 701);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPerfilAdmin";
            Text = "FormPerfilAdmin";
            Load += FormPerfilAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imagesAdmins;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblImagen;
        private Label label6;
        private Label lblUsuario;
        private Label lblNombres;
        private Label lblApellidos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblEstado;
        private Label label2;
        private Label label1;
    }
}