namespace _1raEntrega
{
    partial class TestChiCuadrado
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.edtCantidad = new System.Windows.Forms.NumericUpDown();
            this.edtIntervalos = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(39, 79);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Números a generar";
            // 
            // edtCantidad
            // 
            this.edtCantidad.Location = new System.Drawing.Point(142, 77);
            this.edtCantidad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtCantidad.Name = "edtCantidad";
            this.edtCantidad.Size = new System.Drawing.Size(109, 20);
            this.edtCantidad.TabIndex = 1;
            this.edtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edtIntervalos
            // 
            this.edtIntervalos.Location = new System.Drawing.Point(363, 77);
            this.edtIntervalos.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtIntervalos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtIntervalos.Name = "edtIntervalos";
            this.edtIntervalos.Size = new System.Drawing.Size(109, 20);
            this.edtIntervalos.TabIndex = 3;
            this.edtIntervalos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(304, 79);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(53, 13);
            this.lblIntervalos.TabIndex = 2;
            this.lblIntervalos.Text = "Intérvalos";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(316, 237);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(397, 237);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TestChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 290);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.edtIntervalos);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.edtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "TestChiCuadrado";
            this.Text = "Test Chi Cuadrado con Generador Propio del Lenguaje";
            this.Load += new System.EventHandler(this.TestChiCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIntervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown edtCantidad;
        private System.Windows.Forms.NumericUpDown edtIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar;
    }
}