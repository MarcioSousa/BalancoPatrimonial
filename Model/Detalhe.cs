using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Detalhe
    {
        private int codigo;
        private string nome;
        private string sigla;

        public Detalhe(int codigo, string nome, string sigla)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sigla = sigla;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
    }
}
