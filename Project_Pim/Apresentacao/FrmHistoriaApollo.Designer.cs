namespace Project_Pim
{
    partial class FrmHistoriaApollo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoriaApollo));
            this.rtbHistoria = new System.Windows.Forms.RichTextBox();
            this.pcbApollo = new System.Windows.Forms.PictureBox();
            this.pcbFoguete = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoguete)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbHistoria
            // 
            this.rtbHistoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbHistoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbHistoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistoria.Location = new System.Drawing.Point(34, 10);
            this.rtbHistoria.Name = "rtbHistoria";
            this.rtbHistoria.ReadOnly = true;
            this.rtbHistoria.Size = new System.Drawing.Size(399, 279);
            this.rtbHistoria.TabIndex = 3;
            this.rtbHistoria.Text = resources.GetString("rtbHistoria.Text");
            // 
            // pcbApollo
            // 
            this.pcbApollo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbApollo.Image = global::Project_Pim.Properties.Resources.ApolloLua;
            this.pcbApollo.Location = new System.Drawing.Point(12, 295);
            this.pcbApollo.Name = "pcbApollo";
            this.pcbApollo.Size = new System.Drawing.Size(662, 117);
            this.pcbApollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbApollo.TabIndex = 4;
            this.pcbApollo.TabStop = false;
            // 
            // pcbFoguete
            // 
            this.pcbFoguete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFoguete.BackgroundImage = global::Project_Pim.Properties.Resources.Foguete2;
            this.pcbFoguete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFoguete.Location = new System.Drawing.Point(498, 12);
            this.pcbFoguete.Name = "pcbFoguete";
            this.pcbFoguete.Size = new System.Drawing.Size(134, 195);
            this.pcbFoguete.TabIndex = 5;
            this.pcbFoguete.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Cyan;
            this.btnVoltar.Location = new System.Drawing.Point(457, 222);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 50);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmHistoriaApollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 423);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pcbFoguete);
            this.Controls.Add(this.pcbApollo);
            this.Controls.Add(this.rtbHistoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoriaApollo";
            this.Text = "FrmHistoriaApollo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoguete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHistoria;
        private System.Windows.Forms.PictureBox pcbApollo;
        private System.Windows.Forms.PictureBox pcbFoguete;
        private System.Windows.Forms.Button btnVoltar;
    }
}