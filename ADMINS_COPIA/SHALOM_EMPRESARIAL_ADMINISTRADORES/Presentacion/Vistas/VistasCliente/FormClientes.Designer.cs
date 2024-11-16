namespace Presentacion.Vistas.VistasCliente
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            btnVerClientes = new Button();
            btnRegistrarCliente = new Button();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnVerClientes
            // 
            btnVerClientes.BackColor = Color.FromArgb(229, 41, 42);
            btnVerClientes.FlatAppearance.BorderSize = 0;
            btnVerClientes.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnVerClientes.ForeColor = Color.White;
            btnVerClientes.Location = new Point(42, 118);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(204, 54);
            btnVerClientes.TabIndex = 8;
            btnVerClientes.Text = "Ver Clientes";
            btnVerClientes.UseVisualStyleBackColor = false;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.FromArgb(229, 41, 42);
            btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            btnRegistrarCliente.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnRegistrarCliente.ForeColor = Color.White;
            btnRegistrarCliente.Location = new Point(42, 48);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(204, 54);
            btnRegistrarCliente.TabIndex = 6;
            btnRegistrarCliente.Text = "Actualizar Clientes";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(252, 48);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(830, 641);
            panelContenedor.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 131);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 227, 232);
            ClientSize = new Size(1094, 701);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panelContenedor);
            Controls.Add(btnVerClientes);
            Controls.Add(btnRegistrarCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerClientes;
        private Button btnRegistrarCliente;
        private Panel panelContenedor;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}