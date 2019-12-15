using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Model;


namespace BalancoPatrimonial
{
    public partial class FrmDetalhe : Form
    {
        string sigla;
        public FrmDetalhe(string sigla)
        {
            InitializeComponent();
            DgvNomesDetalhe.AutoGenerateColumns = false;
            this.sigla = sigla;
        }

        private void FrmDetalhe_Load(object sender, EventArgs e)
        {
            if (sigla == "AC")
            {
                this.Text = "Lista dos Ativos Circulantes";
            }
            else if (sigla == "PC")
            {
                this.Text = "Lista dos Passivos Circulantes";
            }
            else if (sigla == "AI")
            {
                this.Text = "Lista dos Ativos Imobilizados";
            }
            else
            {
                this.Text = "Lista de Patrimônio Líquido";
            }
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                DetalheNegocio detalheNegocio = new DetalheNegocio();
                DgvNomesDetalhe.DataSource = detalheNegocio.Detalhes(sigla);

                DgvNomesDetalhe.Update();
                DgvNomesDetalhe.Refresh();

                if(DgvNomesDetalhe.Rows.Count != 0)
                {
                    BtnEditar.Visible = true;
                    BtnExcluir.Visible = true;
                }
                else
                {
                    BtnEditar.Visible = false;
                    BtnExcluir.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar o formulário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            IniciarAdicaoEdicao();
            BtnConfirmar.Text = "Confirmar Edicao";
            TxtNome.Text = DgvNomesDetalhe.Rows[DgvNomesDetalhe.CurrentRow.Index].Cells[1].Value.ToString();
            TxtNome.Focus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IniciarAdicaoEdicao()
        {
            BtnAdicionar.Visible = false;
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            GbxCadastro.Visible = true;
            DgvNomesDetalhe.Enabled = false;

        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            IniciarAdicaoEdicao();
            BtnConfirmar.Text = "Confirmar";
            TxtNome.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto Selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DetalheNegocio detalheNegocio = new DetalheNegocio();
                string mensagem = detalheNegocio.Excluir(Convert.ToInt32(DgvNomesDetalhe.Rows[DgvNomesDetalhe.CurrentRow.Index].Cells[0].Value));

                if (mensagem == "0")
                {
                    MessageBox.Show("Excluido com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o item selecionado.\nPossivelmente esteja tenha cadastro ainda ativo no sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CarregaGrid();
            }
        }

        private void EncerrarCampos()
        {
            BtnAdicionar.Visible = true;

            if (DgvNomesDetalhe.Rows.Count != 0)
            {
                BtnEditar.Visible = true;
                BtnEditar.Visible = true;
            }
            TxtNome.Text = "";
            GbxCadastro.Visible = false;
            DgvNomesDetalhe.Enabled = true;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            EncerrarCampos();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Trim() != "")
            {
                DetalheNegocio detalheNegocio = new DetalheNegocio();
                if (BtnConfirmar.Text == "Confirmar")
                {
                    //NOVO CADASTRO
                    Detalhe detalhe = new Detalhe(0, TxtNome.Text, sigla);
                    detalheNegocio.Inserir(detalhe);
                }
                else
                {
                    Detalhe detalhe = new Detalhe(Convert.ToInt32(DgvNomesDetalhe.Rows[DgvNomesDetalhe.CurrentRow.Index].Cells[0].Value), TxtNome.Text, "0");
                    detalheNegocio.Alterar(detalhe);
                }

                EncerrarCampos();
                CarregaGrid();
                BtnAdicionar.Focus();
            }
            else
            {
                MessageBox.Show("Campo de Nome vazio, digite um nome no campo!", "Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
            }
        }
    }
}
