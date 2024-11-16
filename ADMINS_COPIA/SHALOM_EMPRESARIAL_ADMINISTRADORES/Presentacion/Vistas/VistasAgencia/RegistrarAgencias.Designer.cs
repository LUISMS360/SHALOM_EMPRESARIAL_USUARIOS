namespace Presentacion.Vistas.VistasAgencia
{
    partial class RegistrarAgencias
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
            btnRegistrarAgencia = new Button();
            label17 = new Label();
            panel1 = new Panel();
            txtDistrito = new TextBox();
            label5 = new Label();
            cmbProvincia = new ComboBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label14 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarAgencia
            // 
            btnRegistrarAgencia.BackColor = Color.Red;
            btnRegistrarAgencia.FlatAppearance.BorderSize = 0;
            btnRegistrarAgencia.FlatStyle = FlatStyle.Flat;
            btnRegistrarAgencia.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarAgencia.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarAgencia.Location = new Point(633, 232);
            btnRegistrarAgencia.Name = "btnRegistrarAgencia";
            btnRegistrarAgencia.Size = new Size(189, 41);
            btnRegistrarAgencia.TabIndex = 32;
            btnRegistrarAgencia.Text = "REGISTRAR";
            btnRegistrarAgencia.UseVisualStyleBackColor = false;
            btnRegistrarAgencia.Click += btnRegistrarAgencia_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(13, 52);
            label17.Name = "label17";
            label17.Size = new Size(140, 17);
            label17.TabIndex = 31;
            label17.Text = "Informacion Agencia";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtDistrito);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbProvincia);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 90);
            panel1.TabIndex = 30;
            // 
            // txtDistrito
            // 
            txtDistrito.Font = new Font("Sitka Display", 11.249999F);
            txtDistrito.Location = new Point(371, 41);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.Size = new Size(117, 26);
            txtDistrito.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.Location = new Point(371, 13);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 21;
            label5.Text = "Distrito";
            // 
            // cmbProvincia
            // 
            cmbProvincia.Font = new Font("Sitka Display", 11.249999F);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            cmbProvincia.Location = new Point(197, 41);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(121, 29);
            cmbProvincia.TabIndex = 19;
            cmbProvincia.SelectedIndexChanged += cmbProvincia_SelectedIndexChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Sitka Display", 11.249999F);
            txtDireccion.Location = new Point(538, 41);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(117, 26);
            txtDireccion.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Sitka Display", 11.249999F);
            txtNombre.Location = new Point(12, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(117, 26);
            txtNombre.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label14.Location = new Point(12, 13);
            label14.Name = "label14";
            label14.Size = new Size(108, 15);
            label14.TabIndex = 13;
            label14.Text = "Nombre Agencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.Location = new Point(538, 13);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(197, 13);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Provincia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 29;
            label1.Text = "REGISTRO DE AGENCIA";
            // 
            // RegistrarAgencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 243, 250);
            ClientSize = new Size(830, 641);
            Controls.Add(btnRegistrarAgencia);
            Controls.Add(label17);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarAgencias";
            Text = "RegistrarAgencias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarAgencia;
        private Label label17;
        private Panel panel1;
        private TextBox txtDistrito;
        private Label label5;
        private ComboBox cmbProvincia;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label14;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}