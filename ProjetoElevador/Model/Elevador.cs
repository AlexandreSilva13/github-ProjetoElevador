using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model

{


    public class Elevador
    {
        public Elevador() // Contrutor
        {
            AndarAtual = 0;
            QtdPessoas = 0;
        }

        #region criando as propriedades
        public int AndarAtual { get; set; }
        public int TotalAndares { get; set; }
        public int QtdPessoas { get; set; }
        public int CapacidadeElevador { get; set; }
        #endregion

        #region Criando os Metodos
        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            CapacidadeElevador = capacidadeElevador;
            TotalAndares = totalAndares;
        }

        public string Entrar()
        {
            if (QtdPessoas <= CapacidadeElevador)
            {
                QtdPessoas++;
                if (AndarAtual == 0)
                    return "Entrou uma pessoa, elevador no térreo e tem " + QtdPessoas + " pessoa(s) no elevador";
                else
                    return "Entrou uma pessoa, elevador no " + AndarAtual + "º andar e tem " + QtdPessoas + " pessoa(s) no elevador";
            }
            else
            {
                return "Elevador cheio,favor aguardar o próximo";

            }
        }

        public string Sair()
        {
            if (QtdPessoas > 0)
            {

                QtdPessoas--;
                return "Saiu uma pessoa, elevador no " + AndarAtual + "º andar e tem " + QtdPessoas + " pessoa(s) no elevador";
            }

            else
            {
                return "Elevador vazio";

            }
        }

        public string Subir()
        {
            if (AndarAtual <= TotalAndares)
            {
                AndarAtual++;
                return "Subiu um andar, atualmente ele está no " + AndarAtual + "º andar e tem " + QtdPessoas + " pessoa(s) no elevador";
            }

            else
            {
                return "Elevador não pode subir,já está no ultimo andar e tem ocupação de " + QtdPessoas + " pessoa(s) no elevador";

            }
        }

        public string Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                return "Desceu um andar, atualmente ele está no " + AndarAtual + "º andar e tem " + QtdPessoas + " pessoa(s) no elevador";

            }
            else
            {
                return "Elevador não pode descer, já está no térreo";

            }
        }
        #endregion
    }


}


