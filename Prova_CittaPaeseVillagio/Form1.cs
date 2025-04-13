using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Prova_CittaPaeseVillagio
{
    public partial class Form1 : Form
    {
        Gestore gesore = new Gestore();
        List<Button> buttons = new List<Button>();

        // const
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_type.Items.Add("Paese");
            cmb_type.Items.Add("Citta");
            cmb_type.Items.Add("Villagio");
        }

        private void btt_add_nodo_Click(object sender, EventArgs e)
        {
            switch (cmb_type.SelectedIndex)
            {
                case 0: //Paese
                    gesore.AddNodo(new Paese(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                case 1: //Citta
                    gesore.AddNodo(new Citta(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                case 2: //Villagio
                    gesore.AddNodo(new Villagio(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                default:
                    break;
            }

            set_cmb();
        }

        private void btt_add_arco_Click(object sender, EventArgs e)
        {
            if (cmb_partenza.SelectedIndex != cmb_arrivo.SelectedIndex)
            {
                gesore.AddArcoBidirezionale(cmb_partenza.SelectedIndex, cmb_arrivo.SelectedIndex, int.Parse(txb_metrica_nodo.Text));
            }
            else
            {
                MessageBox.Show("strada inutile");
            }
        }

        private void set_cmb()
        {
            string[] nomi;

            nomi = gesore.GetLista();

            cmb_arrivo.Items.Clear();
            cmb_partenza.Items.Clear();
            cmb_arr_espl.Items.Clear();
            cmb_part_espl.Items.Clear();
            cmb_mezzi.Items.Clear();

            for (int i = 0; i < nomi.Length; i++)
            {
                cmb_arrivo.Items.Add(nomi[i]);
                cmb_partenza.Items.Add(nomi[i]);
                cmb_part_espl.Items.Add(nomi[i]);
                cmb_arr_espl.Items.Add(nomi[i]);
                cmb_mezzi.Items.Add(nomi[i]);
            }
        }

        private void btt_stampa_Click(object sender, EventArgs e)
        {
            Graphics g = p.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            pen.StartCap = LineCap.ArrowAnchor;

            // eliminare dal form i bottoni presenti in quella lista
            foreach (var button in buttons)
            {
                this.Controls.Remove(button); // Rimuove il bottone dal form
                button.Dispose(); // Libera le risorse del bottone (opzionale ma buona pratica)
            }
            buttons.Clear(); // Svuota la lista

            Point p1 = new Point();
            Point p2 = new Point();

            int c = 0;

            for (double i = 0; i < Math.PI * 2; i = i + (Math.PI / gesore.arrNodi.Length) * 2)
            {
                p1.X = (p.Location.X + p.Width / 2 + (int)(p.Width * Math.Cos(i) * 0.75) / 2);
                p1.Y = (p.Location.Y + p.Height / 2 + (int)(p.Height * Math.Sin(i) * 0.75) / 2);

                addbtt(p1.X, p1.Y, gesore.arrNodi[c].Nome);
                c++;
            }

            MessageBox.Show(gesore.stampaNodi());

            g.DrawLine(pen, 1, 1, 50, 50);

            g.Clear(p.BackColor);

            for (int i = 0; i < buttons.Count; i++)
            {
                for (int j = 0; j < gesore.arrNodi[i].Archi.Length; j++)
                {
                    p1.X = buttons[i].Location.X - p.Location.X + 20;
                    p1.Y = buttons[i].Location.Y - p.Location.Y + 20;

                    p2.X = buttons[gesore.FindPosizione(gesore.arrNodi[i].Archi[j].Next)].Location.X - p.Location.X + 20;
                    p2.Y = buttons[gesore.FindPosizione(gesore.arrNodi[i].Archi[j].Next)].Location.Y - p.Location.Y + 20;

                    g.DrawLine(pen, p1, p2);
                }
            }
        }

        private void addbtt(int cordX, int cordY, string text)
        {
            Button myButton = new Button();
            myButton.Text = text;
            myButton.Location = new Point((cordX), cordY);
            myButton.Size = new System.Drawing.Size(40, 40);
            myButton.BackColor = TransparencyKey;
            this.Controls.Add(myButton);
            myButton.BringToFront();


            buttons.Add(myButton);
        }

        // per capire se posso arriavre da nodo1 a nodo2
        private void btt_raggiungibile_Click(object sender, EventArgs e)
        {
            if (gesore.Raggiungibile(cmb_part_espl.SelectedIndex, cmb_arr_espl.SelectedIndex) <= int.MaxValue)
            {
                MessageBox.Show("Raggiungibile");
            }
            else
            {
                MessageBox.Show("Non raggiungibile");
            }
        }

        private void p_Paint(object sender, PaintEventArgs e) { } // qui per sicurezza lascio la firma o mi sa che esplode tutto

        // per capire se con le unita di carburante inserite dall'utente posso arriavre da nodo1 a nodo2
        private void btt_raggiungibile_c_Click(object sender, EventArgs e)
        {
            if (gesore.Raggiungibile(cmb_part_espl.SelectedIndex, cmb_arr_espl.SelectedIndex) <= int.Parse(txt_fuel.Text))
            {
                MessageBox.Show("Raggiungibile con " + int.Parse(txt_fuel.Text));
            }
            else
            {
                MessageBox.Show("Non raggiungibile con " + int.Parse(txt_fuel.Text));
            }
        }

        private void btn_metro_Click(object sender, EventArgs e)
        {
            if (cmb_mezzi.SelectedIndex >= 0)
            {
                int personeServite = gesore.PersoneServiteDaMetropolitana(gesore.arrNodi[cmb_mezzi.SelectedIndex]);
                txt_metro.Text = personeServite.ToString();
            }
            else
            {
                MessageBox.Show("Seleziona un nodo prima di verificare la disponibilità della metro.");
            }
        }
        private void btn_treno_Click(object sender, EventArgs e)
        {
            if (cmb_mezzi.SelectedIndex >= 0)
            {
                int personeServite = gesore.PersoneServiteDaTreno(gesore.arrNodi[cmb_mezzi.SelectedIndex]);
                txt_treno.Text = personeServite.ToString();
            }
            else
            {
                MessageBox.Show("Seleziona un nodo prima di verificare la disponibilità del treno.");
            }
        }
    }
}
