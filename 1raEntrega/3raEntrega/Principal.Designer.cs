namespace _3raEntrega
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónUniformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónExponencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuciónPoissonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 206);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 155);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "- Baez Lucas (58584)\n\n- Floreano Micaela (72276)\n\n- Ribotta Franco (74120)\n\n- Rod" +
    "riguez Alejandro (61142)\n\n- Videla Gimena (66984)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grupo Nº 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trabajo Práctico Nº3: Variables Aleatorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Simulación ";
            // 
            // imgIcono
            // 
            this.imgIcono.Image = ((System.Drawing.Image)(resources.GetObject("imgIcono.Image")));
            this.imgIcono.Location = new System.Drawing.Point(345, 42);
            this.imgIcono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(269, 52);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 14;
            this.imgIcono.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(515, 372);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(665, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribuciónUniformeToolStripMenuItem,
            this.distribuciónExponencialToolStripMenuItem,
            this.distribuciónNormalToolStripMenuItem,
            this.distribuciónPoissonToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // distribuciónUniformeToolStripMenuItem
            // 
            this.distribuciónUniformeToolStripMenuItem.Name = "distribuciónUniformeToolStripMenuItem";
            this.distribuciónUniformeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.distribuciónUniformeToolStripMenuItem.Text = "Distribución Uniforme";
            this.distribuciónUniformeToolStripMenuItem.Click += new System.EventHandler(this.distribuciónUniformeToolStripMenuItem_Click);
            // 
            // distribuciónExponencialToolStripMenuItem
            // 
            this.distribuciónExponencialToolStripMenuItem.Name = "distribuciónExponencialToolStripMenuItem";
            this.distribuciónExponencialToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.distribuciónExponencialToolStripMenuItem.Text = "Distribución Exponencial";
            this.distribuciónExponencialToolStripMenuItem.Click += new System.EventHandler(this.distribuciónExponencialToolStripMenuItem_Click);
            // 
            // distribuciónNormalToolStripMenuItem
            // 
            this.distribuciónNormalToolStripMenuItem.Name = "distribuciónNormalToolStripMenuItem";
            this.distribuciónNormalToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.distribuciónNormalToolStripMenuItem.Text = "Distribución Normal";
            this.distribuciónNormalToolStripMenuItem.Click += new System.EventHandler(this.distribuciónNormalToolStripMenuItem_Click);
            // 
            // distribuciónPoissonToolStripMenuItem
            // 
            this.distribuciónPoissonToolStripMenuItem.Name = "distribuciónPoissonToolStripMenuItem";
            this.distribuciónPoissonToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.distribuciónPoissonToolStripMenuItem.Text = "Distribución Poisson";
            this.distribuciónPoissonToolStripMenuItem.Click += new System.EventHandler(this.distribuciónPoissonToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 418);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Trabajo Practico 3";
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónUniformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónExponencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuciónPoissonToolStripMenuItem;
    }
}