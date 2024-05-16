using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pim.Modelo
{
    public static class Estatico
    {
        public static int Valor { get; set; } = 0;

        // Define uma lista estática para armazenar strings utilizadas em pesquisas.
        public static List<string> ListaPesquisa = new List<string>();
    }
}

