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
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoAToolStripMenuItem,
            this.puntoBToolStripMenuItem,
            this.puntoCToolStripMenuItem});
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
            this.puntoAToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
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
            this.puntoBToolStripMenuItem.Click += new System.EventHandler(this.puntoBToolStripMenuItem_Click);
            // 
            // puntoCToolStripMenuItem
            // 
            this.puntoCToolStripMenuItem.Name = "puntoCToolStripMenuItem";
            this.puntoCToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.puntoCToolStripMenuItem.Text = "Punto C";
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 330);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
    }
}