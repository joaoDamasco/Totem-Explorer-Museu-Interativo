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

namespace Project_Pim.Apresentacao
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            rtbPesquisa.Text = Estatico.Pessoas[0].Nome;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Estatico.Pessoas.Length; i++)
            {
                sb.AppendLine($"Nome: {Estatico.Pessoas[i].Nome}, Idade: {Estatico.Pessoas[i].Idade}, Pontuação: {Estatico.Pessoas[i].Pontuacao}");
            }

            rtbPesquisa.Text = sb.ToString().ToUpper();

            rtbPesquisa.Text += ($"Nome: {Estatico.ListaPesquisa[0]}, Idade: {Estatico.ListaPesquisa[1]}, Pontuação: {Estatico.Valor}".ToUpper());

            
            if(Estatico.Avaliacao == 1 )
            {
                txbPessimo.Text = "PÉSSIMO: " + 1;
            }else if (Estatico.Avaliacao == 2) 
            {
                txbRuim.Text = "RUIM: " + 1;
            }else if (Estatico.Avaliacao == 3) 
            {
                txbBom.Text = "BOM : " + 1;
                
            }else if (Estatico.Avaliacao == 4) 
            {
                txbOtimo.Text = "ÓTIMO: " + 2;
            }
            else if (Estatico.Avaliacao == 5) 
            {    txbExelente.Text = "EXELENTE: " + 4;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();

        }
    }
}
