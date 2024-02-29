using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Control
    {
        //Criei uma Conexão com a Classe Model
        Model mod;

            public Control()
        {
            mod = new Model();//Chamando o Construtor da Classe Model
        }//Fim do Construtor

        public string Menu()
        {
            string msg = "#### Menu ####\n\n" +
                         "0. Sair\n"          +
                         "1. Somar\n"         +
                         "2. Subtrair\n"      +
                         "3. Multiplicar\n"   +
                         "4. Dividir\n"       +
                         "5. Tabuada\n"       +
                         "6. Raiz\n"          +
                         "7. Potência\n"      +
                         "Escolha uma das opções acima:";
            return msg;
        }//Fim do Menu

        public void Operacao()
        {
            int opcao;
            do
            {
                Console.WriteLine(Menu());//Mostrar as Opções na Tela
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Chamando o Método para Coleta
                        Console.WriteLine("A soma dos valores digitados é: " + mod.Somar());
                        break;
                    case 2:
                        Coletar();
                        mod.Subtrair();
                        Console.WriteLine("A subtração dos valores digitados é: " + mod.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        mod.Multiplicar();
                        Console.WriteLine("A multiplicação dos valores digitados é: " + mod.Multiplicar());
                        break;
                    case 4:
                        Coletar();
                        if (mod.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão dos valores digitados é: " + mod.Dividir());
                        }
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Tabuada: " + mod.Tabuada());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(mod.Raiz());
                        break;
                    case 7:
                        Coletar();
                        Console.WriteLine("A Potência é: " + mod.Potencia());
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }//Fim do Switch
            } while (opcao != 0);
        }//Fim do Operacao

        public void Coletar()
        {
            //Coletando o Primeiro Número
            Console.WriteLine("Informe o primeiro número");
            mod.ConsultarNum1= Convert.ToDouble(Console.ReadLine());

            //Coletando o Segundo Número
            Console.WriteLine("Informe o segundo número");
            mod.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do Método Coletar

    }//Fim da Classe
}//Fim do Projeto
