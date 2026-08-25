namespace Pract2_Descuentos
{
    partial class PracticaDeVentas
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDinDescuento = new System.Windows.Forms.Label();
            this.lblPorDescuento = new System.Windows.Forms.Label();
            this.lblPrecioF = new System.Windows.Forms.Label();
            this.txtDinDescuento = new System.Windows.Forms.TextBox();
            this.txtPorDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecioF = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 29);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 16);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor Venta";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(111, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(404, 22);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDinDescuento
            // 
            this.lblDinDescuento.AutoSize = true;
            this.lblDinDescuento.Location = new System.Drawing.Point(13, 81);
            this.lblDinDescuento.Name = "lblDinDescuento";
            this.lblDinDescuento.Size = new System.Drawing.Size(82, 16);
            this.lblDinDescuento.TabIndex = 3;
            this.lblDinDescuento.Text = "Descuento $";
            // 
            // lblPorDescuento
            // 
            this.lblPorDescuento.AutoSize = true;
            this.lblPorDescuento.Location = new System.Drawing.Point(13, 148);
            this.lblPorDescuento.Name = "lblPorDescuento";
            this.lblPorDescuento.Size = new System.Drawing.Size(87, 16);
            this.lblPorDescuento.TabIndex = 4;
            this.lblPorDescuento.Text = "Descuento %";
            // 
            // lblPrecioF
            // 
            this.lblPrecioF.AutoSize = true;
            this.lblPrecioF.Location = new System.Drawing.Point(13, 204);
            this.lblPrecioF.Name = "lblPrecioF";
            this.lblPrecioF.Size = new System.Drawing.Size(74, 16);
            this.lblPrecioF.TabIndex = 5;
            this.lblPrecioF.Text = "Venta Final";
            // 
            // txtDinDescuento
            // 
            this.txtDinDescuento.Location = new System.Drawing.Point(111, 75);
            this.txtDinDescuento.Name = "txtDinDescuento";
            this.txtDinDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDinDescuento.TabIndex = 6;
            this.txtDinDescuento.TextChanged += new System.EventHandler(this.txtDinDescuento_TextChanged);
            // 
            // txtPorDescuento
            // 
            this.txtPorDescuento.Location = new System.Drawing.Point(111, 145);
            this.txtPorDescuento.Name = "txtPorDescuento";
            this.txtPorDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtPorDescuento.TabIndex = 7;
            // 
            // txtPrecioF
            // 
            this.txtPrecioF.Location = new System.Drawing.Point(111, 201);
            this.txtPrecioF.Name = "txtPrecioF";
            this.txtPrecioF.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioF.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(404, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(404, 167);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PracticaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPrecioF);
            this.Controls.Add(this.txtPorDescuento);
            this.Controls.Add(this.txtDinDescuento);
            this.Controls.Add(this.lblPrecioF);
            this.Controls.Add(this.lblPorDescuento);
            this.Controls.Add(this.lblDinDescuento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "PracticaDeVentas";
            this.Text = "Elaborado por: (debe escribir su Descuentos - Programado por: Julian Mosquera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDinDescuento;
        private System.Windows.Forms.Label lblPorDescuento;
        private System.Windows.Forms.Label lblPrecioF;
        private System.Windows.Forms.TextBox txtDinDescuento;
        private System.Windows.Forms.TextBox txtPorDescuento;
        private System.Windows.Forms.TextBox txtPrecioF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

