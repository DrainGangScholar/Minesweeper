namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnZapocni = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite velicinu ";
            // 
            // txtVelicina
            // 
            this.txtVelicina.Location = new System.Drawing.Point(12, 27);
            this.txtVelicina.Name = "txtVelicina";
            this.txtVelicina.Size = new System.Drawing.Size(98, 23);
            this.txtVelicina.TabIndex = 1;
            this.txtVelicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVelicina_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberite broj mina";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(121, 27);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 23);
            this.txtBroj.TabIndex = 3;
            this.txtBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBroj_KeyPress);
            // 
            // btnZapocni
            // 
            this.btnZapocni.Location = new System.Drawing.Point(12, 56);
            this.btnZapocni.Name = "btnZapocni";
            this.btnZapocni.Size = new System.Drawing.Size(209, 49);
            this.btnZapocni.TabIndex = 4;
            this.btnZapocni.Text = "Zapocni";
            this.btnZapocni.UseVisualStyleBackColor = true;
            this.btnZapocni.Click += new System.EventHandler(this.btnZapocni_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(227, 56);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(209, 49);
            this.btnUcitaj.TabIndex = 5;
            this.btnUcitaj.Text = "Ucitaj iz XML";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnZapocni);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVelicina);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtVelicina;
        private Label label2;
        private TextBox txtBroj;
        private Button btnZapocni;
        private Button btnUcitaj;
    }
}