﻿namespace RSAEncrypt.FORMS
{
    partial class MyKeys
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
            this.tbPublic = new System.Windows.Forms.TextBox();
            this.tbPrivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPublic
            // 
            this.tbPublic.BackColor = System.Drawing.Color.Gray;
            this.tbPublic.Location = new System.Drawing.Point(28, 34);
            this.tbPublic.Multiline = true;
            this.tbPublic.Name = "tbPublic";
            this.tbPublic.ReadOnly = true;
            this.tbPublic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPublic.Size = new System.Drawing.Size(429, 472);
            this.tbPublic.TabIndex = 0;
            // 
            // tbPrivate
            // 
            this.tbPrivate.BackColor = System.Drawing.Color.Gray;
            this.tbPrivate.Location = new System.Drawing.Point(558, 35);
            this.tbPrivate.Multiline = true;
            this.tbPrivate.Name = "tbPrivate";
            this.tbPrivate.ReadOnly = true;
            this.tbPrivate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPrivate.Size = new System.Drawing.Size(429, 472);
            this.tbPrivate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Public";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key lenght:";
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(485, 10);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(0, 13);
            this.labelLenght.TabIndex = 5;
            // 
            // MyKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(999, 519);
            this.Controls.Add(this.labelLenght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrivate);
            this.Controls.Add(this.tbPublic);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyKeys";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyKeys";
            this.Load += new System.EventHandler(this.MyKeys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPublic;
        private System.Windows.Forms.TextBox tbPrivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLenght;
    }
}