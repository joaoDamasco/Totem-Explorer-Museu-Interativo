namespace Project_Pim
{
    partial class FrmPrincipal
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
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMenu
            // 
            this.pcbMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pcbMenu.Image = global::Project_Pim.Properties.Resources.LuaMenu2;
            this.pcbMenu.Location = new System.Drawing.Point(109, 42);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(391, 316);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 0;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.Click += new System.EventHandler(this.pcbMenu_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 398);
            this.Controls.Add(this.pcbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMenu;
    }
}

