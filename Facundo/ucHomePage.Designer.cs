namespace Facundo
{
    partial class ucHomePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShop
            // 
            this.lblShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShop.AutoSize = true;
            this.lblShop.BackColor = System.Drawing.Color.Brown;
            this.lblShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShop.Location = new System.Drawing.Point(-3, 0);
            this.lblShop.MinimumSize = new System.Drawing.Size(680, 0);
            this.lblShop.Name = "lblShop";
            this.lblShop.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lblShop.Size = new System.Drawing.Size(680, 33);
            this.lblShop.TabIndex = 1;
            this.lblShop.Text = "HOME";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShop);
            this.Name = "ucHomePage";
            this.Size = new System.Drawing.Size(674, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShop;
    }
}
