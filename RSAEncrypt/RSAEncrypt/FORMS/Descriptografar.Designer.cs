namespace RSAEncrypt.FORMS
{
    partial class Descriptografar
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
            this.btCopy = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEncrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCopy
            // 
            this.btCopy.Enabled = false;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCopy.Location = new System.Drawing.Point(263, 190);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(132, 23);
            this.btCopy.TabIndex = 17;
            this.btCopy.Text = "Copy Output";
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(300, 216);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(12, 13);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stats:";
            // 
            // btDecrypt
            // 
            this.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDecrypt.Location = new System.Drawing.Point(263, 163);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(132, 23);
            this.btDecrypt.TabIndex = 13;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.Color.DarkGray;
            this.tbOutput.Location = new System.Drawing.Point(401, 38);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(243, 216);
            this.tbOutput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // tbEncrypted
            // 
            this.tbEncrypted.BackColor = System.Drawing.Color.DarkGray;
            this.tbEncrypted.Location = new System.Drawing.Point(14, 38);
            this.tbEncrypted.Multiline = true;
            this.tbEncrypted.Name = "tbEncrypted";
            this.tbEncrypted.Size = new System.Drawing.Size(243, 216);
            this.tbEncrypted.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Encrypted";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSAEncrypt.Properties.Resources.arrow_drawing_1;
            this.pictureBox1.Location = new System.Drawing.Point(259, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Descriptografar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(660, 266);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDecrypt);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEncrypted);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Descriptografar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descriptografar";
            this.Load += new System.EventHandler(this.Descriptografar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEncrypted;
        private System.Windows.Forms.Label label1;
    }
}