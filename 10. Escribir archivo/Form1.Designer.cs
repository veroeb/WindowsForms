﻿namespace _10.Escribir_archivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTexto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxArchivo = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.txtBoxTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese texto:";
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(213, 310);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(130, 23);
            this.btnTexto.TabIndex = 2;
            this.btnTexto.Text = "Agregar texto a archivo";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el nombre del archivo a escribir:";
            // 
            // txtBoxArchivo
            // 
            this.txtBoxArchivo.Location = new System.Drawing.Point(243, 39);
            this.txtBoxArchivo.Name = "txtBoxArchivo";
            this.txtBoxArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArchivo.TabIndex = 4;
            this.txtBoxArchivo.Enter += new System.EventHandler(this.txtBoxArchivo_Enter);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(243, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(240, 112);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(35, 13);
            this.lblSave.TabIndex = 6;
            this.lblSave.Text = "label3";
            // 
            // txtBoxTexto
            // 
            this.txtBoxTexto.Location = new System.Drawing.Point(133, 139);
            this.txtBoxTexto.Multiline = true;
            this.txtBoxTexto.Name = "txtBoxTexto";
            this.txtBoxTexto.Size = new System.Drawing.Size(210, 142);
            this.txtBoxTexto.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 365);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.txtBoxTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.TextBox txtBoxTexto;
    }
}

