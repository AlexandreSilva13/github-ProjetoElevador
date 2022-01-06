using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {


            Elevador elevador = new Elevador();

            Console.WriteLine("Seja bem vindo ao Elevador Jornada Microsolft");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Digite a quantidade de andares");
            string totalAndares = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Digite a capacidade do elevador");
            string capacidadeElevador = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");

            #region Laço de repetição

            int numero = 0;
            do

            {
                Console.WriteLine("1 Digite para Inicializar");
                Console.WriteLine("2 Digite para entrar");
                Console.WriteLine("3 digite para sair");
                Console.WriteLine("4 digite para subir");
                Console.WriteLine("5 digite para Descer");
                Console.WriteLine("6 digite para finalizar");
                string textoDigitado = Console.ReadLine();
                numero = Convert.ToInt32(textoDigitado);

                elevador.Inicializar(Convert.ToInt32(capacidadeElevador), Convert.ToInt32(totalAndares));
                Console.WriteLine("Elevador Inicializado");
                Console.WriteLine("-------------------------------------------------");
                string retorno;
                
                switch (numero)
                { 
                    case 1:
                        elevador.Inicializar(Convert.ToInt32(capacidadeElevador), Convert.ToInt32(totalAndares));
                        break;

                    case 2:
                        retorno = elevador.Entrar();
                        Console.WriteLine(retorno);
                        break;

                    case 3:
                        retorno = elevador.Sair();
                        Console.WriteLine(retorno);
                        break;

                    case 4:
                        retorno = elevador.Subir();
                        Console.WriteLine(retorno);
                        break;

                    case 5:
                        retorno = elevador.Descer();
                        Console.WriteLine(retorno);
                        break;

                    case 6:
                        Console.WriteLine("Fim do programa");
                        break;

                    default:
                        Console.WriteLine("Numero incorreto");
                        break;
                }

            } while (numero != 6);   
            #endregion
    
        }
    }
}
