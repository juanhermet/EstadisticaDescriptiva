namespace ProbabilidadYEstadística
{
    partial class Principal
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstbxNumerosAgregados = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblPrimerQ = new System.Windows.Forms.Label();
            this.lblTercerQ = new System.Windows.Forms.Label();
            this.lblMeda = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblDesvEst = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblRangoInter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAlejadoDef = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAlejadoExc = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCoefAsi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "agregue un número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(120, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(224, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstbxNumerosAgregados
            // 
            this.lstbxNumerosAgregados.FormattingEnabled = true;
            this.lstbxNumerosAgregados.Location = new System.Drawing.Point(393, 53);
            this.lstbxNumerosAgregados.Name = "lstbxNumerosAgregados";
            this.lstbxNumerosAgregados.Size = new System.Drawing.Size(155, 147);
            this.lstbxNumerosAgregados.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(85, 53);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 26);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mediana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primer Quartil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tercer Quartil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Varianza:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Desviación Estándar:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(202, 123);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 13;
            this.lblMedia.Text = "label9";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(202, 145);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(41, 13);
            this.lblMediana.TabIndex = 14;
            this.lblMediana.Text = "label10";
            // 
            // lblPrimerQ
            // 
            this.lblPrimerQ.AutoSize = true;
            this.lblPrimerQ.Location = new System.Drawing.Point(202, 167);
            this.lblPrimerQ.Name = "lblPrimerQ";
            this.lblPrimerQ.Size = new System.Drawing.Size(41, 13);
            this.lblPrimerQ.TabIndex = 15;
            this.lblPrimerQ.Text = "label11";
            // 
            // lblTercerQ
            // 
            this.lblTercerQ.AutoSize = true;
            this.lblTercerQ.Location = new System.Drawing.Point(202, 187);
            this.lblTercerQ.Name = "lblTercerQ";
            this.lblTercerQ.Size = new System.Drawing.Size(41, 13);
            this.lblTercerQ.TabIndex = 16;
            this.lblTercerQ.Text = "label12";
            // 
            // lblMeda
            // 
            this.lblMeda.AutoSize = true;
            this.lblMeda.Location = new System.Drawing.Point(202, 231);
            this.lblMeda.Name = "lblMeda";
            this.lblMeda.Size = new System.Drawing.Size(41, 13);
            this.lblMeda.TabIndex = 17;
            this.lblMeda.Text = "label13";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Location = new System.Drawing.Point(202, 253);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(41, 13);
            this.lblVarianza.TabIndex = 18;
            this.lblVarianza.Text = "label14";
            // 
            // lblDesvEst
            // 
            this.lblDesvEst.AutoSize = true;
            this.lblDesvEst.Location = new System.Drawing.Point(202, 275);
            this.lblDesvEst.Name = "lblDesvEst";
            this.lblDesvEst.Size = new System.Drawing.Size(41, 13);
            this.lblDesvEst.TabIndex = 19;
            this.lblDesvEst.Text = "label15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Listado de números agregados:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(367, 238);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 39);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblRangoInter
            // 
            this.lblRangoInter.AutoSize = true;
            this.lblRangoInter.Location = new System.Drawing.Point(202, 209);
            this.lblRangoInter.Name = "lblRangoInter";
            this.lblRangoInter.Size = new System.Drawing.Size(41, 13);
            this.lblRangoInter.TabIndex = 23;
            this.lblRangoInter.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rango Intercuartil:";
            // 
            // lblAlejadoDef
            // 
            this.lblAlejadoDef.AutoSize = true;
            this.lblAlejadoDef.Location = new System.Drawing.Point(202, 299);
            this.lblAlejadoDef.Name = "lblAlejadoDef";
            this.lblAlejadoDef.Size = new System.Drawing.Size(41, 13);
            this.lblAlejadoDef.TabIndex = 25;
            this.lblAlejadoDef.Text = "label15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Valor alejado por defecto:";
            // 
            // lblAlejadoExc
            // 
            this.lblAlejadoExc.AutoSize = true;
            this.lblAlejadoExc.Location = new System.Drawing.Point(202, 321);
            this.lblAlejadoExc.Name = "lblAlejadoExc";
            this.lblAlejadoExc.Size = new System.Drawing.Size(41, 13);
            this.lblAlejadoExc.TabIndex = 27;
            this.lblAlejadoExc.Text = "label15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Valor alejado por exceso:";
            // 
            // lblCoefAsi
            // 
            this.lblCoefAsi.AutoSize = true;
            this.lblCoefAsi.Location = new System.Drawing.Point(204, 343);
            this.lblCoefAsi.Name = "lblCoefAsi";
            this.lblCoefAsi.Size = new System.Drawing.Size(41, 13);
            this.lblCoefAsi.TabIndex = 29;
            this.lblCoefAsi.Text = "label15";
            this.lblCoefAsi.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Coeficiente de asimetría:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 390);
            this.Controls.Add(this.lblCoefAsi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblAlejadoExc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblAlejadoDef);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRangoInter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDesvEst);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblMeda);
            this.Controls.Add(this.lblTercerQ);
            this.Controls.Add(this.lblPrimerQ);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstbxNumerosAgregados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstbxNumerosAgregados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblPrimerQ;
        private System.Windows.Forms.Label lblTercerQ;
        private System.Windows.Forms.Label lblMeda;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblDesvEst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblRangoInter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAlejadoDef;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAlejadoExc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCoefAsi;
        private System.Windows.Forms.Label label12;
    }
}

