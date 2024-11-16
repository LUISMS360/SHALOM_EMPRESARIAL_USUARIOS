namespace Presentacion.Vistas.VistasAgencia
{
    partial class VerAgencias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblAgenica = new Label();
            txtAgencia = new TextBox();
            btnBuscar = new Button();
            resultadoBusqueda = new DataGridView();
            cmbFiltroBusquedaClientes = new ComboBox();
            label1 = new Label();
            lblProvincia = new Label();
            cmbProvincia = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).BeginInit();
            SuspendLayout();
            // 
            // lblAgenica
            // 
            lblAgenica.AutoSize = true;
            lblAgenica.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblAgenica.Location = new Point(342, 80);
            lblAgenica.Name = "lblAgenica";
            lblAgenica.Size = new Size(114, 17);
            lblAgenica.TabIndex = 56;
            lblAgenica.Text = "Nombre Agencia";
            lblAgenica.Visible = false;
            // 
            // txtAgencia
            // 
            txtAgencia.Font = new Font("Sitka Display", 11.249999F);
            txtAgencia.Location = new Point(339, 110);
            txtAgencia.Multiline = true;
            txtAgencia.Name = "txtAgencia";
            txtAgencia.Size = new Size(117, 33);
            txtAgencia.TabIndex = 55;
            txtAgencia.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LimeGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(156, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 33);
            btnBuscar.TabIndex = 54;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // resultadoBusqueda
            // 
            resultadoBusqueda.BackgroundColor = SystemColors.ButtonHighlight;
            resultadoBusqueda.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resultadoBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resultadoBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultadoBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            resultadoBusqueda.EnableHeadersVisualStyles = false;
            resultadoBusqueda.Location = new Point(18, 178);
            resultadoBusqueda.Name = "resultadoBusqueda";
            resultadoBusqueda.Size = new Size(800, 457);
            resultadoBusqueda.TabIndex = 53;
            // 
            // cmbFiltroBusquedaClientes
            // 
            cmbFiltroBusquedaClientes.Font = new Font("Sitka Display", 11.249999F);
            cmbFiltroBusquedaClientes.FormattingEnabled = true;
            cmbFiltroBusquedaClientes.Items.AddRange(new object[] { "Todos", "Por Nombre", "Por Provincia" });
            cmbFiltroBusquedaClientes.Location = new Point(12, 45);
            cmbFiltroBusquedaClientes.Name = "cmbFiltroBusquedaClientes";
            cmbFiltroBusquedaClientes.Size = new Size(126, 29);
            cmbFiltroBusquedaClientes.TabIndex = 52;
            cmbFiltroBusquedaClientes.SelectedIndexChanged += cmbFiltroBusquedaClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 51;
            label1.Text = "VER  AGENCIAS";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblProvincia.Location = new Point(495, 80);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(68, 17);
            lblProvincia.TabIndex = 58;
            lblProvincia.Text = "Provincia";
            lblProvincia.Visible = false;
            // 
            // cmbProvincia
            // 
            cmbProvincia.Font = new Font("Sitka Display", 11.249999F);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "Piura", "Lima", "Trujillo", "Ica", "Tarapoto", "Cuzco", "Cajamarca" });
            cmbProvincia.Location = new Point(495, 110);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(121, 29);
            cmbProvincia.TabIndex = 59;
            cmbProvincia.Visible = false;
            // 
            // VerAgencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 243, 250);
            ClientSize = new Size(830, 641);
            Controls.Add(cmbProvincia);
            Controls.Add(lblProvincia);
            Controls.Add(lblAgenica);
            Controls.Add(txtAgencia);
            Controls.Add(btnBuscar);
            Controls.Add(resultadoBusqueda);
            Controls.Add(cmbFiltroBusquedaClientes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerAgencias";
            Text = "VerAgencias";
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenica;
        private TextBox txtAgencia;
        private Button btnBuscar;
        private DataGridView resultadoBusqueda;
        private ComboBox cmbFiltroBusquedaClientes;
        private Label label1;
        private Label lblProvincia;
        private ComboBox cmbProvincia;
    }
}