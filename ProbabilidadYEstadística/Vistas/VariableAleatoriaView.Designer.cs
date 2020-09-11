namespace ProbabilidadYEstadística
{
    partial class VariableAleatoriaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariableAleatoriaView));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstbxNumerosAgregados = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEsperanza = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(385, 237);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 39);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "x - p(x)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(37, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 26);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstbxNumerosAgregados
            // 
            this.lstbxNumerosAgregados.FormattingEnabled = true;
            this.lstbxNumerosAgregados.Location = new System.Drawing.Point(393, 52);
            this.lstbxNumerosAgregados.Name = "lstbxNumerosAgregados";
            this.lstbxNumerosAgregados.Size = new System.Drawing.Size(155, 147);
            this.lstbxNumerosAgregados.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 87);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "agregar dupla";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(162, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "agregue el valor:";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(162, 49);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(78, 20);
            this.txtFuncion.TabIndex = 1;
            this.txtFuncion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFuncion_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "agregue su p(x):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Esperanza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Varianza:";
            // 
            // lblEsperanza
            // 
            this.lblEsperanza.AutoSize = true;
            this.lblEsperanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperanza.Location = new System.Drawing.Point(123, 209);
            this.lblEsperanza.Name = "lblEsperanza";
            this.lblEsperanza.Size = new System.Drawing.Size(60, 24);
            this.lblEsperanza.TabIndex = 49;
            this.lblEsperanza.Text = "label1";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.Location = new System.Drawing.Point(123, 252);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(60, 24);
            this.lblVarianza.TabIndex = 50;
            this.lblVarianza.Text = "label2";
            // 
            // VariableAleatoriaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 312);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblEsperanza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstbxNumerosAgregados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VariableAleatoriaView";
            this.Text = "Variables Aleatorias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VariableAleatoriaView_FormClosed);
            this.Load += new System.EventHandler(this.VariableAleatoriaView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstbxNumerosAgregados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEsperanza;
        private System.Windows.Forms.Label lblVarianza;
    }
}