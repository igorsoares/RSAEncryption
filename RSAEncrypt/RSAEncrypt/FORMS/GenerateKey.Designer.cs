namespace RSAEncrypt.FORMS
{
    partial class GenerateKey
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbLenght = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCopiar = new System.Windows.Forms.Button();
            this.btSalvarComoPub = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbPublic = new System.Windows.Forms.TextBox();
            this.tbPrivate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCopiarPrivada = new System.Windows.Forms.Button();
            this.btSalvarComoPriv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the lenght of the key";
            // 
            // cbLenght
            // 
            this.cbLenght.BackColor = System.Drawing.Color.Gray;
            this.cbLenght.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLenght.FormattingEnabled = true;
            this.cbLenght.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.cbLenght.Location = new System.Drawing.Point(30, 41);
            this.cbLenght.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLenght.Name = "cbLenght";
            this.cbLenght.Size = new System.Drawing.Size(138, 24);
            this.cbLenght.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSalvarComoPriv);
            this.groupBox1.Controls.Add(this.btCopiarPrivada);
            this.groupBox1.Controls.Add(this.btCopiar);
            this.groupBox1.Controls.Add(this.btSalvarComoPub);
            this.groupBox1.Location = new System.Drawing.Point(7, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(233, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "You can...";
            // 
            // btCopiar
            // 
            this.btCopiar.Enabled = false;
            this.btCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCopiar.Location = new System.Drawing.Point(6, 24);
            this.btCopiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(107, 28);
            this.btCopiar.TabIndex = 1;
            this.btCopiar.Text = "Copy public";
            this.btCopiar.UseVisualStyleBackColor = true;
            // 
            // btSalvarComoPub
            // 
            this.btSalvarComoPub.Enabled = false;
            this.btSalvarComoPub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarComoPub.Location = new System.Drawing.Point(6, 60);
            this.btSalvarComoPub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvarComoPub.Name = "btSalvarComoPub";
            this.btSalvarComoPub.Size = new System.Drawing.Size(220, 28);
            this.btSalvarComoPub.TabIndex = 0;
            this.btSalvarComoPub.Text = "Save public key as";
            this.btSalvarComoPub.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLenght);
            this.groupBox2.Location = new System.Drawing.Point(7, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(226, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(46, 73);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbPublic
            // 
            this.tbPublic.BackColor = System.Drawing.Color.Gray;
            this.tbPublic.Location = new System.Drawing.Point(260, 28);
            this.tbPublic.Multiline = true;
            this.tbPublic.Name = "tbPublic";
            this.tbPublic.ReadOnly = true;
            this.tbPublic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPublic.Size = new System.Drawing.Size(235, 387);
            this.tbPublic.TabIndex = 5;
            // 
            // tbPrivate
            // 
            this.tbPrivate.BackColor = System.Drawing.Color.Gray;
            this.tbPrivate.Location = new System.Drawing.Point(513, 28);
            this.tbPrivate.Multiline = true;
            this.tbPrivate.Name = "tbPrivate";
            this.tbPrivate.ReadOnly = true;
            this.tbPrivate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPrivate.Size = new System.Drawing.Size(227, 387);
            this.tbPrivate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Public key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private key";
            // 
            // btCopiarPrivada
            // 
            this.btCopiarPrivada.Enabled = false;
            this.btCopiarPrivada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCopiarPrivada.Location = new System.Drawing.Point(119, 24);
            this.btCopiarPrivada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCopiarPrivada.Name = "btCopiarPrivada";
            this.btCopiarPrivada.Size = new System.Drawing.Size(107, 28);
            this.btCopiarPrivada.TabIndex = 2;
            this.btCopiarPrivada.Text = "Copy private";
            this.btCopiarPrivada.UseVisualStyleBackColor = true;
            // 
            // btSalvarComoPriv
            // 
            this.btSalvarComoPriv.Enabled = false;
            this.btSalvarComoPriv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarComoPriv.Location = new System.Drawing.Point(6, 96);
            this.btSalvarComoPriv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvarComoPriv.Name = "btSalvarComoPriv";
            this.btSalvarComoPriv.Size = new System.Drawing.Size(221, 28);
            this.btSalvarComoPriv.TabIndex = 3;
            this.btSalvarComoPriv.Text = "Save private key as";
            this.btSalvarComoPriv.UseVisualStyleBackColor = true;
            // 
            // GenerateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(752, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrivate);
            this.Controls.Add(this.tbPublic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateKey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLenght;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCopiar;
        private System.Windows.Forms.Button btSalvarComoPub;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbPublic;
        private System.Windows.Forms.TextBox tbPrivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSalvarComoPriv;
        private System.Windows.Forms.Button btCopiarPrivada;
    }
}