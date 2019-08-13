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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listNumAl = new System.Windows.Forms.ListView();
            this.columnItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumAl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).BeginInit();
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
            this.edtM.Size = new System.Drawing.Size(72, 20);
            this.edtM.TabIndex = 4;
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
            this.edtC.Size = new System.Drawing.Size(72, 20);
            this.edtC.TabIndex = 3;
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
            this.edtSemilla.Size = new System.Drawing.Size(72, 20);
            this.edtSemilla.TabIndex = 1;
            // 
            // edtA
            // 
            this.edtA.Location = new System.Drawing.Point(207, 68);
            this.edtA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtA.Name = "edtA";
            this.edtA.Size = new System.Drawing.Size(72, 20);
            this.edtA.TabIndex = 2;
            this.edtA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(507, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(426, 111);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 22);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(426, 365);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // listNumAl
            // 
            this.listNumAl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItem,
            this.columnNumAl});
            this.listNumAl.Location = new System.Drawing.Point(21, 111);
            this.listNumAl.Name = "listNumAl";
            this.listNumAl.Size = new System.Drawing.Size(258, 277);
            this.listNumAl.TabIndex = 28;
            this.listNumAl.UseCompatibleStateImageBehavior = false;
            this.listNumAl.View = System.Windows.Forms.View.Details;
            // 
            // columnItem
            // 
            this.columnItem.Text = "ID";
            this.columnItem.Width = 85;
            // 
            // columnNumAl
            // 
            this.columnNumAl.Text = "Número Aleatorio";
            this.columnNumAl.Width = 108;
            // 
            // MetodosCongruenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.listNumAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.edtM);
            this.Controls.Add(this.edtC);
            this.Controls.Add(this.edtSemilla);
            this.Controls.Add(this.edtA);
            this.Name = "MetodosCongruenciales";
            this.Text = "Generadores de Números Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listNumAl;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnNumAl;
    }
}