using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim.Modelo
{
    internal class Controle
    {
        // Método para validar a resposta de um grupo de perguntas em relação a uma resposta correta.
        public void ValidarResposta(GroupBox groupBox, string respostaCorreta)
        {
            Validacao validacao = new Validacao();
            validacao.ValidarResposta(groupBox, respostaCorreta);
        }
    }
}
