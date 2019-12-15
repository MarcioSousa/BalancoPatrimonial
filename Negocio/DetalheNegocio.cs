using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Model;
using Acesso;

namespace Negocio
{
    public class DetalheNegocio
    {
        readonly Acessomdf acessomdf = new Acessomdf();

        public string Inserir(Detalhe detalhe)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "INSERT INTO Detalhe(nome, sigla) VALUES ('" + detalhe.Nome + "','" + detalhe.Sigla + "')").ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Alterar(Detalhe detalhe)
        {
            try
            {
                acessomdf.LimparParametros();
                return acessomdf.ExecutarManipulacao(CommandType.Text, "UPDATE Detalhe SET nome = '" + detalhe.Nome + "' WHERE codigo = " + detalhe.Codigo).ToString();
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
                return acessomdf.ExecutarManipulacao(CommandType.Text, "DELETE FROM Detalhe WHERE codigo = " + codigo).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Detalhe> Detalhes(string sigla)
        {
            try
            {
                List<Detalhe> detalhes = new List<Detalhe>();
                DataTable dataTableDetalhes = new DataTable();
                
                acessomdf.LimparParametros();
                dataTableDetalhes = acessomdf.ExecutarConsulta(CommandType.Text, "SELECT codigo, nome, sigla FROM Detalhe WHERE sigla = '" + sigla + "'");

                foreach (DataRow linha in dataTableDetalhes.Rows)
                {
                    Detalhe detalhe = new Detalhe(Convert.ToInt32(linha["codigo"]), linha["nome"].ToString(), linha["sigla"].ToString());
                    detalhes.Add(detalhe);
                }

                return detalhes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
  
    }
}