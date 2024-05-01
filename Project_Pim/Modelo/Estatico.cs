using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim.Modelo
{
    public static class Estatico
    {
        // Declaração de variáveis estáticas para armazenar respostas
        public static string Resposta1;
        public static string Resposta2;
        public static string Resposta3;
        public static string Resposta4;
        public static string Resposta5;

        public static List<string> ListaPesquisa = new List<string>();
    }

    public static class VerificadorResposta
    {
        // Método para verificar e pintar de vermelho os RadioButton respondio errado
        public static void PintarRespostaIncorreta(GroupBox groupBox, string respostaCorreta)
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
