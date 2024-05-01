namespace Project_Pim
{
    partial class FrmHistoria1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoria1));
            this.pcbFoguete = new System.Windows.Forms.PictureBox();
            this.pcbApollo11 = new System.Windows.Forms.PictureBox();
            this.rtbHistoria = new System.Windows.Forms.RichTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoguete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo11)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbFoguete
            // 
            this.pcbFoguete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFoguete.Image = global::Project_Pim.Properties.Resources.foguete;
            this.pcbFoguete.Location = new System.Drawing.Point(450, 42);
            this.pcbFoguete.Name = "pcbFoguete";
            this.pcbFoguete.Size = new System.Drawing.Size(203, 129);
            this.pcbFoguete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoguete.TabIndex = 0;
            this.pcbFoguete.TabStop = false;
            // 
            // pcbApollo11
            // 
            this.pcbApollo11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbApollo11.Image = global::Project_Pim.Properties.Resources.Apollo11;
            this.pcbApollo11.Location = new System.Drawing.Point(-2, 240);
            this.pcbApollo11.Name = "pcbApollo11";
            this.pcbApollo11.Size = new System.Drawing.Size(685, 154);
            this.pcbApollo11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbApollo11.TabIndex = 1;
            this.pcbApollo11.TabStop = false;
            // 
            // rtbHistoria
            // 
            this.rtbHistoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbHistoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbHistoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistoria.Location = new System.Drawing.Point(12, 12);
            this.rtbHistoria.Name = "rtbHistoria";
            this.rtbHistoria.ReadOnly = true;
            this.rtbHistoria.Size = new System.Drawing.Size(399, 177);
            this.rtbHistoria.TabIndex = 2;
            this.rtbHistoria.Text = resources.GetString("rtbHistoria.Text");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Cyan;
            this.btnVoltar.Location = new System.Drawing.Point(453, 177);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 50);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmHistoria1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 394);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rtbHistoria);
            this.Controls.Add(this.pcbApollo11);
            this.Controls.Add(this.pcbFoguete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoria1";
            this.Text = "FrmHistoria1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoguete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoguete;
        private System.Windows.Forms.PictureBox pcbApollo11;
        private System.Windows.Forms.RichTextBox rtbHistoria;
        private System.Windows.Forms.Button btnVoltar;
    }
}