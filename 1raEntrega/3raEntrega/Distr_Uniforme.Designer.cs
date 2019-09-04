namespace _3raEntrega
{
    partial class Distr_Uniforme
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.listVarAlea = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_cant_variables = new System.Windows.Forms.NumericUpDown();
            this.txb_cant_intervalos = new System.Windows.Forms.NumericUpDown();
            this.txb_valor_b = new System.Windows.Forms.NumericUpDown();
            this.txb_valor_a = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_cant_variables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cant_intervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_valor_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_valor_a)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(409, 292);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los Parametros necesarios:";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(409, 103);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // listVarAlea
            // 
            this.listVarAlea.FormattingEnabled = true;
            this.listVarAlea.Location = new System.Drawing.Point(15, 103);
            this.listVarAlea.Name = "listVarAlea";
            this.listVarAlea.Size = new System.Drawing.Size(327, 212);
            this.listVarAlea.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Valor A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de Intervalos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cantidad de Variables:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor B:";
            // 
            // tbx_cant_variables
            // 
            this.tbx_cant_variables.Location = new System.Drawing.Point(143, 37);
            this.tbx_cant_variables.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbx_cant_variables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbx_cant_variables.Name = "tbx_cant_variables";
            this.tbx_cant_variables.Size = new System.Drawing.Size(93, 20);
            this.tbx_cant_variables.TabIndex = 16;
            this.tbx_cant_variables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txb_cant_intervalos
            // 
            this.txb_cant_intervalos.Location = new System.Drawing.Point(143, 69);
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
            this.txb_cant_intervalos.TabIndex = 18;
            this.txb_cant_intervalos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txb_valor_b
            // 
            this.txb_valor_b.DecimalPlaces = 2;
            this.txb_valor_b.Location = new System.Drawing.Point(302, 69);
            this.txb_valor_b.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txb_valor_b.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.txb_valor_b.Name = "txb_valor_b";
            this.txb_valor_b.Size = new System.Drawing.Size(93, 20);
            this.txb_valor_b.TabIndex = 23;
            // 
            // txb_valor_a
            // 
            this.txb_valor_a.DecimalPlaces = 2;
            this.txb_valor_a.Location = new System.Drawing.Point(302, 37);
            this.txb_valor_a.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txb_valor_a.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.txb_valor_a.Name = "txb_valor_a";
            this.txb_valor_a.Size = new System.Drawing.Size(93, 20);
            this.txb_valor_a.TabIndex = 22;
            // 
            // Distr_Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 333);
            this.Controls.Add(this.txb_valor_b);
            this.Controls.Add(this.txb_valor_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_cant_intervalos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_cant_variables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVarAlea);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "Distr_Uniforme";
            this.Text = "Distribución Uniforme";
            ((System.ComponentModel.ISupportInitialize)(this.tbx_cant_variables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_cant_intervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_valor_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_valor_a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ListBox listVarAlea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbx_cant_variables;
        private System.Windows.Forms.NumericUpDown txb_cant_intervalos;
        private System.Windows.Forms.NumericUpDown txb_valor_b;
        private System.Windows.Forms.NumericUpDown txb_valor_a;
    }
}