namespace WinFormsApp1
using System negocio.operador;
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(txtValor1.Text);

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void iblSair_Click(object sender, EventArgs e)
        {
            Close()
        }
    }
}