namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;
        private int op;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + "9";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            op = 4;
            valor1 = Convert.ToDouble(txtVisual.Text);
            txtVisual.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            op = 3;
            valor1 = Convert.ToDouble(txtVisual.Text);
            txtVisual.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            op = 2;
            valor1 = Convert.ToDouble(txtVisual.Text);
            txtVisual.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            op = 1;
            valor1 = Convert.ToDouble(txtVisual.Text);
            txtVisual.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtVisual.Text);

            switch (op)
            {
                //Suma
                case 1: resultado = valor1 + valor2;
                break;
                
                //Resta
                case 2: resultado = valor1 - valor2;
                break;
                
                //Multiplicacion                    
                case 3: resultado = valor1 * valor2;
                break;

                //Division    
                case 4: resultado = valor1 / valor2;
                break;
            }

            txtVisual.Text = resultado.ToString();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtVisual.Text = txtVisual.Text + ".";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVisual.Text = "";
        }
    }
}
