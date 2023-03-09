namespace MgmtSpitalWF.Module
{
    partial class ModulDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulDoctor));
            this.linkBrowse = new System.Windows.Forms.LinkLabel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSepcialty = new MaterialSkin.Controls.MaterialComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBrowse
            // 
            this.linkBrowse.Image = ((System.Drawing.Image)(resources.GetObject("linkBrowse.Image")));
            this.linkBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBrowse.LinkColor = System.Drawing.Color.Black;
            this.linkBrowse.Location = new System.Drawing.Point(101, 176);
            this.linkBrowse.Name = "linkBrowse";
            this.linkBrowse.Size = new System.Drawing.Size(116, 37);
            this.linkBrowse.TabIndex = 16;
            this.linkBrowse.TabStop = true;
            this.linkBrowse.Text = "Choose File";
            this.linkBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhoto.Location = new System.Drawing.Point(83, 12);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(153, 139);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 18;
            this.picPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Photo*";
            // 
            // cbSepcialty
            // 
            this.cbSepcialty.AutoResize = false;
            this.cbSepcialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSepcialty.Depth = 0;
            this.cbSepcialty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSepcialty.DropDownHeight = 118;
            this.cbSepcialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSepcialty.DropDownWidth = 121;
            this.cbSepcialty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSepcialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSepcialty.FormattingEnabled = true;
            this.cbSepcialty.IntegralHeight = false;
            this.cbSepcialty.ItemHeight = 29;
            this.cbSepcialty.Items.AddRange(new object[] {
            "General",
            "Allergists",
            "Dermatologists",
            "Infectious disease doctors",
            "Ophthalmologists",
            "Obstetrician/gynecologists",
            "Cardiologists",
            "Endocrinologists",
            "Gastroenterologists",
            "Nephrologists",
            "Urologists",
            "Pulmonologists",
            "Otolaryngologists",
            "Neurologists",
            "Psychiatrists",
            "Oncologists",
            "Radiologists",
            "Rheumatologists",
            "General surgeons",
            "Orthopedic surgeons",
            "Cardiac surgeons",
            "Anesthesiologists"});
            this.cbSepcialty.Location = new System.Drawing.Point(520, 95);
            this.cbSepcialty.MaxDropDownItems = 4;
            this.cbSepcialty.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSepcialty.Name = "cbSepcialty";
            this.cbSepcialty.Size = new System.Drawing.Size(218, 35);
            this.cbSepcialty.StartIndex = 0;
            this.cbSepcialty.TabIndex = 31;
            this.cbSepcialty.UseTallSize = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Specialty ";
            // 
            // cbGender
            // 
            this.cbGender.AutoResize = false;
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbGender.Depth = 0;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGender.DropDownHeight = 118;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.DropDownWidth = 121;
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.IntegralHeight = false;
            this.cbGender.ItemHeight = 29;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(520, 54);
            this.cbGender.MaxDropDownItems = 4;
            this.cbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(218, 35);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 29;
            this.cbGender.UseTallSize = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(520, 12);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 36);
            this.txtName.TabIndex = 26;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gender*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name*";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Items.AddRange(new object[] {
            "General",
            "Allergists",
            "Dermatologists",
            "Infectious disease doctors",
            "Ophthalmologists",
            "Obstetrician/gynecologists",
            "Cardiologists",
            "Endocrinologists",
            "Gastroenterologists",
            "Nephrologists",
            "Urologists",
            "Pulmonologists",
            "Otolaryngologists",
            "Neurologists",
            "Psychiatrists",
            "Oncologists",
            "Radiologists",
            "Rheumatologists",
            "General surgeons",
            "Orthopedic surgeons",
            "Cardiac surgeons",
            "Anesthesiologists"});
            this.materialComboBox1.Location = new System.Drawing.Point(520, 219);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(218, 35);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 37;
            this.materialComboBox1.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Specialty ";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 118;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 29;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.materialComboBox2.Location = new System.Drawing.Point(520, 178);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(218, 35);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 35;
            this.materialComboBox2.UseTallSize = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(520, 136);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(218, 36);
            this.materialTextBox1.TabIndex = 32;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Gender*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name*";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Depth = 0;
            this.txtNotes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNotes.Location = new System.Drawing.Point(67, 229);
            this.txtNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(215, 88);
            this.txtNotes.TabIndex = 39;
            this.txtNotes.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Notes";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(520, 263);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(218, 22);
            this.dtCreate.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Created Ar*";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(807, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(726, 323);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 36);
            this.btnCancle.TabIndex = 43;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // ModulDoctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(894, 371);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialComboBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSepcialty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkBrowse);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ModulDoctor";
            this.Text = "ModulDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBrowse;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cbSepcialty;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialComboBox cbGender;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
    }
}