using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Balanco
    {
        private int codigo;
        private int codigodetalhe;
        private double valor;
        private int ano;

        public Balanco()
        {
        }

        public Balanco(int codigo)
        {
            this.codigo = codigo;
        }

        public Balanco(int codigo, int codigodetalhe, double valor, int ano)
        {
            this.codigo = codigo;
            this.codigodetalhe = codigodetalhe;
            this.valor = valor;
            this.ano = ano;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigodetalhe { get => codigodetalhe; set => codigodetalhe = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
