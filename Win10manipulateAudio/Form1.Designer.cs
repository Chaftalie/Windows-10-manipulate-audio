﻿namespace Win10manipulateAudio
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent( )
        {
            this.btn_vol_up = new System.Windows.Forms.Button();
            this.btn_vol_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_vol_up
            // 
            this.btn_vol_up.Location = new System.Drawing.Point(13, 13);
            this.btn_vol_up.Name = "btn_vol_up";
            this.btn_vol_up.Size = new System.Drawing.Size(75, 23);
            this.btn_vol_up.TabIndex = 0;
            this.btn_vol_up.Text = "Volume up";
            this.btn_vol_up.UseVisualStyleBackColor = true;
            this.btn_vol_up.Click += new System.EventHandler(this.btn_vol_up_Click);
            // 
            // btn_vol_down
            // 
            this.btn_vol_down.Location = new System.Drawing.Point(94, 13);
            this.btn_vol_down.Name = "btn_vol_down";
            this.btn_vol_down.Size = new System.Drawing.Size(84, 23);
            this.btn_vol_down.TabIndex = 1;
            this.btn_vol_down.Text = "Volume Down";
            this.btn_vol_down.UseVisualStyleBackColor = true;
            this.btn_vol_down.Click += new System.EventHandler(this.btn_vol_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vol_down);
            this.Controls.Add(this.btn_vol_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vol_up;
        private System.Windows.Forms.Button btn_vol_down;
    }
}

