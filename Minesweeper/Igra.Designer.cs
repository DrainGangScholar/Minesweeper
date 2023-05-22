namespace Minesweeper
{
    partial class Igra
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
            this.xD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xD
            // 
            this.xD.AutoSize = true;
            this.xD.Location = new System.Drawing.Point(750, 426);
            this.xD.Name = "xD";
            this.xD.Size = new System.Drawing.Size(0, 15);
            this.xD.TabIndex = 0;
            // 
            // Igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xD);
            this.Name = "Igra";
            this.Text = "Igra";
            this.Load += new System.EventHandler(this.Igra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label xD;
    }
}