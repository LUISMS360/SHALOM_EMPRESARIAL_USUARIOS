namespace Presentacion.Vistas.VistasConductores
{
    partial class VerConductores
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
            lblUsuario = new Label();
            txtUsuarioConductor = new TextBox();
            btnBuscar = new Button();
            resultadoBusqueda = new DataGridView();
            cmbFiltroBusquedaClientes = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblUsuario.Location = new Point(18, 90);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(126, 17);
            lblUsuario.TabIndex = 56;
            lblUsuario.Text = "Usuario Conductor";
            lblUsuario.Visible = false;
            // 
            // txtUsuarioConductor
            // 
            txtUsuarioConductor.Font = new Font("Sitka Display", 11.249999F);
            txtUsuarioConductor.Location = new Point(21, 110);
            txtUsuarioConductor.Multiline = true;
            txtUsuarioConductor.Name = "txtUsuarioConductor";
            txtUsuarioConductor.Size = new Size(117, 33);
            txtUsuarioConductor.TabIndex = 55;
            txtUsuarioConductor.Visible = false;
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
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resultadoBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resultadoBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Display", 11.249999F);
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
            cmbFiltroBusquedaClientes.Items.AddRange(new object[] { "Todos", "Por Usuario" });
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
            label1.Size = new Size(157, 20);
            label1.TabIndex = 51;
            label1.Text = "VER  CONDUCTORES";
            // 
            // VerConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 234, 244);
            ClientSize = new Size(830, 641);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuarioConductor);
            Controls.Add(btnBuscar);
            Controls.Add(resultadoBusqueda);
            Controls.Add(cmbFiltroBusquedaClientes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerConductores";
            Text = "VerConductores";
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuarioConductor;
        private Button btnBuscar;
        private DataGridView resultadoBusqueda;
        private ComboBox cmbFiltroBusquedaClientes;
        private Label label1;
    }
}