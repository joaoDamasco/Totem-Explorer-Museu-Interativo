﻿using Project_Pim.Apresentacao;
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
    public partial class FrmHistoria1 : Form
    {
        public FrmHistoria1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmHistoria2 frmHistoria2 = new FrmHistoria2();

            frmHistoria2.Visible = true;

            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            this.Close();
        }
    }
}
