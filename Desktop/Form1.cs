using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using negocio.operador;

namespace Desktop
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnRealizarOperacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            Operador objOperador = new Operador();

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);
            resultado = objOperador.RealizarOperacao(valor1, valor2, txtOperador.Text);

            MessageBox.Show("O Resultado É:" + resultado);
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
