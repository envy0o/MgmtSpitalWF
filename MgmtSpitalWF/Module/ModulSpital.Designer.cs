namespace MgmtSpitalWF.Module
{
    partial class ModulSpital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulSpital));
            this.linkBrowse = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBrowse
            // 
            this.linkBrowse.Image = ((System.Drawing.Image)(resources.GetObject("linkBrowse.Image")));
            this.linkBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBrowse.LinkColor = System.Drawing.Color.Black;
            this.linkBrowse.Location = new System.Drawing.Point(150, 158);
            this.linkBrowse.Name = "linkBrowse";
            this.linkBrowse.Size = new System.Drawing.Size(116, 37);
            this.linkBrowse.TabIndex = 5;
            this.linkBrowse.TabStop = true;
            this.linkBrowse.Text = "Choose File";
            this.linkBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLogo.Location = new System.Drawing.Point(136, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(153, 139);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logo*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Created At*";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(609, 196);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(212, 22);
            this.dtCreate.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(609, 25);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 36);
            this.txtName.TabIndex = 41;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Name*";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddress.Location = new System.Drawing.Point(80, 226);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 107);
            this.txtAddress.TabIndex = 43;
            this.txtAddress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Address*";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(609, 137);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 36);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Email*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(609, 79);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 36);
            this.txtPhone.TabIndex = 50;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseTallSize = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(807, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(726, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModulSpital
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(894, 371);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkBrowse);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModulSpital";
            this.Text = "ModulSpital";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBrowse;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}