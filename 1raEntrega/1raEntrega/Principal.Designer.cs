namespace _1raEntrega
{
    partial class Principal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoCongruencialMixtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoMultiplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edtA = new System.Windows.Forms.NumericUpDown();
            this.edtSemilla = new System.Windows.Forms.NumericUpDown();
            this.edtC = new System.Windows.Forms.NumericUpDown();
            this.edtM = new System.Windows.Forms.NumericUpDown();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(342, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoAToolStripMenuItem,
            this.puntoBToolStripMenuItem,
            this.puntoCToolStripMenuItem,
            this.puntoDToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // puntoAToolStripMenuItem
            // 
            this.puntoAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.métodoCongruencialMixtoToolStripMenuItem,
            this.métodoMultiplicativoToolStripMenuItem});
            this.puntoAToolStripMenuItem.Name = "puntoAToolStripMenuItem";
            this.puntoAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoAToolStripMenuItem.Text = "Punto A";
            // 
            // métodoCongruencialMixtoToolStripMenuItem
            // 
            this.métodoCongruencialMixtoToolStripMenuItem.Name = "métodoCongruencialMixtoToolStripMenuItem";
            this.métodoCongruencialMixtoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.métodoCongruencialMixtoToolStripMenuItem.Text = "Método Congruencial Mixto";
            this.métodoCongruencialMixtoToolStripMenuItem.Click += new System.EventHandler(this.métodoCongruencialMixtoToolStripMenuItem_Click);
            // 
            // métodoMultiplicativoToolStripMenuItem
            // 
            this.métodoMultiplicativoToolStripMenuItem.Name = "métodoMultiplicativoToolStripMenuItem";
            this.métodoMultiplicativoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.métodoMultiplicativoToolStripMenuItem.Text = "Método Multiplicativo";
            // 
            // puntoBToolStripMenuItem
            // 
            this.puntoBToolStripMenuItem.Name = "puntoBToolStripMenuItem";
            this.puntoBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoBToolStripMenuItem.Text = "Punto B";
            // 
            // puntoCToolStripMenuItem
            // 
            this.puntoCToolStripMenuItem.Name = "puntoCToolStripMenuItem";
            this.puntoCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoCToolStripMenuItem.Text = "Punto C";
            // 
            // puntoDToolStripMenuItem
            // 
            this.puntoDToolStripMenuItem.Name = "puntoDToolStripMenuItem";
            this.puntoDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoDToolStripMenuItem.Text = "Punto D";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrantesToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            this.integrantesToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // edtA
            // 
            this.edtA.Location = new System.Drawing.Point(229, 61);
            this.edtA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtA.Name = "edtA";
            this.edtA.Size = new System.Drawing.Size(88, 20);
            this.edtA.TabIndex = 3;
            // 
            // edtSemilla
            // 
            this.edtSemilla.Location = new System.Drawing.Point(76, 61);
            this.edtSemilla.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edtSemilla.Name = "edtSemilla";
            this.edtSemilla.Size = new System.Drawing.Size(88, 20);
            this.edtSemilla.TabIndex = 4;
            this.edtSemilla.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // edtC
            // 
            this.edtC.Location = new System.Drawing.Point(76, 101);
            this.edtC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtC.Name = "edtC";
            this.edtC.Size = new System.Drawing.Size(88, 20);
            this.edtC.TabIndex = 5;
            // 
            // edtM
            // 
            this.edtM.Location = new System.Drawing.Point(229, 101);
            this.edtM.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtM.Name = "edtM";
            this.edtM.Size = new System.Drawing.Size(88, 20);
            this.edtM.TabIndex = 6;
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(22, 63);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(40, 13);
            this.lblSemilla.TabIndex = 7;
            this.lblSemilla.Text = "Semilla";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(188, 63);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "A";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(22, 103);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "C";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(188, 108);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(16, 13);
            this.lblM.TabIndex = 10;
            this.lblM.Text = "M";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(53, 141);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(120, 160);
            this.lstNumeros.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 330);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.edtM);
            this.Controls.Add(this.edtC);
            this.Controls.Add(this.edtSemilla);
            this.Controls.Add(this.edtA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoCongruencialMixtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoMultiplicativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown edtA;
        private System.Windows.Forms.NumericUpDown edtSemilla;
        private System.Windows.Forms.NumericUpDown edtC;
        private System.Windows.Forms.NumericUpDown edtM;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.ListBox lstNumeros;
    }
}