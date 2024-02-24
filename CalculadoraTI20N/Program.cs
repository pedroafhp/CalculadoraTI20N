using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control controle = new Control();
            controle.Operacao();//Chamou o Método Principal

            Console.ReadLine();//Ler - Manter a tela aberta
        }//Fim do Método
    }//Fim da Classe
}//Fim do Projeto
