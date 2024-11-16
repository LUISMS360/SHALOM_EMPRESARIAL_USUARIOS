namespace Presentacion
{
    partial class PagoYape
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
            textBox1 = new TextBox();
            button1 = new Button();
            txtTotalPagar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Numero Telefono";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkMagenta;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(123, 79);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 3;
            button1.Text = "Yapear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(37, 39);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.PlaceholderText = "Monto a pagar 0.0S/";
            txtTotalPagar.Size = new Size(159, 23);
            txtTotalPagar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 86);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 11;
            label2.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 10;
            label1.Text = "Monto:";
            // 
            // PagoYape
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(232, 118);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotalPagar);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagoYape";
            Text = "FormPagoPlin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private TextBox txtTotalPagar;
        private Label label2;
        private Label label1;
    }
}