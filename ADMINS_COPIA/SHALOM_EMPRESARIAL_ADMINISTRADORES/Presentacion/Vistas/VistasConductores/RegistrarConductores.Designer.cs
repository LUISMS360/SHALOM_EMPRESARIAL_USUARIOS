namespace Presentacion.Vistas.VistasConductores
{
    partial class RegistrarConductores
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
            btnRegistrarConductor = new Button();
            label17 = new Label();
            panel1 = new Panel();
            txtApellidos = new TextBox();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNombres = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarConductor
            // 
            btnRegistrarConductor.BackColor = Color.Red;
            btnRegistrarConductor.FlatAppearance.BorderSize = 0;
            btnRegistrarConductor.FlatStyle = FlatStyle.Flat;
            btnRegistrarConductor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarConductor.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarConductor.Location = new Point(633, 232);
            btnRegistrarConductor.Name = "btnRegistrarConductor";
            btnRegistrarConductor.Size = new Size(189, 41);
            btnRegistrarConductor.TabIndex = 28;
            btnRegistrarConductor.Text = "REGISTRAR";
            btnRegistrarConductor.UseVisualStyleBackColor = false;
            btnRegistrarConductor.Click += btnRegistrarConductor_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(13, 52);
            label17.Name = "label17";
            label17.Size = new Size(155, 17);
            label17.TabIndex = 27;
            label17.Text = "Informacion Conductor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContrasenia);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 90);
            panel1.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Sitka Display", 11.249999F);
            txtApellidos.Location = new Point(642, 41);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(117, 26);
            txtApellidos.TabIndex = 24;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Sitka Display", 11.249999F);
            txtUsuario.Location = new Point(34, 41);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(117, 26);
            txtUsuario.TabIndex = 23;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Sitka Display", 11.249999F);
            txtContrasenia.Location = new Point(211, 41);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(117, 26);
            txtContrasenia.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.Location = new Point(211, 13);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 21;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label4.Location = new Point(642, 13);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 17;
            label4.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Sitka Display", 11.249999F);
            txtNombres.Location = new Point(417, 41);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(117, 26);
            txtNombres.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.Location = new Point(417, 13);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(48, 13);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 25;
            label1.Text = "REGISTRO DE CONDUCTORES";
            // 
            // RegistrarConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 234, 244);
            ClientSize = new Size(830, 641);
            Controls.Add(btnRegistrarConductor);
            Controls.Add(label17);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarConductores";
            Text = "RegistrarConductores";
            Load += RegistrarConductores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarConductor;
        private Label label17;
        private Panel panel1;
        private TextBox txtContrasenia;
        private Label label5;
        private Label label4;
        private TextBox txtNombres;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtApellidos;
    }
}