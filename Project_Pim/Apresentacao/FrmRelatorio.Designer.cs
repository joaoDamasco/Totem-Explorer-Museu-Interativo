namespace Project_Pim.Apresentacao
{
    partial class FrmRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbPesquisa = new System.Windows.Forms.RichTextBox();
            this.txbRuim = new System.Windows.Forms.TextBox();
            this.txbPessimo = new System.Windows.Forms.TextBox();
            this.txbExelente = new System.Windows.Forms.TextBox();
            this.txbOtimo = new System.Windows.Forms.TextBox();
            this.txbBom = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPesquisa
            // 
            this.rtbPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbPesquisa.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPesquisa.Location = new System.Drawing.Point(143, 59);
            this.rtbPesquisa.Name = "rtbPesquisa";
            this.rtbPesquisa.ReadOnly = true;
            this.rtbPesquisa.Size = new System.Drawing.Size(541, 298);
            this.rtbPesquisa.TabIndex = 72;
            this.rtbPesquisa.TabStop = false;
            this.rtbPesquisa.Text = "";
            // 
            // txbRuim
            // 
            this.txbRuim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbRuim.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRuim.Location = new System.Drawing.Point(760, 173);
            this.txbRuim.Name = "txbRuim";
            this.txbRuim.ReadOnly = true;
            this.txbRuim.Size = new System.Drawing.Size(126, 32);
            this.txbRuim.TabIndex = 73;
            this.txbRuim.TabStop = false;
            this.txbRuim.Text = "RUIM: 0";
            // 
            // txbPessimo
            // 
            this.txbPessimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPessimo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPessimo.Location = new System.Drawing.Point(760, 211);
            this.txbPessimo.Name = "txbPessimo";
            this.txbPessimo.ReadOnly = true;
            this.txbPessimo.Size = new System.Drawing.Size(126, 32);
            this.txbPessimo.TabIndex = 74;
            this.txbPessimo.TabStop = false;
            this.txbPessimo.Text = "PÉSSIMO: 0";
            // 
            // txbExelente
            // 
            this.txbExelente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbExelente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbExelente.Location = new System.Drawing.Point(760, 59);
            this.txbExelente.Name = "txbExelente";
            this.txbExelente.ReadOnly = true;
            this.txbExelente.Size = new System.Drawing.Size(126, 32);
            this.txbExelente.TabIndex = 75;
            this.txbExelente.TabStop = false;
            this.txbExelente.Text = "EXELENTE: 3";
            // 
            // txbOtimo
            // 
            this.txbOtimo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbOtimo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOtimo.Location = new System.Drawing.Point(760, 97);
            this.txbOtimo.Name = "txbOtimo";
            this.txbOtimo.ReadOnly = true;
            this.txbOtimo.Size = new System.Drawing.Size(126, 32);
            this.txbOtimo.TabIndex = 76;
            this.txbOtimo.TabStop = false;
            this.txbOtimo.Text = "ÓTIMO: 1";
            // 
            // txbBom
            // 
            this.txbBom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBom.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBom.Location = new System.Drawing.Point(760, 135);
            this.txbBom.Name = "txbBom";
            this.txbBom.ReadOnly = true;
            this.txbBom.Size = new System.Drawing.Size(126, 32);
            this.txbBom.TabIndex = 77;
            this.txbBom.TabStop = false;
            this.txbBom.Text = "BOM: 0";
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.BackColor = System.Drawing.Color.Black;
            this.lblAvaliacao.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacao.ForeColor = System.Drawing.Color.White;
            this.lblAvaliacao.Location = new System.Drawing.Point(742, 9);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(159, 37);
            this.lblAvaliacao.TabIndex = 78;
            this.lblAvaliacao.Text = "AVALIAÇÕES";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 37);
            this.label1.TabIndex = 79;
            this.label1.Text = "\"Usuários que responderam ao programa\"";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(402, 386);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(283, 52);
            this.btnFinalizar.TabIndex = 80;
            this.btnFinalizar.Text = "FINALIZAR VIAGEM";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(691, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 52);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.GalaxiaFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.txbBom);
            this.Controls.Add(this.txbOtimo);
            this.Controls.Add(this.txbExelente);
            this.Controls.Add(this.txbPessimo);
            this.Controls.Add(this.txbRuim);
            this.Controls.Add(this.rtbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorio";
            this.Text = "FrmRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPesquisa;
        private System.Windows.Forms.TextBox txbRuim;
        private System.Windows.Forms.TextBox txbPessimo;
        private System.Windows.Forms.TextBox txbExelente;
        private System.Windows.Forms.TextBox txbOtimo;
        private System.Windows.Forms.TextBox txbBom;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}