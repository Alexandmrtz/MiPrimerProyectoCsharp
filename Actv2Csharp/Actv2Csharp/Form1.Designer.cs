namespace Actv2Csharp
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.GrbOpciones = new System.Windows.Forms.GroupBox();
            this.OptResta = new System.Windows.Forms.RadioButton();
            this.OptExponenciacion = new System.Windows.Forms.RadioButton();
            this.OptPorcentaje = new System.Windows.Forms.RadioButton();
            this.OptDivision = new System.Windows.Forms.RadioButton();
            this.OptMultiplicacion = new System.Windows.Forms.RadioButton();
            this.OptSuma = new System.Windows.Forms.RadioButton();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcularOpciones = new System.Windows.Forms.Button();
            this.OptPrimo = new System.Windows.Forms.RadioButton();
            this.OptFactorial = new System.Windows.Forms.RadioButton();
            this.GrbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(53, 56);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(104, 33);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(182, 56);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(225, 40);
            this.txtNum1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(59, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(190, 57);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(182, 111);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(225, 40);
            this.txtNum2.TabIndex = 4;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(53, 114);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(104, 33);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Num2:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(53, 200);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(191, 33);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta: ?";
            // 
            // GrbOpciones
            // 
            this.GrbOpciones.Controls.Add(this.OptFactorial);
            this.GrbOpciones.Controls.Add(this.OptPrimo);
            this.GrbOpciones.Controls.Add(this.OptResta);
            this.GrbOpciones.Controls.Add(this.OptExponenciacion);
            this.GrbOpciones.Controls.Add(this.OptPorcentaje);
            this.GrbOpciones.Controls.Add(this.OptDivision);
            this.GrbOpciones.Controls.Add(this.OptMultiplicacion);
            this.GrbOpciones.Controls.Add(this.OptSuma);
            this.GrbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbOpciones.Location = new System.Drawing.Point(446, 56);
            this.GrbOpciones.Name = "GrbOpciones";
            this.GrbOpciones.Size = new System.Drawing.Size(271, 421);
            this.GrbOpciones.TabIndex = 6;
            this.GrbOpciones.TabStop = false;
            this.GrbOpciones.Text = "Opciones";
            // 
            // OptResta
            // 
            this.OptResta.AutoSize = true;
            this.OptResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptResta.Location = new System.Drawing.Point(18, 106);
            this.OptResta.Name = "OptResta";
            this.OptResta.Size = new System.Drawing.Size(113, 36);
            this.OptResta.TabIndex = 5;
            this.OptResta.TabStop = true;
            this.OptResta.Text = "Resta";
            this.OptResta.UseVisualStyleBackColor = true;
            // 
            // OptExponenciacion
            // 
            this.OptExponenciacion.AutoSize = true;
            this.OptExponenciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptExponenciacion.Location = new System.Drawing.Point(18, 232);
            this.OptExponenciacion.Name = "OptExponenciacion";
            this.OptExponenciacion.Size = new System.Drawing.Size(242, 36);
            this.OptExponenciacion.TabIndex = 4;
            this.OptExponenciacion.TabStop = true;
            this.OptExponenciacion.Text = "Exponenciación";
            this.OptExponenciacion.UseVisualStyleBackColor = true;
            // 
            // OptPorcentaje
            // 
            this.OptPorcentaje.AutoSize = true;
            this.OptPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptPorcentaje.Location = new System.Drawing.Point(18, 274);
            this.OptPorcentaje.Name = "OptPorcentaje";
            this.OptPorcentaje.Size = new System.Drawing.Size(176, 36);
            this.OptPorcentaje.TabIndex = 3;
            this.OptPorcentaje.TabStop = true;
            this.OptPorcentaje.Text = "Porcentaje";
            this.OptPorcentaje.UseVisualStyleBackColor = true;
            // 
            // OptDivision
            // 
            this.OptDivision.AutoSize = true;
            this.OptDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptDivision.Location = new System.Drawing.Point(18, 190);
            this.OptDivision.Name = "OptDivision";
            this.OptDivision.Size = new System.Drawing.Size(140, 36);
            this.OptDivision.TabIndex = 2;
            this.OptDivision.TabStop = true;
            this.OptDivision.Text = "División";
            this.OptDivision.UseVisualStyleBackColor = true;
            // 
            // OptMultiplicacion
            // 
            this.OptMultiplicacion.AutoSize = true;
            this.OptMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptMultiplicacion.Location = new System.Drawing.Point(18, 148);
            this.OptMultiplicacion.Name = "OptMultiplicacion";
            this.OptMultiplicacion.Size = new System.Drawing.Size(213, 36);
            this.OptMultiplicacion.TabIndex = 1;
            this.OptMultiplicacion.TabStop = true;
            this.OptMultiplicacion.Text = "Multiplicación";
            this.OptMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // OptSuma
            // 
            this.OptSuma.AutoSize = true;
            this.OptSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptSuma.Location = new System.Drawing.Point(18, 55);
            this.OptSuma.Name = "OptSuma";
            this.OptSuma.Size = new System.Drawing.Size(113, 36);
            this.OptSuma.TabIndex = 0;
            this.OptSuma.TabStop = true;
            this.OptSuma.Text = "Suma";
            this.OptSuma.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta ",
            "Multiplicacion",
            "Division",
            "Factorial",
            "Primo"});
            this.cboOpciones.Location = new System.Drawing.Point(763, 102);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(153, 28);
            this.cboOpciones.TabIndex = 7;
            // 
            // btnCalcularOpciones
            // 
            this.btnCalcularOpciones.Location = new System.Drawing.Point(790, 182);
            this.btnCalcularOpciones.Name = "btnCalcularOpciones";
            this.btnCalcularOpciones.Size = new System.Drawing.Size(109, 50);
            this.btnCalcularOpciones.TabIndex = 8;
            this.btnCalcularOpciones.Text = "Calcular";
            this.btnCalcularOpciones.UseVisualStyleBackColor = true;
            this.btnCalcularOpciones.Click += new System.EventHandler(this.btnCalcularOpciones_Click);
            // 
            // OptPrimo
            // 
            this.OptPrimo.AutoSize = true;
            this.OptPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptPrimo.Location = new System.Drawing.Point(18, 316);
            this.OptPrimo.Name = "OptPrimo";
            this.OptPrimo.Size = new System.Drawing.Size(113, 36);
            this.OptPrimo.TabIndex = 6;
            this.OptPrimo.TabStop = true;
            this.OptPrimo.Text = "Primo";
            this.OptPrimo.UseVisualStyleBackColor = true;
            // 
            // OptFactorial
            // 
            this.OptFactorial.AutoSize = true;
            this.OptFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptFactorial.Location = new System.Drawing.Point(18, 358);
            this.OptFactorial.Name = "OptFactorial";
            this.OptFactorial.Size = new System.Drawing.Size(149, 36);
            this.OptFactorial.TabIndex = 7;
            this.OptFactorial.TabStop = true;
            this.OptFactorial.Text = "Factorial";
            this.OptFactorial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.btnCalcularOpciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.GrbOpciones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrbOpciones.ResumeLayout(false);
            this.GrbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox GrbOpciones;
        private System.Windows.Forms.RadioButton OptSuma;
        private System.Windows.Forms.RadioButton OptResta;
        private System.Windows.Forms.RadioButton OptExponenciacion;
        private System.Windows.Forms.RadioButton OptPorcentaje;
        private System.Windows.Forms.RadioButton OptDivision;
        private System.Windows.Forms.RadioButton OptMultiplicacion;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnCalcularOpciones;
        private System.Windows.Forms.RadioButton OptPrimo;
        private System.Windows.Forms.RadioButton OptFactorial;
    }
}
