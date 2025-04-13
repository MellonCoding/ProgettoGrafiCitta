using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_CittaPaeseVillagio
{
    class Gestore
    {
        protected List<Nodo> Nodi;

        // const
        public Gestore()
        {
            Nodi = new List<Nodo>();
        }

        // get di nodi to array
        public Nodo[] arrNodi  
        { 
            get { return Nodi.ToArray(); }
        }

        // trova la posizione del nodo passato trammite l'ID e la ritorna
        public int FindPosizione(Nodo nodo) 
        {
            for (int i = 0; i < Nodi.Count; i++)
            {
                if (Nodi[i].ID == nodo.ID) 
                {
                    return i;
                }
            }
            return 0;
        }

        // passa nodo e aggiungi la lista
        public void AddNodo(Nodo nodo)
        {
            Nodi.Add(nodo);
        }
        // crea nodo e aggiungi alla lista
        public void AddNodo(string nome,int numeroAbitanti)
        {
            Nodi.Add(new Nodo(nome, numeroAbitanti));
        }
        // crea arco e aggiungi alla lista del nodo in posizione "partenza"
        public void AddArco(int partenza, int arrivo, int metrica)
        {
            Arco arco = new Arco(Nodi[arrivo], metrica);
            Nodi[partenza].AddArco(arco);
        }

        // aggiunge un arco bidirezionale (da nodo1 a nodo 2 e viceversa)
        public void AddArcoBidirezionale(int nodoPartenza, int nodoArrivo, int metrica)
        {
            // Controlla se esiste già un arco tra i due nodi, per sicurezza l'ho fatto 2 volte ma non servirebbe
            bool esisteArco1 = Nodi[nodoPartenza].Archi.Any(a => a.Next ==   Nodi[nodoArrivo]);
            bool esisteArco2 = Nodi[nodoArrivo].Archi.Any(a => a.Next == Nodi[nodoPartenza]);

            if (!esisteArco1 && !esisteArco2)
            {
                AddArco(nodoArrivo, nodoPartenza, metrica);
                AddArco(nodoPartenza, nodoArrivo, metrica);
            }
            else 
            {
                MessageBox.Show("percorso gia' esistente");
            }
        }


        // stampa utilizzata 
        public string stampaNodi()
        {
            string s = "";

            for (int i = 0; i < Nodi.Count; i++)
            {
                s=s+Nodi[i].Stampa();
            }
            
            return s;
        }

        public int Raggiungibile(int posizionePartenza,int posizioneFinale)
        {
            bool[] percorsi = new bool[Nodi.Count];
            int[] metriche = new int[Nodi.Count];

            Nodo[] precedenti = new Nodo[Nodi.Count];

            for (int i = 0; i < Nodi.Count; i++)
            {
                metriche[i] = int.MaxValue;
                percorsi[i] = false;
            }

            metriche[posizionePartenza] = 0;

            Nodi[posizionePartenza].Raggiunggibile(ref precedenti,Nodi.ToArray(),ref metriche,ref percorsi,posizionePartenza);

            return metriche[posizioneFinale];
        }

        public string[] GetLista() 
        {
            string[] nomi = new string[Nodi.Count];

            for (int i = 0; i < Nodi.Count; i++)
            {
                nomi[i]=Nodi[i].Nome;
            }

            return nomi;
        }

        public int PersoneServiteDaMetropolitana(Nodo nodo)
        {
            int totale = 0;

            foreach (Arco arco in nodo.Archi)
            {
                totale += arco.Next.NumeroAbitanti;
            }

            return totale;
        }

        public int PersoneServiteDaTreno(Nodo nodo)
        {
            HashSet<int> visitati = new HashSet<int>();
            int totale = 0;

            // Aggiungi i vicini diretti
            foreach (Arco arco in nodo.Archi)
            {
                Nodo vicino = arco.Next;
                if (visitati.Add(vicino.ID))
                {
                    totale += vicino.NumeroAbitanti;

                    // Aggiungi i vicini dei vicini
                    foreach (Arco arco2 in vicino.Archi)
                    {
                        Nodo vicinoDelVicino = arco2.Next;
                        if (visitati.Add(vicinoDelVicino.ID))
                        {
                            totale += vicinoDelVicino.NumeroAbitanti;
                        }
                    }
                }
            }

            return totale;
        }


        // MELLON WAS HERE
    }
}
