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
            this.components = new System.ComponentModel.Container();
            this.xD = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.strpSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.strpLoadXML = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTimer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 426);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustripFile
            // 
            this.menustripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpSaveXML,
            this.strpLoadXML});
            this.menustripFile.Name = "menustripFile";
            this.menustripFile.Size = new System.Drawing.Size(37, 20);
            this.menustripFile.Text = "File";
            // 
            // strpSaveXML
            // 
            this.strpSaveXML.Name = "strpSaveXML";
            this.strpSaveXML.Size = new System.Drawing.Size(158, 22);
            this.strpSaveXML.Text = "Save To XML";
            this.strpSaveXML.Click += new System.EventHandler(this.strpSaveXML_Click);
            // 
            // strpLoadXML
            // 
            this.strpLoadXML.Name = "strpLoadXML";
            this.strpLoadXML.Size = new System.Drawing.Size(158, 22);
            this.strpLoadXML.Text = "Load From XML";
            this.strpLoadXML.Click += new System.EventHandler(this.strpLoadXML_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(12, 411);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 15);
            this.labelTimer.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(8, 404);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 15);
            this.lblTimer.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Igra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.xD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Igra";
            this.Text = "Igra";
            this.Load += new System.EventHandler(this.Igra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label xD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menustripFile;
        private ToolStripMenuItem strpSaveXML;
        private ToolStripMenuItem strpLoadXML;
        private Label labelTimer;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}