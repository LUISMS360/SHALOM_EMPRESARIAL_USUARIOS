namespace Presentacion
{
    partial class VerTarifas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerTarifas));
            tiposPaquetesList = new ImageList(components);
            lblTipo = new Label();
            btnRegresar = new PictureBox();
            lbl = new Label();
            lblMonto = new Label();
            btnAvanzar = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAvanzar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tiposPaquetesList
            // 
            tiposPaquetesList.ColorDepth = ColorDepth.Depth32Bit;
            tiposPaquetesList.ImageStream = (ImageListStreamer)resources.GetObject("tiposPaquetesList.ImageStream");
            tiposPaquetesList.TransparentColor = Color.Transparent;
            tiposPaquetesList.Images.SetKeyName(0, "paqueteNormal.png");
            tiposPaquetesList.Images.SetKeyName(1, "A2.png");
            tiposPaquetesList.Images.SetKeyName(2, "A3.png");
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTipo.Location = new Point(460, 420);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(24, 37);
            lblTipo.TabIndex = 24;
            lblTipo.Text = ".";
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(141, 420);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(34, 35);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 23;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // lbl
            // 
            lbl.ImageList = tiposPaquetesList;
            lbl.Location = new Point(181, 356);
            lbl.Name = "lbl";
            lbl.Size = new Size(180, 180);
            lbl.TabIndex = 22;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblMonto.Location = new Point(641, 418);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(72, 37);
            lblMonto.TabIndex = 21;
            lblMonto.Text = "0.00";
            // 
            // btnAvanzar
            // 
            btnAvanzar.Image = (Image)resources.GetObject("btnAvanzar.Image");
            btnAvanzar.Location = new Point(367, 420);
            btnAvanzar.Name = "btnAvanzar";
            btnAvanzar.Size = new Size(34, 35);
            btnAvanzar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAvanzar.TabIndex = 20;
            btnAvanzar.TabStop = false;
            btnAvanzar.Click += btnAvanzar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(143, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 155);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(17, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 120);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(514, 69);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 9.749999F);
            label4.Location = new Point(255, 56);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 5;
            label4.Text = "DESTINO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 9.749999F);
            label3.Location = new Point(23, 56);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 4;
            label3.Text = "ORIGEN";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Sitka Display", 9.749999F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cajamarca", "Cuzco", "Tarapoto", "Trujillo ", "Lima", "Piura", "Ica" });
            comboBox2.Location = new Point(255, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 27);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Sitka Display", 9.749999F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            comboBox1.Location = new Point(23, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 27);
            comboBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Sitka Display", 11.249999F);
            radioButton2.Location = new Point(178, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Aereo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(23, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Terrestre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 87);
            label2.Name = "label2";
            label2.Size = new Size(171, 57);
            label2.TabIndex = 18;
            label2.Text = "Calcula el monto  de tus envios,\r\n\r\nrepartos y recojos.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(129, 28);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 17;
            label1.Text = "Bienvenido a tarifas";
            // 
            // VerTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 240, 248);
            ClientSize = new Size(1035, 565);
            Controls.Add(lblTipo);
            Controls.Add(btnRegresar);
            Controls.Add(lbl);
            Controls.Add(lblMonto);
            Controls.Add(btnAvanzar);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerTarifas";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAvanzar).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList tiposPaquetesList;
        private Label lblTipo;
        private PictureBox btnRegresar;
        private Label lbl;
        private Label lblMonto;
        private PictureBox btnAvanzar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private Label label1;
    }
}