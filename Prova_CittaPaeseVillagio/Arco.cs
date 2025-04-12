using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_CittaPaeseVillagio
{
    class Arco
    {
        protected Nodo next;
        protected int metrica;
        
        // const
        public Arco(Nodo nx, int metrica)
        {
            this.next = nx;
            this.metrica = metrica;
        }

        // get dei vari parametri
        public string stampa()
        {
            return (" --(" + metrica + ")--> " + next.Nome+"\n");
        }

        public string Nome
        {
            get { return next.Nome; }
        }

        public int Metrica
        {
            get { return metrica; }
        }

        public Nodo Next
        {
            get { return next; }
        }
    }
}
