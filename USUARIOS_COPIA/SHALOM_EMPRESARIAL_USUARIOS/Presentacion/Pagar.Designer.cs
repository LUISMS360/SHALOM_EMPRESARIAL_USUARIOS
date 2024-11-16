namespace Presentacion
{
    partial class Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar));
            txtEnvioID = new TextBox();
            btnBuscar = new Button();
            panelPago = new Panel();
            panelMetodoPago = new Panel();
            picPlin = new PictureBox();
            picYape = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panelPagado = new Panel();
            btnAceptar = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picYape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelPagado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtEnvioID
            // 
            txtEnvioID.BorderStyle = BorderStyle.FixedSingle;
            txtEnvioID.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnvioID.Location = new Point(13, 31);
            txtEnvioID.Multiline = true;
            txtEnvioID.Name = "txtEnvioID";
            txtEnvioID.PlaceholderText = "Nro Orden Envio";
            txtEnvioID.Size = new Size(223, 40);
            txtEnvioID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Red;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(261, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(149, 39);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button2_Click;
            // 
            // panelPago
            // 
            panelPago.BackColor = Color.White;
            panelPago.Controls.Add(panelMetodoPago);
            panelPago.Controls.Add(picPlin);
            panelPago.Controls.Add(picYape);
            panelPago.Controls.Add(label2);
            panelPago.Location = new Point(478, 275);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(284, 233);
            panelPago.TabIndex = 6;
            panelPago.Visible = false;
            // 
            // panelMetodoPago
            // 
            panelMetodoPago.Location = new Point(23, 102);
            panelMetodoPago.Name = "panelMetodoPago";
            panelMetodoPago.Size = new Size(232, 118);
            panelMetodoPago.TabIndex = 3;
            // 
            // picPlin
            // 
            picPlin.Image = (Image)resources.GetObject("picPlin.Image");
            picPlin.Location = new Point(171, 50);
            picPlin.Name = "picPlin";
            picPlin.Size = new Size(84, 37);
            picPlin.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlin.TabIndex = 2;
            picPlin.TabStop = false;
            picPlin.Click += picPlin_Click;
            // 
            // picYape
            // 
            picYape.Image = (Image)resources.GetObject("picYape.Image");
            picYape.Location = new Point(25, 50);
            picYape.Name = "picYape";
            picYape.Size = new Size(89, 37);
            picYape.SizeMode = PictureBoxSizeMode.StretchImage;
            picYape.TabIndex = 1;
            picYape.TabStop = false;
            picYape.Click += picYape_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(27, 15);
            label2.Name = "label2";
            label2.Size = new Size(228, 20);
            label2.TabIndex = 0;
            label2.Text = "Seleccione el metodo de pago";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(811, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtEnvioID);
            panel1.Controls.Add(btnBuscar);
            panel1.Location = new Point(12, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 100);
            panel1.TabIndex = 9;
            // 
            // panelPagado
            // 
            panelPagado.BackColor = Color.FromArgb(255, 21, 30);
            panelPagado.Controls.Add(btnAceptar);
            panelPagado.Controls.Add(pictureBox3);
            panelPagado.Controls.Add(label1);
            panelPagado.Location = new Point(778, 301);
            panelPagado.Name = "panelPagado";
            panelPagado.Size = new Size(239, 205);
            panelPagado.TabIndex = 13;
            panelPagado.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Lime;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(67, 160);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 27);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(215, 18);
            label1.TabIndex = 6;
            label1.Text = "! Su envio ya ha sido pagado ¡";
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 240, 248);
            ClientSize = new Size(1019, 520);
            Controls.Add(panelPagado);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panelPago);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagar";
            Text = "Form3";
            panelPago.ResumeLayout(false);
            panelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picYape).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPagado.ResumeLayout(false);
            panelPagado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtEnvioID;
        private Button btnBuscar;
        private Panel panelPago;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Panel panelMetodoPago;
        private PictureBox picPlin;
        private PictureBox picYape;
        private Panel panelPagado;
        private Button btnAceptar;
        private PictureBox pictureBox3;
        private Label label1;
    }
}