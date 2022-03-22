using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuiscPlayer_By_Fernando_Santana
{
    class Arquivo
    {
        private string nome;
        private string local;
        private string ext;
        private int id;

        public string Nome { get { return (nome); } set { nome = value; } }
        public string Local { get { return (local); } set { local = value; } }
        public string Ext { get { return (ext); } set { ext = value; } }
        public int ID { get { return (id); } set { id = value; } }

        /*Construtor*/
        public Arquivo(string _nome, string _local, string _ext, int _id)
        {
            nome = _nome;
            local = _local;
            ext = _ext;
            id = _id;
        }
    }
}
