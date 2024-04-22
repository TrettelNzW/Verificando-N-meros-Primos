using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo.Modelo
{
    internal class Primo
    {
        private string mensagem;
        private int num;

        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }
        private void Verificar()
        {
            this.mensagem = "É Primo";
            if (num <= 1) mensagem = "Não é Primo";

            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % 1 == 0)
                {
                    mensagem = "Não é Primo";
                    break;
                }
            }
        }
        public string Mensagem
        {
            get { return mensagem; }
        }

    }
}
