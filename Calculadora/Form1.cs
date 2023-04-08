namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBasico_CheckedChanged(object sender, EventArgs e)
        {
            cbBasico.Enabled = true;
            lbAvanzado.Enabled = false;
        }

        private void rbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            cbBasico.Enabled = false;
            lbAvanzado.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbBasico.Checked == false && rbAvanzado.Checked == false) {
                MessageBox.Show("Seleccione una opción (Básico o Avanzado)");
            }
            if (cbBasico.Enabled == true) {
                if (cbBasico.Text == ""){
                    MessageBox.Show("Seleccione una opción (Suma o Resta)");
                }
                if (cbBasico.Text == "Suma") {
                    int suma = Convert.ToInt32(num1.Value) + Convert.ToInt32(num2.Value);
                    MessageBox.Show("La suma es: " + suma);
                }
                else if (cbBasico.Text == "Resta") {
                    int resta = Convert.ToInt32(num1.Value) - Convert.ToInt32(num2.Value);
                    MessageBox.Show("La resta es: " + resta);
                }
            }
            else if (lbAvanzado.Enabled == true) {
                if (lbAvanzado.Text == "Multiplicación") {
                    int multiplicacion = Convert.ToInt32(num1.Value) * Convert.ToInt32(num2.Value);
                    MessageBox.Show("La multiplicacion es: " + multiplicacion);
                }
                else if (lbAvanzado.Text == "División") {
                    int division = Convert.ToInt32(num1.Value) / Convert.ToInt32(num2.Value);
                    MessageBox.Show("La division es: " + division);
                }
            }
        }
    }
}