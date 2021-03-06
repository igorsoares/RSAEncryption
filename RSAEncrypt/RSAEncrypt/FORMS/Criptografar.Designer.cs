﻿namespace RSAEncrypt.FORMS
{
    partial class Criptografar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original";
            // 
            // tbOriginal
            // 
            this.tbOriginal.BackColor = System.Drawing.Color.DarkGray;
            this.tbOriginal.Location = new System.Drawing.Point(14, 38);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(243, 216);
            this.tbOriginal.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.Color.DarkGray;
            this.tbOutput.Location = new System.Drawing.Point(401, 38);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(243, 216);
            this.tbOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // btEncrypt
            // 
            this.btEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEncrypt.Location = new System.Drawing.Point(285, 163);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(87, 23);
            this.btEncrypt.TabIndex = 4;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stats:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(300, 216);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(12, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "-";
            // 
            // btCopy
            // 
            this.btCopy.Enabled = false;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCopy.Location = new System.Drawing.Point(285, 190);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(87, 23);
            this.btCopy.TabIndex = 8;
            this.btCopy.Text = "Copy Output";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSAEncrypt.Properties.Resources.arrow_drawing_1;
            this.pictureBox1.Location = new System.Drawing.Point(259, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Criptografar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(660, 266);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEncrypt);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOriginal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Criptografar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt";
            this.Load += new System.EventHandler(this.Criptografar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCopy;
    }
}