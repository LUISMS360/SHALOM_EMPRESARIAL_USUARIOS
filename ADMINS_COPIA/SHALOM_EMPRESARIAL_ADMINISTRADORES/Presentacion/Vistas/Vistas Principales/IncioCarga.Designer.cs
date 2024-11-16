namespace Presentacion.Vistas.Vistas_Principales
{
    partial class IncioCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncioCarga));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progreBarCargar = new ProgressBar();
            panel1 = new Panel();
            labelCarga = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            picMinimizar = new PictureBox();
            picCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            SuspendLayout();
            // 
            // progreBarCargar
            // 
            progreBarCargar.Location = new Point(19, 345);
            progreBarCargar.Name = "progreBarCargar";
            progreBarCargar.Size = new Size(684, 10);
            progreBarCargar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCarga);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(progreBarCargar);
            panel1.Location = new Point(290, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 380);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // labelCarga
            // 
            labelCarga.AutoSize = true;
            labelCarga.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCarga.ForeColor = Color.White;
            labelCarga.Location = new Point(345, 313);
            labelCarga.Name = "labelCarga";
            labelCarga.Size = new Size(17, 20);
            labelCarga.TabIndex = 6;
            labelCarga.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 27);
            label2.Name = "label2";
            label2.Size = new Size(477, 128);
            label2.TabIndex = 5;
            label2.Text = "SHALOM";
            label2.MouseDown += label2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 202);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 4;
            label1.Text = "EMPRESARIAL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(288, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // picMinimizar
            // 
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(1291, 1);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(35, 36);
            picMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picMinimizar.TabIndex = 14;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picCerrar
            // 
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1332, 1);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(35, 36);
            picCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCerrar.TabIndex = 13;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // IncioCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 42, 47);
            ClientSize = new Size(1370, 749);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IncioCarga";
            Text = "IncioCarga";
            Load += IncioCarga_Load;
            MouseDown += IncioCarga_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progreBarCargar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox picMinimizar;
        private PictureBox picCerrar;
        private Label labelCarga;
    }
}