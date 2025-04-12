﻿using System;
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

        public Nodo[] arrNodi  
        { 
            get { return Nodi.ToArray(); }
        }

        public int findPos(Nodo nodo) 
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
        public void Add_Nodo(Nodo nodo)
        {
            Nodi.Add(nodo);
        }
        // crea nodo e aggiungi alla lista
        public void Add_Nodo(string nome,int numeroAbitanti)
        {
            Nodi.Add(new Nodo(nome, numeroAbitanti));
        }

        // aggiunge 
        public void Add_Arco_bi(int nodoPartenza, int nodoArrivo, int metrica)
        {
            Add_Arco(nodoArrivo, nodoPartenza, metrica);
            Add_Arco(nodoPartenza, nodoArrivo, metrica);
        }

        public void Add_Arco(int partenza, int arrivo, int metrica)
        {
            Arco arco = new Arco(Nodi[arrivo], metrica);
            Nodi[partenza].add_arco(arco);
        }


        public string stampaNodi()
        {
            string s = "";
            for (int i = 0; i < Nodi.Count; i++)
            {
                s=s+Nodi[i].stampa();
            }
            return s;
        }

        public int raggiungibile(int posizionePartenza,int posizioneFinale)
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

            Nodi[posizionePartenza].raggiungibile(ref precedenti,Nodi.ToArray(),ref metriche,ref percorsi,posizionePartenza);

            return metriche[posizioneFinale];
        }

        public string[] get_lista() 
        {
            string[] nomi = new string[Nodi.Count];

            for (int i = 0; i < Nodi.Count; i++)
            {
                nomi[i]=Nodi[i].Nome;
            }

            return nomi;
        }
    }
}
