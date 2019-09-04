namespace _3raEntrega
{
    partial class Distr_Poisson
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
            this.txb_lambda = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_cant_intervalos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_cant_variables = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listVarAlea = new System.Windows.Forms.ListBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txb_lambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cant_intervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_cant_variables)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_lambda
            // 
            this.txb_lambda.Location = new System.Drawing.Point(297, 45);
            this.txb_lambda.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txb_lambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txb_lambda.Name = "txb_lambda";
            this.txb_lambda.Size = new System.Drawing.Size(86, 20);
            this.txb_lambda.TabIndex = 24;
            this.txb_lambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lambda:";
            // 
            // txb_cant_intervalos
            // 
            this.txb_cant_intervalos.Location = new System.Drawing.Point(134, 77);
            this.txb_cant_intervalos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txb_cant_intervalos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txb_cant_intervalos.Name = "txb_cant_intervalos";
            this.txb_cant_intervalos.Size = new System.Drawing.Size(93, 20);
            this.txb_cant_intervalos.TabIndex = 22;
            this.txb_cant_intervalos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad de Intervalos:";
            // 
            // tbx_cant_variables
            // 
            this.tbx_cant_variables.Location = new System.Drawing.Point(134, 45);
            this.tbx_cant_variables.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.tbx_cant_variables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbx_cant_variables.Name = "tbx_cant_variables";
            this.tbx_cant_variables.Size = new System.Drawing.Size(93, 20);
            this.tbx_cant_variables.TabIndex = 20;
            this.tbx_cant_variables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cantidad de Variables:";
            // 
            // listVarAlea
            // 
            this.listVarAlea.FormattingEnabled = true;
            this.listVarAlea.Location = new System.Drawing.Point(15, 108);
            this.listVarAlea.Name = "listVarAlea";
            this.listVarAlea.Size = new System.Drawing.Size(327, 212);
            this.listVarAlea.TabIndex = 18;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(409, 108);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 17;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese los Parámetros necesarios:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(409, 297);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Distr_Poisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 340);
            this.Controls.Add(this.txb_lambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_cant_intervalos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_cant_variables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVarAlea);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "Distr_Poisson";
            this.Text = "Distribución Poisson";
            ((System.ComponentModel.ISupportInitialize)(this.txb_lambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cant_intervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_cant_variables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txb_lambda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txb_cant_intervalos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbx_cant_variables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listVarAlea;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
    }
}