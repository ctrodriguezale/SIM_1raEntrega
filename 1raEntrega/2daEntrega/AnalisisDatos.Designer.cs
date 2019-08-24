namespace _2daEntrega
{
    partial class AnalisisDatos
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
            this.chrHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.edtIntervalos = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // chrHistograma
            // 
            this.chrHistograma.Location = new System.Drawing.Point(12, 75);
            this.chrHistograma.Name = "chrHistograma";
            this.chrHistograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chrHistograma.Size = new System.Drawing.Size(380, 274);
            this.chrHistograma.TabIndex = 0;
            this.chrHistograma.Text = "chtHistograma";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(317, 46);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(317, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 20);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.Location = new System.Drawing.Point(9, 26);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(300, 13);
            this.lblArchivo.TabIndex = 7;
            this.lblArchivo.Text = "Seleccionar Archivo de datos";
            // 
            // edtIntervalos
            // 
            this.edtIntervalos.Location = new System.Drawing.Point(99, 49);
            this.edtIntervalos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.edtIntervalos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtIntervalos.Name = "edtIntervalos";
            this.edtIntervalos.Size = new System.Drawing.Size(74, 20);
            this.edtIntervalos.TabIndex = 8;
            this.edtIntervalos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(9, 51);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(53, 13);
            this.lblIntervalos.TabIndex = 9;
            this.lblIntervalos.Text = "Intervalos";
            // 
            // AnalisisDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 360);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.edtIntervalos);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.chrHistograma);
            this.Name = "AnalisisDatos";
            this.Text = "AnalisisDatos";
            ((System.ComponentModel.ISupportInitialize)(this.chrHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtIntervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrHistograma;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.NumericUpDown edtIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
    }
}