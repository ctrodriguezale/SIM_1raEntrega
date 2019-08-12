namespace _1raEntrega
{
    partial class MetodosCongruenciales
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
            this.lblM = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.edtM = new System.Windows.Forms.NumericUpDown();
            this.edtC = new System.Windows.Forms.NumericUpDown();
            this.edtSemilla = new System.Windows.Forms.NumericUpDown();
            this.edtA = new System.Windows.Forms.NumericUpDown();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(458, 70);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(43, 13);
            this.lblM.TabIndex = 19;
            this.lblM.Text = "Valor M";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(304, 70);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(41, 13);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "Valor C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(160, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(41, 13);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "Valor A";
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(18, 70);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(40, 13);
            this.lblSemilla.TabIndex = 16;
            this.lblSemilla.Text = "Semilla";
            // 
            // edtM
            // 
            this.edtM.Location = new System.Drawing.Point(507, 68);
            this.edtM.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtM.Name = "edtM";
            this.edtM.Size = new System.Drawing.Size(94, 20);
            this.edtM.TabIndex = 15;
            this.edtM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edtC
            // 
            this.edtC.Location = new System.Drawing.Point(351, 68);
            this.edtC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtC.Name = "edtC";
            this.edtC.Size = new System.Drawing.Size(94, 20);
            this.edtC.TabIndex = 14;
            // 
            // edtSemilla
            // 
            this.edtSemilla.Location = new System.Drawing.Point(64, 68);
            this.edtSemilla.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edtSemilla.Name = "edtSemilla";
            this.edtSemilla.Size = new System.Drawing.Size(94, 20);
            this.edtSemilla.TabIndex = 13;
            // 
            // edtA
            // 
            this.edtA.Location = new System.Drawing.Point(207, 68);
            this.edtA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtA.Name = "edtA";
            this.edtA.Size = new System.Drawing.Size(94, 20);
            this.edtA.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(508, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 23);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(398, 111);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 22);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(32, 111);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(216, 264);
            this.lstNumeros.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(398, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMetodos);
            this.groupBox1.Controls.Add(this.lblMetodos);
            this.groupBox1.Controls.Add(this.lblSemilla);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.edtA);
            this.groupBox1.Controls.Add(this.edtSemilla);
            this.groupBox1.Controls.Add(this.lblM);
            this.groupBox1.Controls.Add(this.edtC);
            this.groupBox1.Controls.Add(this.lblC);
            this.groupBox1.Controls.Add(this.edtM);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 122);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // cmbMetodos
            // 
            this.cmbMetodos.FormattingEnabled = true;
            this.cmbMetodos.Items.AddRange(new object[] {
            "Congruencial Mixto",
            "Congruencial Multiplicativo"});
            this.cmbMetodos.Location = new System.Drawing.Point(60, 18);
            this.cmbMetodos.Name = "cmbMetodos";
            this.cmbMetodos.Size = new System.Drawing.Size(241, 21);
            this.cmbMetodos.TabIndex = 1;
            this.cmbMetodos.SelectedIndexChanged += new System.EventHandler(this.cmbMetodos_SelectedIndexChanged);
            // 
            // lblMetodos
            // 
            this.lblMetodos.AutoSize = true;
            this.lblMetodos.Location = new System.Drawing.Point(6, 21);
            this.lblMetodos.Name = "lblMetodos";
            this.lblMetodos.Size = new System.Drawing.Size(48, 13);
            this.lblMetodos.TabIndex = 0;
            this.lblMetodos.Text = "Métodos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingrese valores para generar números aleatorios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Método Congruencial Mixto";
            // 
            // MetodosCongruenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnCerrar);
            this.Name = "MetodosCongruenciales";
            this.Text = "Generadores de Números Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.NumericUpDown edtM;
        private System.Windows.Forms.NumericUpDown edtC;
        private System.Windows.Forms.NumericUpDown edtSemilla;
        private System.Windows.Forms.NumericUpDown edtA;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}