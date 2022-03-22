using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscPlayer_By_Fernando_Santana
{
    class Lista_Arquvios
    {
        class Celula
        {
            public Arquivo elemento;
            public Celula prox;
        }
        private static string _localArquivo;
        public static string localArquivo { get { return _localArquivo; } set { _localArquivo = value; } }
        private int tam;
        public int Tam { get { return (tam); } }
        private Celula primeiro, ultimo, aux;

        public Lista_Arquvios()
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
        public void AddUltimo(Arquivo Obj, int tamanho)
        {
            Random rnd = new Random();
            List<int> nValido = new List<int>();
            ultimo.prox = new Celula();
            ultimo.prox.elemento = Obj;
            ultimo = ultimo.prox;
            tam++;
        }
        public void ADDArquivos(int ProxArq)
        {
            localArquivo = "";
            aux = primeiro.prox;
            while (aux != null)
            {
                if (aux.elemento.ID == ProxArq)
                {
                    localArquivo = aux.elemento.Local;
                    Console.WriteLine("Próxima música é: [" + ProxArq + "] Nome: " + localArquivo);

                }
                aux = aux.prox;
            }
        }
    }
}
