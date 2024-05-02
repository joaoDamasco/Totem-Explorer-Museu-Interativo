using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim.Modelo
{
    internal class Validacao
    {
        public void ValidarResposta(GroupBox groupBox, string respostaCorreta)
        {
            foreach (RadioButton item in groupBox.Controls.OfType<RadioButton>())
            {
                // Verifica se o texto do RadioButton corresponde à resposta correta e se ele não está marcado
                if (item.Text.Substring(0, 1).Equals(respostaCorreta) && !item.Checked)
                {
                    // pinta o texto do RadioButton de vermelho
                    item.ForeColor = Color.Red;
                }
            }
        }
    }
}
