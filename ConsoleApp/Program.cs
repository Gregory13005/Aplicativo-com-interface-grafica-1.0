using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using negocio.operador;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, resultado;
            string operador;
            Operador objOperador = new Operador();
            try
            {
                Console.WriteLine("Entrar com o valor 1: ");
                valor1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Entrar com o valor 2: ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Entrar com o operador: +, -, *, / ");
                operador = Console.ReadLine();

                if ((operador == "+") || (operador == "-") || (operador == "*") || (operador == "/"))
                {
                    resultado = objOperador.RealizarOperacao(valor1, valor2, operador);
                    Console.WriteLine("O resultado da operação é: " + resultado);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Operador inválido");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro - " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
