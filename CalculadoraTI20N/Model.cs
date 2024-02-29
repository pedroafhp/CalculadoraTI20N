using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Model
    {
        //Área de Variáveis
        private double num1;
        private double num2;

        //Método Construtor = Instancia as Váriaveis
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//Fim do Construtor

        //Métodos GET E SET
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }//Fim do GET E SET

        public double ConsultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }//Fim do GET E SET

        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;
        }//Fim do Método Somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }//Fim do Método Subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }//Fim do Método Multiplicar

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//Fim do Método Dividir

        public string Tabuada()
        {
            string resultado = "";

            resultado += "Tabuada de " + ConsultarNum1;
            for (int i=0; i <= 10; i++)
            {
                resultado += "\n" + ConsultarNum1 + " * " + i + " = " + (ConsultarNum1* i);
            }//Fim do For

            resultado += "\n\nTabuada de " + ConsultarNum2;
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + ConsultarNum2 + " * " + i + " = " + (ConsultarNum2 * i);
            }//Fim do For

            return resultado;
        }//Fim do Método Tabuada

        public string Raiz()
        {
            string resultado = "";

            resultado = "A raiz de " + ConsultarNum1 + " é: " + Math.Sqrt(ConsultarNum1) +
                        "\nA raiz de " + ConsultarNum2 + " é: " + Math.Sqrt(ConsultarNum2);

            return resultado;
        }//Fim do Raiz

        public double Potencia()
        {
            return Math.Pow(ConsultarNum1, ConsultarNum2);
        }//Fim do Potencia

    }//Fim da Classe
}//Fim do Projeto
