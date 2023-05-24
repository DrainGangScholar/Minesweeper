using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minesweeper
{
    public partial class Igra : Form
    {
        int velicina=9, broj=10;
        System.Windows.Forms.Button[,] dugmici;
        Stopwatch stopwatch = new Stopwatch();
        public Igra(int velicina, int broj)
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.velicina = velicina;
            this.broj = broj;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            dugmici = new System.Windows.Forms.Button[velicina, velicina];
            Random random = new Random();
            for (int i = 0; i < velicina; i++)
            {
                for (int j = 0; j < velicina; j++)
                {
                    System.Windows.Forms.Button dugme = new System.Windows.Forms.Button();
                    dugme.Size = new Size(30, 30);
                    dugme.Location = new Point(30 * j, 30 * i);
                    dugme.Tag = "";
                    dugme.Click += btnClick;
                    dugme.TabStop = false;
                    this.Controls.Add(dugme);
                    dugmici[i, j] = dugme;
                }
            }
            int brojPostavljenihMina = 0;
            while (brojPostavljenihMina < broj)
            {
                int randRow = random.Next(0, velicina - 1);
                int randCol = random.Next(0, velicina - 1);

                if (!dugmici[randRow, randCol].Tag.Equals("Mina"))
                {
                    dugmici[randRow, randCol].Tag = "Mina";
                    brojPostavljenihMina++;
                }
            }

            InitializeComponent();
            stopwatch.Start();
            timer1.Start();
        }
        public Igra()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }
        private void btnClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button dugme = (System.Windows.Forms.Button)sender;

            if (dugme.Tag.Equals("Mina"))
            {
                dugme.Text = "\U0001F4A3";
                xD.Focus();
                dugme.Enabled = false;
                dugme.BackColor = Color.Red;
                Gotovo();
            }
            else
            {
                dugme.Enabled = false;
                NijeMina(dugme);
            }
        }
        private void UpisiXml(string fPutanja)
        {
            string putanja = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fPutanja);
            XmlDocument xmlDoc = new XmlDocument(); 
            XmlElement roditelj = xmlDoc.CreateElement("IgraKonfiguracija");
            xmlDoc.AppendChild(roditelj);

            timer1.Enabled = false;

            XmlElement konfiguracijaElement = xmlDoc.CreateElement("Konfiguracija");
            konfiguracijaElement.SetAttribute("Velicina", velicina.ToString());
            konfiguracijaElement.SetAttribute("Broj", broj.ToString());
            roditelj.AppendChild(konfiguracijaElement);


            XmlElement stanjeElement = xmlDoc.CreateElement("Stanje");
            for (int i = 0; i < velicina; i++)
            {
                for (int j = 0; j < velicina; j++)
                {
                    XmlElement dugmeElement = xmlDoc.CreateElement("Dugme");
                    dugmeElement.SetAttribute("Red", i.ToString());
                    dugmeElement.SetAttribute("Kolona", j.ToString());
                    dugmeElement.SetAttribute("Tag", dugmici[i, j].Tag.ToString());
                    dugmeElement.SetAttribute("Text", dugmici[i, j].Text);
                    dugmeElement.SetAttribute("Enabled", dugmici[i, j].Enabled.ToString());
                    stanjeElement.AppendChild(dugmeElement);
                }
            }
            roditelj.AppendChild(stanjeElement);

            xmlDoc.Save(putanja);
        }
        private void UcitajXml(string putanja)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(putanja);

            XmlElement roditelj = xmlDoc.DocumentElement;

            XmlElement konfiguracijaElement = (XmlElement)roditelj.SelectSingleNode("Konfiguracija");
            int ucitanaVelicina = int.Parse(konfiguracijaElement.GetAttribute("Velicina"));
            int ucitanBroj = int.Parse(konfiguracijaElement.GetAttribute("Broj"));

            this.velicina = ucitanaVelicina;
            this.broj = ucitanBroj;
            dugmici = new System.Windows.Forms.Button[ucitanaVelicina, ucitanBroj];

            XmlElement stanje = (XmlElement)roditelj.SelectSingleNode("Stanje");
            foreach (XmlElement dugme in stanje.SelectNodes("Dugme"))
            {
                int red = int.Parse(dugme.GetAttribute("Red"));
                int kolona = int.Parse(dugme.GetAttribute("Kolona"));
                string tag = dugme.GetAttribute("Tag");
                string text = dugme.GetAttribute("Text");//mozda je ovde problem nzm xd jer je text prazan
                bool enabled = bool.Parse(dugme.GetAttribute("Enabled"));
                System.Windows.Forms.Button _dugme = new System.Windows.Forms.Button();
                _dugme = new System.Windows.Forms.Button();
                _dugme.Tag = string.IsNullOrEmpty(tag)?string.Empty:tag;
                _dugme.Text = text;
                _dugme.Enabled = enabled;
                _dugme.Click += btnClick;
                _dugme.Size = new Size(30, 30);
                _dugme.Location = new Point(30 * red, 30 * kolona);
                this.Controls.Add(_dugme);
                dugmici[red, kolona] = _dugme;
                
            }
            Console.WriteLine("Hello, World!");
        }
        private void Gotovo()
        {
            stopwatch.Stop();
            timer1.Stop();
            for (int i = 0; i < velicina; i++)
            {
                for (int j = 0; j < velicina; j++)
                {
                    if (dugmici[i, j].Enabled && !dugmici[i, j].Tag.Equals("Mina"))
                    {
                        dugmici[i, j].Enabled = false;

                        int brojMina = 0;
                        for (int x = Math.Max(0, i - 1); x <= Math.Min(i + 1, velicina - 1); x++)
                        {
                            for (int y = Math.Max(0, j - 1); y <= Math.Min(j + 1, velicina - 1); y++)
                            {
                                if (dugmici[x, y].Tag.Equals("Mina"))
                                {
                                    dugmici[x, y].Text = "\U0001F4A3";
                                    brojMina++;
                                }
                            }
                        }
                        if (brojMina==0)
                            dugmici[i, j].Text = string.Empty;
                        else
                            dugmici[i, j].Text = brojMina.ToString();
                    }
                }
                UpisiXml("gotovo_stanje.xml");
            }

            MessageBox.Show("Bum", "Bum", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void NijeMina(System.Windows.Forms.Button dugme)
        {
            int red = -1, kolona = -1;

            for (int i = 0; i < velicina; i++)
            {
                for (int j = 0; j < velicina; j++)
                {
                    if (dugmici[i, j] == dugme)
                    {
                        red = i;
                        kolona = j;
                        break;
                    }
                }
            }

            int brojMina = BrojiKomsije(red, kolona);
            if (brojMina > 0)
            {
                dugme.Text = brojMina > 0 ? brojMina.ToString() :string.Empty;
            }
            else
            {
                for (int i = Math.Max(0, red - 1); i <= Math.Min(red + 1, velicina - 1); i++)
                {
                    for (int j = Math.Max(0, kolona - 1); j <= Math.Min(kolona + 1, velicina - 1); j++)
                    {
                        System.Windows.Forms.Button komsija = dugmici[i, j];
                        if (komsija.Enabled)
                        {
                            komsija.Enabled = false;
                            NijeMina(komsija);
                        }
                    }
                }
            }
        }

        private void Igra_Load(object sender, EventArgs e)
        {

        }

        private void strpSaveXML_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    UpisiXml(selectedFile);
                }
        }

        private void strpLoadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                UcitajXml(selectedFile);
            }
        }

        private int BrojiKomsije(int red, int kolona)
        {
            int brojKomsija = 0;
            for (int i = Math.Max(0, red - 1); i <= Math.Min(red + 1, velicina - 1); i++)
            {
                for (int j = Math.Max(0, kolona - 1); j <= Math.Min(kolona + 1, velicina - 1); j++)
                {
                    if (dugmici[i, j].Tag.Equals("Mina"))
                    {
                        brojKomsija++;
                    }
                }
            }
            return brojKomsija;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            lblTimer.Text = elapsedTime.ToString(@"mm\:ss");
        }

    }
}
