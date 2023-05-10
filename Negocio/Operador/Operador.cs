using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocio.operador
{
    public class Operador
    {
        double resultado;
        public double RealizarOperacao(double valor1, double valor2, string operador)
        {
            try
            {
                switch (operador)
                {
                    case ("+"):
                        resultado = RealizarSoma(valor1, valor2);
                        break;
                    case ("-"):
                        resultado = RealizarSubtracao(valor1, valor2);
                        break;
                    case ("*"):
                        resultado = RealizarMultiplicacao(valor1, valor2);
                        break;
                    case ("/"):
                        resultado = RealizarDivisao(valor1, valor2);
                        break;
                    default:
                        break;
                }
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double RealizarDivisao(double valor1, double valor2)
        {
            try
            {
                resultado = valor1 / valor2;
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double RealizarMultiplicacao(double valor1, double valor2)
        {
            try
            {
                resultado = valor1 * valor2;
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double RealizarSubtracao(double valor1, double valor2)
        {
            try
            {
                resultado = valor1 - valor2;
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private double RealizarSoma(double valor1, double valor2)
        {
            try
            {
                resultado = valor1 + valor2;
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
