using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Acesso;
using Model;

namespace Negocio
{
    public class BalancoNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();
        public string Inserir(Balanco balanco)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Balanco(codigodetalhe, ano, valor) VALUES (" + balanco.Codigodetalhe + "," + balanco.Ano + "," + balanco.Valor.ToString().Replace(",",".") + ")").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Balanco balanco)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Balanco SET codigodetalhe = " + balanco.Codigodetalhe + ", ano = " + balanco.Ano + ", valor = " + balanco.Valor.ToString().Replace(",",".") + " WHERE codigo = " + balanco.Codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(int codigo)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Balanco WHERE codigo = " + codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public double RetornarValor(int ano, int codigodetalhe)
        {
            try
            {
                double valor = 0;

                DataTable dataTableValor = new DataTable();
                acessomdf.LimparParametros();
                dataTableValor = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT valor FROM Balanco WHERE ano = " + ano + " AND codigodetalhe = " + codigodetalhe);

                if(dataTableValor.Rows.Count != 0)
                {
                    valor = Convert.ToDouble(dataTableValor.Rows[0]["valor"]);
                }

                return valor;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Balanco SeExistir(int codigodetalhe, int ano)
        {
            try
            {
                Balanco balanco;
                DataTable dataTableBalanco = new DataTable();

                acessomdf.LimparParametros();
                dataTableBalanco = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo FROM Balanco WHERE codigodetalhe = " + codigodetalhe + " AND ano = " + ano);

                if (dataTableBalanco.Rows.Count != 0)
                {
                    balanco = new Balanco(Convert.ToInt32(dataTableBalanco.Rows[0]["codigo"]));
                }
                else
                {
                    balanco = new Balanco(0);
                }

                return balanco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
