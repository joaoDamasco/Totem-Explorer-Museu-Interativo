using Project_Pim.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim
{
    public partial class FrmPesquisa : Form
    {
        public FrmPesquisa()
        {
            InitializeComponent();

        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            // Adiciona o texto do botão
            rtbPesquisa.Text += (sender as Button).Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa campo de texto
            rtbPesquisa.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Remove o último caractere
            if (rtbPesquisa.Text != "")
            {
                rtbPesquisa.Text = rtbPesquisa.Text.Substring(0, rtbPesquisa.TextLength - 1);
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Estatico.ListaPesquisa.Add(rtbPesquisa.Text);

         // Fecha o formulário de pesquisa e exibe o formulário principal
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            frmPrincipal.Visible = true;

            this.Close();

        }
    }
}
