using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscPlayer_By_Fernando_Santana
{
    class PlayList
    {
        class Celula
        {
            public Musica elemento;
            public Celula prox;
        }
        private static string _localPlay;
        public static string localPlay { get { return _localPlay; } set { _localPlay = value; } }
        public bool pronto;
        private int tam; List<int> valores = new List<int>();
        public int Tam { get { return (tam); } }
        private Celula primeiro, ultimo, aux;

        public PlayList()
        {
            tam = 0;
            primeiro = new Celula();
            primeiro.elemento = null;
            ultimo = primeiro;
        }
        public bool Vazia()
        {
            return (primeiro == ultimo);
        }
        public void AddUltimo(Musica Obj, int tamanho)
        {
            Random rnd = new Random();
            List<int> nValido = new List<int>();
            ultimo.prox = new Celula();
            ultimo.prox.elemento = Obj;
            ultimo = ultimo.prox;
            Console.WriteLine("Item adicionado com sucesso! " + tam);
            tam++;
        }
        public void PlayMusicas2(int ProxMusica)
        {
            localPlay = "";
            aux = primeiro.prox;
            while (aux != null)
            {
                pronto = false;
                if (aux.elemento.Id == ProxMusica)
                {
                    localPlay = aux.elemento.Local;
                    pronto = true;
                    Console.WriteLine("Próxima música é: [" + ProxMusica + "] Nome: " + localPlay);
                }
                aux = aux.prox;
            }
        }
    }
}
