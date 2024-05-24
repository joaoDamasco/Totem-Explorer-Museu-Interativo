using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pim.Modelo
{
    public static class Estatico
    {
        public static int Valor { get; set; } = 0;
        public static int Avaliacao { get; set; } = 0;
 
        // Define uma lista estática para armazenar strings utilizadas em pesquisas.
        public static List<string> ListaPesquisa = new List<string>();

        // Vetor estático para armazenar nomes e idades
        public static (string Nome, int Idade, int Pontuacao)[] Pessoas = new (string Nome, int Idade, int pontuacao)[]
        {
            ("Matheus", 30, 2),
            ("Cipriano", 20, 5),
            ("Rian", 40, 3),
            ("Leticia", 60, 0)
        };

    }
}

