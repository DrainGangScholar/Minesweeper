namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtVelicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnZapocni_Click(object sender, EventArgs e)
        {
            int velicina;
            int broj;

            if (int.TryParse(txtVelicina.Text, out velicina) && int.TryParse(txtBroj.Text, out broj))
            {
                if (velicina >= 9 && broj >= 10)
                {
                    this.Hide();
                    Igra igraForm = new Igra(velicina, broj);
                    igraForm.FormClosed += (s, args) => this.Show();
                    igraForm.Show();
                }
                else
                {
                    MessageBox.Show("Unesite vrednosti vece od 9 i 10 u odgovarajuca polja.");
                }
            }
            else
            {
                //MessageBox.Show("Unesite ispravne brojeve u oba polja.");
                Igra igraForm = new Igra();
                igraForm.FormClosed += (s, args) => this.Show();
                igraForm.Show();
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Igra igraForm = new Igra();
            igraForm.FormClosed += (s, args) => this.Show();
            igraForm.Show();
        }
    }
}