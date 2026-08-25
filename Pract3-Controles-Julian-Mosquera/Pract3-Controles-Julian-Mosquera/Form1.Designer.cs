namespace Pract3_Controles_Julian_Mosquera
{
    partial class Pract8EstrcuturaIf3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblIgualdad = new System.Windows.Forms.Label();
            this.gboxOperaciones = new System.Windows.Forms.GroupBox();
            this.rbnSuma = new System.Windows.Forms.RadioButton();
            this.rbnResta = new System.Windows.Forms.RadioButton();
            this.rbnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbnDivision = new System.Windows.Forms.RadioButton();
            this.gboxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(34, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ingresa los valores y seleccione una opcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(357, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(155, 59);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(14, 16);
            this.lblOperador.TabIndex = 4;
            this.lblOperador.Text = "+";
            // 
            // lblIgualdad
            // 
            this.lblIgualdad.AutoSize = true;
            this.lblIgualdad.Location = new System.Drawing.Point(316, 59);
            this.lblIgualdad.Name = "lblIgualdad";
            this.lblIgualdad.Size = new System.Drawing.Size(14, 16);
            this.lblIgualdad.TabIndex = 5;
            this.lblIgualdad.Text = "=";
            // 
            // gboxOperaciones
            // 
            this.gboxOperaciones.Controls.Add(this.rbnDivision);
            this.gboxOperaciones.Controls.Add(this.rbnMultiplicacion);
            this.gboxOperaciones.Controls.Add(this.rbnResta);
            this.gboxOperaciones.Controls.Add(this.rbnSuma);
            this.gboxOperaciones.Location = new System.Drawing.Point(37, 170);
            this.gboxOperaciones.Name = "gboxOperaciones";
            this.gboxOperaciones.Size = new System.Drawing.Size(230, 163);
            this.gboxOperaciones.TabIndex = 6;
            this.gboxOperaciones.TabStop = false;
            this.gboxOperaciones.Text = "Selecione una opcion";
            this.gboxOperaciones.Enter += new System.EventHandler(this.gboxOperaciones_Enter);
            // 
            // rbnSuma
            // 
            this.rbnSuma.AutoSize = true;
            this.rbnSuma.Location = new System.Drawing.Point(6, 21);
            this.rbnSuma.Name = "rbnSuma";
            this.rbnSuma.Size = new System.Drawing.Size(63, 20);
            this.rbnSuma.TabIndex = 7;
            this.rbnSuma.TabStop = true;
            this.rbnSuma.Text = "Suma";
            this.rbnSuma.UseVisualStyleBackColor = true;
            this.rbnSuma.CheckedChanged += new System.EventHandler(this.rbnSuma_CheckedChanged);
            // 
            // rbnResta
            // 
            this.rbnResta.AutoSize = true;
            this.rbnResta.Location = new System.Drawing.Point(6, 47);
            this.rbnResta.Name = "rbnResta";
            this.rbnResta.Size = new System.Drawing.Size(64, 20);
            this.rbnResta.TabIndex = 8;
            this.rbnResta.TabStop = true;
            this.rbnResta.Text = "Resta";
            this.rbnResta.UseVisualStyleBackColor = true;
            this.rbnResta.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbnMultiplicacion
            // 
            this.rbnMultiplicacion.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.rbnMultiplicacion.AutoSize = true;
            this.rbnMultiplicacion.Location = new System.Drawing.Point(6, 73);
            this.rbnMultiplicacion.Name = "rbnMultiplicacion";
            this.rbnMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbnMultiplicacion.TabIndex = 9;
            this.rbnMultiplicacion.TabStop = true;
            this.rbnMultiplicacion.Text = "Multiplicacion";
            this.rbnMultiplicacion.UseVisualStyleBackColor = true;
            this.rbnMultiplicacion.CheckedChanged += new System.EventHandler(this.rbnMultiplicacion_CheckedChanged);
            // 
            // rbnDivision
            // 
            this.rbnDivision.AutoSize = true;
            this.rbnDivision.Location = new System.Drawing.Point(6, 99);
            this.rbnDivision.Name = "rbnDivision";
            this.rbnDivision.Size = new System.Drawing.Size(76, 20);
            this.rbnDivision.TabIndex = 10;
            this.rbnDivision.TabStop = true;
            this.rbnDivision.Text = "Division";
            this.rbnDivision.UseVisualStyleBackColor = true;
            this.rbnDivision.CheckedChanged += new System.EventHandler(this.rbnDivision_CheckedChanged);
            // 
            // Pract8EstrcuturaIf3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxOperaciones);
            this.Controls.Add(this.lblIgualdad);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Pract8EstrcuturaIf3";
            this.Text = "PRÁCTICA DE ESTRUCTURA IF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxOperaciones.ResumeLayout(false);
            this.gboxOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblIgualdad;
        private System.Windows.Forms.GroupBox gboxOperaciones;
        private System.Windows.Forms.RadioButton rbnDivision;
        private System.Windows.Forms.RadioButton rbnMultiplicacion;
        private System.Windows.Forms.RadioButton rbnResta;
        private System.Windows.Forms.RadioButton rbnSuma;
    }
}

