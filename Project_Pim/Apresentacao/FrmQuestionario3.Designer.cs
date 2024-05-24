namespace Project_Pim.Apresentacao
{
    partial class FrmQuestionario3
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
            this.pgbPontuacao = new System.Windows.Forms.ProgressBar();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.pcbIndicador9 = new System.Windows.Forms.PictureBox();
            this.btnNao1 = new System.Windows.Forms.Button();
            this.btnSim1 = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rtbPergunta = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pcbIndicador5 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador5)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbPontuacao
            // 
            this.pgbPontuacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbPontuacao.BackColor = System.Drawing.Color.Black;
            this.pgbPontuacao.Location = new System.Drawing.Point(266, 60);
            this.pgbPontuacao.Name = "pgbPontuacao";
            this.pgbPontuacao.Size = new System.Drawing.Size(211, 21);
            this.pgbPontuacao.TabIndex = 67;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Black;
            this.lblPontuacao.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(302, 32);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(129, 25);
            this.lblPontuacao.TabIndex = 66;
            this.lblPontuacao.Text = "Pontuação:  0";
            // 
            // pcbIndicador9
            // 
            this.pcbIndicador9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbIndicador9.BackColor = System.Drawing.Color.Transparent;
            this.pcbIndicador9.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbIndicador9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIndicador9.Location = new System.Drawing.Point(670, 223);
            this.pcbIndicador9.Name = "pcbIndicador9";
            this.pcbIndicador9.Size = new System.Drawing.Size(77, 44);
            this.pcbIndicador9.TabIndex = 65;
            this.pcbIndicador9.TabStop = false;
            // 
            // btnNao1
            // 
            this.btnNao1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNao1.BackColor = System.Drawing.SystemColors.Control;
            this.btnNao1.Location = new System.Drawing.Point(397, 223);
            this.btnNao1.Name = "btnNao1";
            this.btnNao1.Size = new System.Drawing.Size(267, 44);
            this.btnNao1.TabIndex = 64;
            this.btnNao1.TabStop = false;
            this.btnNao1.Text = "NÃO";
            this.btnNao1.UseVisualStyleBackColor = false;
            this.btnNao1.Click += new System.EventHandler(this.btnNao1_Click);
            // 
            // btnSim1
            // 
            this.btnSim1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSim1.Location = new System.Drawing.Point(79, 223);
            this.btnSim1.Name = "btnSim1";
            this.btnSim1.Size = new System.Drawing.Size(312, 44);
            this.btnSim1.TabIndex = 63;
            this.btnSim1.TabStop = false;
            this.btnSim1.Text = "SIM";
            this.btnSim1.UseVisualStyleBackColor = true;
            this.btnSim1.Click += new System.EventHandler(this.btnSim1_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(266, 123);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(211, 33);
            this.lblPergunta.TabIndex = 62;
            this.lblPergunta.Text = "Pergunta Número 3\r\n";
            // 
            // rtbPergunta
            // 
            this.rtbPergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbPergunta.BackColor = System.Drawing.Color.Black;
            this.rtbPergunta.Font = new System.Drawing.Font("Sitka Text", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPergunta.ForeColor = System.Drawing.Color.White;
            this.rtbPergunta.Location = new System.Drawing.Point(79, 179);
            this.rtbPergunta.Name = "rtbPergunta";
            this.rtbPergunta.ReadOnly = true;
            this.rtbPergunta.Size = new System.Drawing.Size(585, 38);
            this.rtbPergunta.TabIndex = 61;
            this.rtbPergunta.TabStop = false;
            this.rtbPergunta.Text = "  Neil Armstrong foi o comandante da missão Apollo 11?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(483, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 44);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinuar.BackColor = System.Drawing.Color.White;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(176, 311);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(301, 55);
            this.btnContinuar.TabIndex = 68;
            this.btnContinuar.Text = "Próxima Pergunta";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pcbIndicador5
            // 
            this.pcbIndicador5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcbIndicador5.BackColor = System.Drawing.Color.Transparent;
            this.pcbIndicador5.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbIndicador5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIndicador5.Location = new System.Drawing.Point(115, 14);
            this.pcbIndicador5.Name = "pcbIndicador5";
            this.pcbIndicador5.Size = new System.Drawing.Size(46, 43);
            this.pcbIndicador5.TabIndex = 71;
            this.pcbIndicador5.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(12, -1);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(97, 69);
            this.btnReiniciar.TabIndex = 70;
            this.btnReiniciar.Text = "Reiniciar QUIZ";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQuestionario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.GalaxyTest3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.pcbIndicador5);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.pgbPontuacao);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.pcbIndicador9);
            this.Controls.Add(this.btnNao1);
            this.Controls.Add(this.btnSim1);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rtbPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuestionario3";
            this.Text = "FrmQuestionario3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuestionario3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbPontuacao;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.PictureBox pcbIndicador9;
        private System.Windows.Forms.Button btnNao1;
        private System.Windows.Forms.Button btnSim1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RichTextBox rtbPergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pcbIndicador5;
        private System.Windows.Forms.Button btnReiniciar;
    }
}