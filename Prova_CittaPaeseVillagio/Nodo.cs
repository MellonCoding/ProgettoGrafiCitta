using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_CittaPaeseVillagio
{
    class Nodo
    {
        protected List<Arco> archi;
        protected string nome;
        protected int id;
        protected int numero_ab;

        protected static int n;

        // id incrementale statico
        static Nodo() 
        {
            n = 0;
        }

        // const
        public Nodo(string nome, int numero_ab)
        {
            archi = new List<Arco>();

            this.nome = nome;
            this.numero_ab = numero_ab;
            
            this.id = n;
            n++;
        }

        // get di ID, Nome e Archi
        public int ID { get { return id; } }
        public string Nome { get { return nome; } }
        public Arco[] Archi { get { return archi.ToArray(); } }

        // crea arco e aggiungi alla lista
        public void add_arco(Nodo nx, int metrica)
        {
            archi.Add(new Arco(nx, metrica));
        }
        // passa arco e aggiungi alla lista
        public void add_arco(Arco a)
        {
            archi.Add(a);
        }
        // stampa
        public string stampa()
        {
            string s = nome+"\n" ;
            for (int i = 0; i < archi.Count; i++)
            {
                s = s + archi[i].stampa();
            }
            return s+"\n";
        }

        public void matrice(string[,] matrice, int pos)
        {
            for (int j = 0; j < archi.Count; j++)
            {
                for (int i = 1; i < matrice.GetLength(1); i++)
                {
                    if (matrice[0, i] == archi[j].Nome)
                    {
                        matrice[pos + 1, i] = archi[j].Metrica + "";
                    }
                }
            }
        }

        public void raggiungibile(ref Nodo[] precedenti,Nodo[] arr, ref int[] metriche, ref bool[] percorsi , int pos) 
        {
            percorsi[pos] = true;
            
            for (int j = 0; j < archi.Count; j++) 
            {
                for (int i = 0; i < arr.Length; i++) 
                {
                    if (!percorsi[i] && metriche[i] > (metriche[pos] + archi[j].Metrica))
                    {
                        precedenti[i] = arr[pos];
                        metriche[i] = (metriche[pos] + archi[j].Metrica);
                    }
                }
            }
            if (lower(metriche,percorsi,ref pos))
            {
                arr[pos].raggiungibile(ref precedenti,arr,ref metriche,ref percorsi,pos);
            }
            

        }
        public bool lower(int[] metriche,bool[] percorsi, ref int pos)
        {
            bool temp = false;
            int val=int.MaxValue-1;
            for (int i = 0; i < metriche.Length; i++) 
            {
                if (val > metriche[i] && percorsi[i]==false )
                { 
                    
                    val = metriche[i];
                    pos = i;
                    temp = true;
                }
            }
            return temp;

        }   

        
    }
}
