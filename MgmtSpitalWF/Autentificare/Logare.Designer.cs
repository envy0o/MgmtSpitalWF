namespace MgmtSpitalWF.Autentificare
{
    partial class Logare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutentificare = new MaterialSkin.Controls.MaterialButton();
            this.btnAnulare = new MaterialSkin.Controls.MaterialButton();
            this.txtParola = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bun venit!";
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAutentificare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAutentificare.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAutentificare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAutentificare.Depth = 0;
            this.btnAutentificare.HighEmphasis = true;
            this.btnAutentificare.Icon = null;
            this.btnAutentificare.Location = new System.Drawing.Point(184, 306);
            this.btnAutentificare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAutentificare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAutentificare.Size = new System.Drawing.Size(131, 36);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAutentificare.UseAccentColor = true;
            this.btnAutentificare.UseVisualStyleBackColor = false;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnulare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnulare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnulare.Depth = 0;
            this.btnAnulare.HighEmphasis = true;
            this.btnAnulare.Icon = null;
            this.btnAnulare.Location = new System.Drawing.Point(208, 354);
            this.btnAnulare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnulare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnulare.Size = new System.Drawing.Size(86, 36);
            this.btnAnulare.TabIndex = 5;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnulare.UseAccentColor = true;
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // txtParola
            // 
            this.txtParola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParola.AnimateReadOnly = false;
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParola.Depth = 0;
            this.txtParola.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtParola.Hint = "Parolă";
            this.txtParola.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtParola.LeadingIcon")));
            this.txtParola.Location = new System.Drawing.Point(132, 261);
            this.txtParola.MaxLength = 50;
            this.txtParola.MouseState = MaterialSkin.MouseState.OUT;
            this.txtParola.Multiline = false;
            this.txtParola.Name = "txtParola";
            this.txtParola.Password = true;
            this.txtParola.Size = new System.Drawing.Size(233, 36);
            this.txtParola.TabIndex = 7;
            this.txtParola.Text = "";
            this.txtParola.TrailingIcon = global::MgmtSpitalWF.Properties.Resources.hide_20px;
            this.txtParola.UseTallSize = false;
            this.txtParola.TrailingIconClick += new System.EventHandler(this.txtParola_TrailingIconClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Adresă e-mail";
            this.txtEmail.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtEmail.LeadingIcon")));
            this.txtEmail.Location = new System.Drawing.Point(132, 192);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 36);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Logare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Logare";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnAutentificare;
        private MaterialSkin.Controls.MaterialButton btnAnulare;
        private MaterialSkin.Controls.MaterialTextBox txtParola;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}