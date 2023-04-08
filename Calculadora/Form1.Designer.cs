namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.rbAvanzado = new System.Windows.Forms.RadioButton();
            this.lbAvanzado = new System.Windows.Forms.ListBox();
            this.cbBasico = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalculadora.Location = new System.Drawing.Point(105, 57);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(101, 21);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "Calculadora";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(36, 96);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(63, 15);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(36, 125);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(63, 15);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Numero 2:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(105, 94);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 23);
            this.num1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(105, 123);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 23);
            this.num2.TabIndex = 4;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Location = new System.Drawing.Point(290, 60);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(59, 19);
            this.rbBasico.TabIndex = 5;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.CheckedChanged += new System.EventHandler(this.rbBasico_CheckedChanged);
            // 
            // rbAvanzado
            // 
            this.rbAvanzado.AutoSize = true;
            this.rbAvanzado.Location = new System.Drawing.Point(474, 60);
            this.rbAvanzado.Name = "rbAvanzado";
            this.rbAvanzado.Size = new System.Drawing.Size(77, 19);
            this.rbAvanzado.TabIndex = 6;
            this.rbAvanzado.TabStop = true;
            this.rbAvanzado.Text = "Avanzado";
            this.rbAvanzado.UseVisualStyleBackColor = true;
            this.rbAvanzado.CheckedChanged += new System.EventHandler(this.rbAvanzado_CheckedChanged);
            // 
            // lbAvanzado
            // 
            this.lbAvanzado.Enabled = false;
            this.lbAvanzado.FormattingEnabled = true;
            this.lbAvanzado.ItemHeight = 15;
            this.lbAvanzado.Items.AddRange(new object[] {
            "Multiplicación",
            "División"});
            this.lbAvanzado.Location = new System.Drawing.Point(456, 91);
            this.lbAvanzado.Name = "lbAvanzado";
            this.lbAvanzado.Size = new System.Drawing.Size(121, 49);
            this.lbAvanzado.TabIndex = 7;
            // 
            // cbBasico
            // 
            this.cbBasico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasico.Enabled = false;
            this.cbBasico.FormattingEnabled = true;
            this.cbBasico.Items.AddRange(new object[] {
            "Suma",
            "Resta"});
            this.cbBasico.Location = new System.Drawing.Point(277, 91);
            this.cbBasico.Name = "cbBasico";
            this.cbBasico.Size = new System.Drawing.Size(121, 23);
            this.cbBasico.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(348, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 247);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbBasico);
            this.Controls.Add(this.lbAvanzado);
            this.Controls.Add(this.rbAvanzado);
            this.Controls.Add(this.rbBasico);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCalculadora;
        private Label lblNum1;
        private Label lblNum2;
        private NumericUpDown num1;
        private NumericUpDown num2;
        private RadioButton rbBasico;
        private RadioButton rbAvanzado;
        private ListBox lbAvanzado;
        private ComboBox cbBasico;
        private Button btnCalcular;
    }
}