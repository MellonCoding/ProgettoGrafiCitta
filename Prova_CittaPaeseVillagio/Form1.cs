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

            //gs.Add_Nodo(txb_nome_nodo.Text);

            switch (cmb_type.SelectedIndex)
            {
                case 0: //Paese
                    gesore.Add_Nodo(new Paese(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                case 1: //Citta
                    gesore.Add_Nodo(new Citta(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                case 2: //Villagio
                    gesore.Add_Nodo(new Villagio(txb_nome_nodo.Text, int.Parse(txt_n_abi.Text)));
                    break;
                default:
                    break;
            }
            set_cmb();
        }

        private void btt_add_arco_Click(object sender, EventArgs e)
        {
            gesore.Add_Arco_bi(cmb_partenza.SelectedIndex, cmb_arrivo.SelectedIndex, int.Parse(txb_metrica_nodo.Text));
        }

        private void set_cmb()
        {
            string[] nomi;

            nomi = gesore.get_lista();

            cmb_arrivo.Items.Clear();
            cmb_partenza.Items.Clear();
            cmb_arr_espl.Items.Clear();
            cmb_part_espl.Items.Clear();

            for (int i = 0; i < nomi.Length; i++)
            {
                cmb_arrivo.Items.Add(nomi[i]);
                cmb_partenza.Items.Add(nomi[i]);
                cmb_part_espl.Items.Add(nomi[i]);
                cmb_arr_espl.Items.Add(nomi[i]);

            }
        }

        private void btt_stampa_Click(object sender, EventArgs e)
        {
            Graphics g = p.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            pen.StartCap = LineCap.ArrowAnchor;
            buttons.Clear(); // <- qui? 

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

                    p2.X = buttons[gesore.findPos(gesore.arrNodi[i].Archi[j].Next)].Location.X - p.Location.X + 20;
                    p2.Y = buttons[gesore.findPos(gesore.arrNodi[i].Archi[j].Next)].Location.Y - p.Location.Y + 20;

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

        private void p_Paint(object sender, PaintEventArgs e)
        {

            //Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.Black, 3);

            //Point p1 = new Point();
            //Point p2 = new Point();

            //g.Clear(p.BackColor);

            //for (int i = 0; i < buttons.Count; i++)
            //{
            //    for (int j = 0; j < gs.Arr_Nodi[i].arcos.Length; j++)
            //    {
            //        p1.X = buttons[i].Location.X - p.Location.X;
            //        p1.Y = buttons[i].Location.Y - p.Location.Y;

            //        p2.X = buttons[gs.findPos(gs.Arr_Nodi[i].arcos[j].Next)].Location.X - p.Location.X;
            //        p2.Y = buttons[gs.findPos(gs.Arr_Nodi[i].arcos[j].Next)].Location.Y - p.Location.Y;

            //        g.DrawLine(pen, p1, p2);
            //    }
            //}
        }

        private void btt_raggiungibile_c_Click(object sender, EventArgs e)
        {
            if (gesore.raggiungibile(cmb_part_espl.SelectedIndex, cmb_arr_espl.SelectedIndex) < int.Parse(txt_fuel.Text))
            {
                MessageBox.Show("Raggiungibile con " + int.Parse(txt_fuel.Text));
            }
            else
            {
                MessageBox.Show("NON Raggiungibile con" + int.Parse(txt_fuel.Text));
            }
        }

        private void btt_raggiungibile_Click(object sender, EventArgs e)
        {
            if (gesore.raggiungibile(cmb_part_espl.SelectedIndex, cmb_arr_espl.SelectedIndex) < int.MaxValue)
            {
                MessageBox.Show("Raggiungibile");
            }
            else
            {
                MessageBox.Show("NON Raggiungibile");
            }
        }
    }
}
