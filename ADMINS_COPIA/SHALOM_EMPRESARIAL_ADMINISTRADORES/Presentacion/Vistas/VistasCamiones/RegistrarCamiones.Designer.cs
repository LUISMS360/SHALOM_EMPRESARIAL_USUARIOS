namespace Presentacion.Vistas.VistasCamiones
{
    partial class RegistrarCamiones
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
            label17 = new Label();
            panel1 = new Panel();
            cmbConductores = new ComboBox();
            cmbDestino = new ComboBox();
            cmbOrigen = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtInfo = new TextBox();
            txtPlaca = new TextBox();
            label14 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegistrarCamion = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(13, 52);
            label17.Name = "label17";
            label17.Size = new Size(137, 17);
            label17.TabIndex = 23;
            label17.Text = "Informacion Camion";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbConductores);
            panel1.Controls.Add(cmbDestino);
            panel1.Controls.Add(cmbOrigen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtInfo);
            panel1.Controls.Add(txtPlaca);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 90);
            panel1.TabIndex = 22;
            // 
            // cmbConductores
            // 
            cmbConductores.Font = new Font("Sitka Display", 11.249999F);
            cmbConductores.FormattingEnabled = true;
            cmbConductores.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            cmbConductores.Location = new Point(176, 32);
            cmbConductores.Name = "cmbConductores";
            cmbConductores.Size = new Size(121, 29);
            cmbConductores.TabIndex = 25;
            cmbConductores.SelectedValueChanged += cmbConductores_SelectedValueChanged;
            // 
            // cmbDestino
            // 
            cmbDestino.Font = new Font("Sitka Display", 11.249999F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            cmbDestino.Location = new Point(644, 31);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 29);
            cmbDestino.TabIndex = 24;
            cmbDestino.SelectedValueChanged += cmbDestino_SelectedValueChanged;
            // 
            // cmbOrigen
            // 
            cmbOrigen.Font = new Font("Sitka Display", 11.249999F);
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            cmbOrigen.Location = new Point(500, 32);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 29);
            cmbOrigen.TabIndex = 23;
            cmbOrigen.SelectedValueChanged += cmbOrigen_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.Location = new Point(633, 13);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 22;
            label5.Text = "Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label4.Location = new Point(500, 13);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 20;
            label4.Text = "Origen";
            // 
            // txtInfo
            // 
            txtInfo.Font = new Font("Sitka Display", 11.249999F);
            txtInfo.Location = new Point(331, 32);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(117, 26);
            txtInfo.TabIndex = 16;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Sitka Display", 11.249999F);
            txtPlaca.Location = new Point(28, 32);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(117, 26);
            txtPlaca.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label14.Location = new Point(28, 13);
            label14.Name = "label14";
            label14.Size = new Size(65, 15);
            label14.TabIndex = 13;
            label14.Text = "Nro Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.Location = new Point(331, 13);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Info de Camion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(176, 13);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Nro Conductor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 21;
            label1.Text = "REGISTRO DE CAMIONES";
            // 
            // btnRegistrarCamion
            // 
            btnRegistrarCamion.BackColor = Color.Red;
            btnRegistrarCamion.FlatAppearance.BorderSize = 0;
            btnRegistrarCamion.FlatStyle = FlatStyle.Flat;
            btnRegistrarCamion.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCamion.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarCamion.Location = new Point(629, 203);
            btnRegistrarCamion.Name = "btnRegistrarCamion";
            btnRegistrarCamion.Size = new Size(189, 41);
            btnRegistrarCamion.TabIndex = 24;
            btnRegistrarCamion.Text = "REGISTRAR";
            btnRegistrarCamion.UseVisualStyleBackColor = false;
            btnRegistrarCamion.Click += btnRegistrarCamion_Click;
            // 
            // RegistrarCamiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 243, 250);
            ClientSize = new Size(830, 641);
            Controls.Add(btnRegistrarCamion);
            Controls.Add(label17);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarCamiones";
            Text = "RegistrarCamiones";
            Load += RegistrarCamiones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private Panel panel1;
        private TextBox txtInfo;
        private TextBox txtPlaca;
        private Label label14;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrarCamion;
        private ComboBox cmbDestino;
        private ComboBox cmbOrigen;
        private Label label5;
        private Label label4;
        private ComboBox cmbConductores;
    }
}