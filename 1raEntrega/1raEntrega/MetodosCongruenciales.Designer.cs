﻿namespace _1raEntrega
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
            ((System.ComponentModel.ISupportInitialize)(this.edtM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(452, 36);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(43, 13);
            this.lblM.TabIndex = 19;
            this.lblM.Text = "Valor M";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(298, 36);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(41, 13);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "Valor C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(154, 36);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(41, 13);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "Valor A";
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(12, 36);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(40, 13);
            this.lblSemilla.TabIndex = 16;
            this.lblSemilla.Text = "Semilla";
            // 
            // edtM
            // 
            this.edtM.Location = new System.Drawing.Point(501, 34);
            this.edtM.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtM.Name = "edtM";
            this.edtM.Size = new System.Drawing.Size(72, 20);
            this.edtM.TabIndex = 15;
            // 
            // edtC
            // 
            this.edtC.Location = new System.Drawing.Point(345, 34);
            this.edtC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtC.Name = "edtC";
            this.edtC.Size = new System.Drawing.Size(72, 20);
            this.edtC.TabIndex = 14;
            // 
            // edtSemilla
            // 
            this.edtSemilla.Location = new System.Drawing.Point(58, 34);
            this.edtSemilla.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.edtSemilla.Name = "edtSemilla";
            this.edtSemilla.Size = new System.Drawing.Size(72, 20);
            this.edtSemilla.TabIndex = 13;
            // 
            // edtA
            // 
            this.edtA.Location = new System.Drawing.Point(201, 34);
            this.edtA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.edtA.Name = "edtA";
            this.edtA.Size = new System.Drawing.Size(72, 20);
            this.edtA.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(507, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(507, 72);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 22);
            this.btnGenerar.TabIndex = 23;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(201, 99);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(216, 277);
            this.lstNumeros.TabIndex = 24;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(507, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // MetodosCongruenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstNumeros);
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
            this.Text = "MetodosCongruenciales";
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
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnAgregar;
    }
}