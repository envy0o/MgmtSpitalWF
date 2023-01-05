namespace MgmtSpitalWF.Module
{
    partial class ModulProgramari
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtReason = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoctor = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.txtTemp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSystolic = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDiastolic = new MaterialSkin.Controls.MaterialTextBox();
            this.txtWeight = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Motiv";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReason.Depth = 0;
            this.txtReason.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReason.Location = new System.Drawing.Point(118, 31);
            this.txtReason.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(232, 46);
            this.txtReason.TabIndex = 33;
            this.txtReason.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Data*";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(118, 114);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(232, 22);
            this.dtDate.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Doctor*";
            // 
            // cbDoctor
            // 
            this.cbDoctor.AutoResize = false;
            this.cbDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDoctor.Depth = 0;
            this.cbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDoctor.DropDownHeight = 118;
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.DropDownWidth = 121;
            this.cbDoctor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.IntegralHeight = false;
            this.cbDoctor.ItemHeight = 29;
            this.cbDoctor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbDoctor.Location = new System.Drawing.Point(610, 255);
            this.cbDoctor.MaxDropDownItems = 4;
            this.cbDoctor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(178, 35);
            this.cbDoctor.StartIndex = 0;
            this.cbDoctor.TabIndex = 39;
            this.cbDoctor.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Greutate*";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 384);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Creat la*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Notițe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tensiune Diastolică*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tensiune Sistolică*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Temperatură*";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Depth = 0;
            this.txtNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNote.Location = new System.Drawing.Point(118, 165);
            this.txtNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(232, 46);
            this.txtNote.TabIndex = 48;
            this.txtNote.Text = "";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(118, 241);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(232, 22);
            this.dtCreate.TabIndex = 49;
            // 
            // txtTemp
            // 
            this.txtTemp.AnimateReadOnly = false;
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemp.Depth = 0;
            this.txtTemp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTemp.Hint = "0";
            this.txtTemp.LeadingIcon = null;
            this.txtTemp.Location = new System.Drawing.Point(611, 12);
            this.txtTemp.MaxLength = 50;
            this.txtTemp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTemp.Multiline = false;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(177, 36);
            this.txtTemp.TabIndex = 50;
            this.txtTemp.Text = "";
            this.txtTemp.TrailingIcon = null;
            this.txtTemp.UseTallSize = false;
            // 
            // txtSystolic
            // 
            this.txtSystolic.AnimateReadOnly = false;
            this.txtSystolic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSystolic.Depth = 0;
            this.txtSystolic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSystolic.Hint = "0";
            this.txtSystolic.LeadingIcon = null;
            this.txtSystolic.Location = new System.Drawing.Point(611, 74);
            this.txtSystolic.MaxLength = 50;
            this.txtSystolic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSystolic.Multiline = false;
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(177, 36);
            this.txtSystolic.TabIndex = 51;
            this.txtSystolic.Text = "";
            this.txtSystolic.TrailingIcon = null;
            this.txtSystolic.UseTallSize = false;
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.AnimateReadOnly = false;
            this.txtDiastolic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiastolic.Depth = 0;
            this.txtDiastolic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiastolic.Hint = "0";
            this.txtDiastolic.LeadingIcon = null;
            this.txtDiastolic.Location = new System.Drawing.Point(611, 138);
            this.txtDiastolic.MaxLength = 50;
            this.txtDiastolic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiastolic.Multiline = false;
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(178, 36);
            this.txtDiastolic.TabIndex = 52;
            this.txtDiastolic.Text = "";
            this.txtDiastolic.TrailingIcon = null;
            this.txtDiastolic.UseTallSize = false;
            // 
            // txtWeight
            // 
            this.txtWeight.AnimateReadOnly = false;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Depth = 0;
            this.txtWeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWeight.Hint = "0";
            this.txtWeight.LeadingIcon = null;
            this.txtWeight.Location = new System.Drawing.Point(610, 197);
            this.txtWeight.MaxLength = 50;
            this.txtWeight.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWeight.Multiline = false;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(178, 36);
            this.txtWeight.TabIndex = 53;
            this.txtWeight.Text = "";
            this.txtWeight.TrailingIcon = null;
            this.txtWeight.UseTallSize = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(823, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(742, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ModulProgramari
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(910, 410);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtDiastolic);
            this.Controls.Add(this.txtSystolic);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModulProgramari";
            this.Text = "ModulVizite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cbDoctor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private MaterialSkin.Controls.MaterialTextBox txtTemp;
        private MaterialSkin.Controls.MaterialTextBox txtSystolic;
        private MaterialSkin.Controls.MaterialTextBox txtDiastolic;
        private MaterialSkin.Controls.MaterialTextBox txtWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}