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
    public partial class FrmResultado : Form
    {
        public FrmResultado()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa();

            frmPesquisa.Show();
            this.Close();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            foreach (RadioButton item in grbPergunta1.Controls.OfType<RadioButton>())
            {
                if (item.Text.Substring(0,1).Equals(Estatico.Resposta1) && !item.Checked)
                {
                    item.ForeColor = Color.Red;
                }
            }
            foreach (RadioButton item in grbPergunta2.Controls.OfType<RadioButton>())
            {
                if (item.Text.Substring(0,1).Equals(Estatico.Resposta1) && !item.Checked)
                {
                    item.ForeColor = Color.Red;
                }
            }
            foreach (RadioButton item in grbPergunta3.Controls.OfType<RadioButton>())
            {
                if (item.Text.Substring(0,1).Equals(Estatico.Resposta1) && !item.Checked)
                {
                    item.ForeColor = Color.Red;
                }
            }
            foreach (RadioButton item in grbPergunta4.Controls.OfType<RadioButton>())
            {
                if (item.Text.Substring(0,1).Equals(Estatico.Resposta1) && !item.Checked)
                {
                    item.ForeColor = Color.Red;
                }
            }
            foreach (RadioButton item in grbPergunta5.Controls.OfType<RadioButton>())
            {
                if (item.Text.Substring(0,1).Equals(Estatico.Resposta1) && !item.Checked)
                {
                    item.ForeColor = Color.Red;
                }
            }
        }
    }
}
