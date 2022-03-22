using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscPlayer_By_Fernando_Santana
{
    class Musica
    {
        private string nome;
        private string local;
        private string album;
        private string duracao;
        private int bitRate;
        private int id;
        public int Id { get { return (id); } }
        public string Nome { get { return (nome); } set { nome = value; } }
        public string Local { get { return (local); } set { local = value; } }
        public string Album { get { return (album); } set { album = value; } }
        public string Duracao { get { return (duracao); } set { duracao = value; } }
        public int BitRate { get { return (bitRate); } set { bitRate = value; } }


        /*Construtor*/
        public Musica(int _id, string _nome, string _local, string _album, string _duracao, int _bitRate)
        {
            this.id = _id;
            this.nome = _nome;
            this.local = _local;
            this.album = _album;
            this.duracao = _duracao;
            this.bitRate = _bitRate;
        }
    }
}
