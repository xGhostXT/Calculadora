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
            txtVisual = new TextBox();
            lblGXT = new Label();
            lblEC = new Label();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnPunto = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnIgual = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnResta = new Button();
            btnSuma = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtVisual
            // 
            txtVisual.Font = new Font("Segoe UI", 12F);
            txtVisual.Location = new Point(22, 49);
            txtVisual.Multiline = true;
            txtVisual.Name = "txtVisual";
            txtVisual.Size = new Size(220, 36);
            txtVisual.TabIndex = 0;
            txtVisual.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGXT
            // 
            lblGXT.AutoSize = true;
            lblGXT.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGXT.Location = new Point(107, 9);
            lblGXT.Name = "lblGXT";
            lblGXT.Size = new Size(45, 22);
            lblGXT.TabIndex = 1;
            lblGXT.Text = "GXT";
            lblGXT.Click += label1_Click;
            // 
            // lblEC
            // 
            lblEC.AutoSize = true;
            lblEC.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEC.Location = new Point(54, 31);
            lblEC.Name = "lblEC";
            lblEC.Size = new Size(140, 15);
            lblEC.TabIndex = 2;
            lblEC.Text = "ELECTRONIC CALCULATOR";
            lblEC.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 12F);
            btn7.Location = new Point(22, 91);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 36);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 12F);
            btn4.Location = new Point(22, 133);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 36);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 12F);
            btn1.Location = new Point(22, 175);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 36);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 12F);
            btn0.Location = new Point(22, 217);
            btn0.Name = "btn0";
            btn0.Size = new Size(51, 36);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Microsoft Sans Serif", 18F);
            btnPunto.Location = new Point(79, 217);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(51, 36);
            btnPunto.TabIndex = 16;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 12F);
            btn2.Location = new Point(79, 175);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 36);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 12F);
            btn5.Location = new Point(79, 133);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 36);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 12F);
            btn8.Location = new Point(79, 91);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 36);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Microsoft Sans Serif", 18F);
            btnIgual.Location = new Point(136, 217);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(51, 36);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 12F);
            btn3.Location = new Point(136, 175);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 36);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 12F);
            btn6.Location = new Point(136, 133);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 36);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 12F);
            btn9.Location = new Point(136, 91);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 36);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Microsoft Sans Serif", 16F);
            btnMultiplicar.Location = new Point(191, 133);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(51, 36);
            btnMultiplicar.TabIndex = 22;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Microsoft Sans Serif", 18F);
            btnDividir.Location = new Point(191, 91);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(51, 36);
            btnDividir.TabIndex = 21;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Microsoft Sans Serif", 18F);
            btnResta.Location = new Point(191, 175);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(51, 36);
            btnResta.TabIndex = 23;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Microsoft Sans Serif", 18F);
            btnSuma.Location = new Point(191, 217);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(51, 36);
            btnSuma.TabIndex = 24;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(79, 259);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 33);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(267, 306);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSuma);
            Controls.Add(btnResta);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnIgual);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnPunto);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(lblEC);
            Controls.Add(lblGXT);
            Controls.Add(txtVisual);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisual;
        private Label lblGXT;
        private Label lblEC;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btnPunto;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnIgual;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnResta;
        private Button btnSuma;
        private Button btnLimpiar;
    }
}
