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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoCongruencialMixtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoMultiplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(398, 295);
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
            this.ejecutarToolStripMenuItem});
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
            this.métodoMultiplicativoToolStripMenuItem.Click += new System.EventHandler(this.métodoMultiplicativoToolStripMenuItem_Click);
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
            this.puntoCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntoCToolStripMenuItem.Text = "Punto C";
            this.puntoCToolStripMenuItem.Click += new System.EventHandler(this.puntoCToolStripMenuItem_Click);
            // 
            // imgIcono
            // 
            this.imgIcono.Image = ((System.Drawing.Image)(resources.GetObject("imgIcono.Image")));
            this.imgIcono.Location = new System.Drawing.Point(271, 27);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(202, 42);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 8;
            this.imgIcono.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Simulación ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trabajo Práctico Nº1 Generación de Números Aleatorios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Grupo Nº 6";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 127);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "- Barrera Luciano (69920)\n\n- Floreano Micaela (72276)\n\n- Ribotta Franco (Lejago)\n" +
    "\n- Rodriguez Alejandro (61142)\n\n- Videla Gimena (66984)";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 330);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Trabajo Practico 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
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
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}