using System;
using System.Windows.Forms;
using Negocio;
using Model;
using System.Collections.Generic;

namespace BalancoPatrimonial
{
    public partial class FrmBalancoPatrimonial : Form
    {
        public FrmBalancoPatrimonial()
        {
            InitializeComponent();
            DgvAC.AutoGenerateColumns = false;
            DgvPC.AutoGenerateColumns = false;
            DgvAI.AutoGenerateColumns = false;
            DgvPL.AutoGenerateColumns = false;
        }
        private void FrmBalancoPatrimonial_Load(object sender, EventArgs e)
        {
            CarregaGridAc();
            CarregaGridPc();
            CarregaGridAi();
            CarregaGridPl();
            SomaValoresGridAc();
            SomaValoresGridPc();
            SomaValoresGridAi();
            SomaValoresGridPl();
            SomaValoresTotalAtivo();
            SomaValoresTotalPassivo();
        }
        private void CarregaGridAc()
        {
            DgvAC.Rows.Clear();
            DgvAC.Columns[2].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 2).ToString();
            DgvAC.Columns[3].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 1).ToString();
            DgvAC.Columns[4].HeaderText = "31/12/" + DateTime.Today.Date.Year.ToString();

            int count = 2;
            DetalheNegocio detalheNegocio = new DetalheNegocio();
            BalancoNegocio balancoNegocio = new BalancoNegocio();
            List<Detalhe> detalhes = new List<Detalhe>();

            detalhes = detalheNegocio.Detalhes("AC");

            CbxDetalhesAC.DataSource = detalhes;
            CbxDetalhesAC.DisplayMember = "nome";
            CbxDetalhesAC.ValueMember = "codigo";

            CbxDetalhesAC.SelectedIndex = -1;

            for (int t = 0; t < detalhes.Count; t++)
            {
                DgvAC.Rows.Add(detalhes[t].Codigo, detalhes[t].Nome);

                for (int a = 2; a > -1; a--)
                {
                    DgvAC.Rows[t].Cells[count].Value = balancoNegocio.RetornarValor(DateTime.Today.Date.Year - a, detalhes[t].Codigo);
                    count++;
                }
                count = 2;
            }
            
            if(DgvAC.Rows.Count == 0)
            {
                BtnInserirAC.Visible = false;
                BtnEditarAC.Visible = false;
                BtnExcluirAC.Visible = false;
            }
            else
            {
                BtnInserirAC.Visible = true;
            }
        }
        private void CarregaGridPc()
        {

            DgvPC.Rows.Clear();
            DgvPC.Columns[2].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 2).ToString();
            DgvPC.Columns[3].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 1).ToString();
            DgvPC.Columns[4].HeaderText = "31/12/" + DateTime.Today.Date.Year.ToString();

            int count = 2;
            DetalheNegocio detalheNegocio = new DetalheNegocio();
            BalancoNegocio balancoNegocio = new BalancoNegocio();
            List<Detalhe> detalhes = new List<Detalhe>();

            detalhes = detalheNegocio.Detalhes("PC");

            CbxDetalhesPC.DataSource = detalhes;
            CbxDetalhesPC.DisplayMember = "nome";
            CbxDetalhesPC.ValueMember = "codigo";

            CbxDetalhesPC.SelectedIndex = -1;

            for (int t = 0; t < detalhes.Count; t++)
            {
                DgvPC.Rows.Add(detalhes[t].Codigo, detalhes[t].Nome);

                for (int a = 2; a > -1; a--)
                {
                    DgvPC.Rows[t].Cells[count].Value = balancoNegocio.RetornarValor(DateTime.Today.Date.Year - a, detalhes[t].Codigo);
                    count++;
                }
                count = 2;
            }

            if (DgvPC.Rows.Count == 0)
            {
                BtnInserirPC.Visible = false;
                BtnEditarPC.Visible = false;
                BtnExcluirPC.Visible = false;
            }
            else
            {
                BtnInserirPC.Visible = true;
            }
        }
        private void CarregaGridAi()
        {
            DgvAI.Rows.Clear();
            DgvAI.Columns[2].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 2).ToString();
            DgvAI.Columns[3].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 1).ToString();
            DgvAI.Columns[4].HeaderText = "31/12/" + DateTime.Today.Date.Year.ToString();

            int count = 2;
            DetalheNegocio detalheNegocio = new DetalheNegocio();
            BalancoNegocio balancoNegocio = new BalancoNegocio();
            List<Detalhe> detalhes = new List<Detalhe>();

            detalhes = detalheNegocio.Detalhes("AI");

            CbxDetalhesAI.DataSource = detalhes;
            CbxDetalhesAI.DisplayMember = "nome";
            CbxDetalhesAI.ValueMember = "codigo";

            CbxDetalhesAI.SelectedIndex = -1;

            for (int t = 0; t < detalhes.Count; t++)
            {
                DgvAI.Rows.Add(detalhes[t].Codigo, detalhes[t].Nome);

                for (int a = 2; a > -1; a--)
                {
                    DgvAI.Rows[t].Cells[count].Value = balancoNegocio.RetornarValor(DateTime.Today.Date.Year - a, detalhes[t].Codigo);
                    count++;
                }
                count = 2;
            }

            if (DgvAI.Rows.Count == 0)
            {
                BtnInserirAI.Visible = false;
                BtnEditarAI.Visible = false;
                BtnExcluirAI.Visible = false;
            }
            else
            {
                BtnInserirAI.Visible = true;
            }
        }
        private void CarregaGridPl()
        {
            DgvPL.Rows.Clear();
            DgvPL.Columns[2].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 2).ToString();
            DgvPL.Columns[3].HeaderText = "31/12/" + (DateTime.Today.Date.Year - 1).ToString();
            DgvPL.Columns[4].HeaderText = "31/12/" + DateTime.Today.Date.Year.ToString();

            int count = 2;
            DetalheNegocio detalheNegocio = new DetalheNegocio();
            BalancoNegocio balancoNegocio = new BalancoNegocio();
            List<Detalhe> detalhes = new List<Detalhe>();

            detalhes = detalheNegocio.Detalhes("PL");

            CbxDetalhesPL.DataSource = detalhes;
            CbxDetalhesPL.DisplayMember = "nome";
            CbxDetalhesPL.ValueMember = "codigo";

            CbxDetalhesPL.SelectedIndex = -1;

            for (int t = 0; t < detalhes.Count; t++)
            {
                DgvPL.Rows.Add(detalhes[t].Codigo, detalhes[t].Nome);

                for (int a = 2; a > -1; a--)
                {
                    DgvPL.Rows[t].Cells[count].Value = balancoNegocio.RetornarValor(DateTime.Today.Date.Year - a, detalhes[t].Codigo);
                    count++;
                }
                count = 2;
            }

            if (DgvPL.Rows.Count == 0)
            {
                BtnInserirPL.Visible = false;
                BtnEditarPL.Visible = false;
                BtnExcluirPL.Visible = false;
            }
            else
            {
                BtnInserirPL.Visible = true;
            }
        }
        private void SomaValoresGridAc()
        {
            double valor = 0;

            for (int c = 2; c < 5; c++)
            {
                for (int t = 0; t < DgvAC.Rows.Count; t++)
                {
                    valor = valor + Convert.ToDouble(DgvAC.Rows[t].Cells[c].Value);
                }

                if (c == 2)
                {
                    LblTotalAno3AC.Text = valor.ToString("C");
                }
                else if (c == 3)
                {
                    LblTotalAno2AC.Text = valor.ToString("C");
                }
                else
                {
                    LblTotalAnoAC.Text = valor.ToString("C");
                }

                valor = 0;
            }

        }
        private void SomaValoresGridPc()
        {
            double valor = 0;

            for (int c = 2; c < 5; c++)
            {
                for (int t = 0; t < DgvPC.Rows.Count; t++)
                {
                    valor = valor + Convert.ToDouble(DgvPC.Rows[t].Cells[c].Value);
                }

                if (c == 2)
                {
                    LblTotalAno3PC.Text = valor.ToString("C");
                }
                else if (c == 3)
                {
                    LblTotalAno2PC.Text = valor.ToString("C");
                }
                else
                {
                    LblTotalAnoPC.Text = valor.ToString("C");
                }

                valor = 0;
            }

        }
        private void SomaValoresGridAi()
        {
            double valor = 0;

            for (int c = 2; c < 5; c++)
            {
                for (int t = 0; t < DgvAI.Rows.Count; t++)
                {
                    valor = valor + Convert.ToDouble(DgvAI.Rows[t].Cells[c].Value);
                }

                if (c == 2)
                {
                    LblTotalAno3AI.Text = valor.ToString("C");
                }
                else if (c == 3)
                {
                    LblTotalAno2AI.Text = valor.ToString("C");
                }
                else
                {
                    LblTotalAnoAI.Text = valor.ToString("C");
                }

                valor = 0;
            }

        }
        private void SomaValoresGridPl()
        {
            double valor = 0;

            for (int c = 2; c < 5; c++)
            {
                for (int t = 0; t < DgvPL.Rows.Count; t++)
                {
                    valor = valor + Convert.ToDouble(DgvPL.Rows[t].Cells[c].Value);
                }

                if (c == 2)
                {
                    LblTotalAno3PL.Text = valor.ToString("C");
                }
                else if (c == 3)
                {
                    LblTotalAno2PL.Text = valor.ToString("C");
                }
                else
                {
                    LblTotalAnoPL.Text = valor.ToString("C");
                }

                valor = 0;
            }

        }
        private void AbrirCamposAC()
        {
            LblAnoAC.Visible = true;
            LblValorAC.Visible = true;
            TxtAnoAC.Visible = true;
            TxtValorAC.Visible = true;
            LblAc.Visible = true;
            CbxDetalhesAC.Visible = true;
            DgvAC.Enabled = false;
            CbxDetalhesAC.Focus();
        }
        private void AbrirCamposPC()
        {
            LblAnoPC.Visible = true;
            LblValorPC.Visible = true;
            TxtAnoPC.Visible = true;
            TxtValorPC.Visible = true;
            LblPc.Visible = true;
            CbxDetalhesPC.Visible = true;
            DgvPC.Enabled = false;
            CbxDetalhesPC.Focus();
        }
        private void AbrirCamposAI()
        {
            LblAnoAI.Visible = true;
            LblValorAI.Visible = true;
            TxtAnoAI.Visible = true;
            TxtValorAI.Visible = true;
            LblAi.Visible = true;
            CbxDetalhesAI.Visible = true;
            DgvAI.Enabled = false;
            CbxDetalhesAI.Focus();
        }
        private void AbrirCamposPL()
        {
            LblAnoPL.Visible = true;
            LblValorPL.Visible = true;
            TxtAnoPL.Visible = true;
            TxtValorPL.Visible = true;
            LblPl.Visible = true;
            CbxDetalhesPL.Visible = true;
            DgvPL.Enabled = false;
            CbxDetalhesPL.Focus();
        }
        private void FecharCamposAC()
        {
            LblAnoAC.Visible = false;
            LblValorAC.Visible = false;
            TxtAnoAC.Visible = false;
            TxtValorAC.Visible = false;
            LblAc.Visible = false;
            CbxDetalhesAC.Visible = false;
            DgvAC.Enabled =true;
        }
        private void FecharCamposPC()
        {
            LblAnoPC.Visible = false;
            LblValorPC.Visible = false;
            TxtAnoPC.Visible = false;
            TxtValorPC.Visible = false;
            LblPc.Visible = false;
            CbxDetalhesPC.Visible = false;
            DgvPC.Enabled = true;
        }
        private void FecharCamposAI()
        {
            LblAnoAI.Visible = false;
            LblValorAI.Visible = false;
            TxtAnoAI.Visible = false;
            TxtValorAI.Visible = false;
            LblAi.Visible = false;
            CbxDetalhesAI.Visible = false;
            DgvAI.Enabled = true;
        }
        private void FecharCamposPL()
        {
            LblAnoPL.Visible = false;
            LblValorPL.Visible = false;
            TxtAnoPL.Visible = false;
            TxtValorPL.Visible = false;
            LblPl.Visible = false;
            CbxDetalhesPL.Visible = false;
            DgvPL.Enabled = true;
        }
        private void LimpaCamposAC()
        {
            CbxDetalhesAC.SelectedIndex = -1;
            TxtAnoAC.Text = "";
            TxtValorAC.Text = "";
        }
        private void LimpaCamposPC()
        {
            CbxDetalhesPC.SelectedIndex = -1;
            TxtAnoPC.Text = "";
            TxtValorPC.Text = "";
        }
        private void LimpaCamposAI()
        {
            CbxDetalhesAI.SelectedIndex = -1;
            TxtAnoAI.Text = "";
            TxtValorAI.Text = "";
        }
        private void LimpaCamposPL()
        {
            CbxDetalhesPL.SelectedIndex = -1;
            TxtAnoPL.Text = "";
            TxtValorPL.Text = "";
        }
        private void BotoesIniciarCadastroAC()
        {
            BtnInserirAC.Visible = false;
            BtnEditarAC.Visible = false;
            BtnExcluirAC.Visible = false;

            BtnConfirmarAC.Visible = true;
            BtnCancelarAC.Visible = true;
        }
        private void BotoesIniciarCadastroPC()
        {
            BtnInserirPC.Visible = false;
            BtnEditarPC.Visible = false;
            BtnExcluirPC.Visible = false;

            BtnConfirmarPC.Visible = true;
            BtnCancelarPC.Visible = true;
        }
        private void BotoesIniciarCadastroAI()
        {
            BtnInserirAI.Visible = false;
            BtnEditarAI.Visible = false;
            BtnExcluirAI.Visible = false;

            BtnConfirmarAI.Visible = true;
            BtnCancelarAI.Visible = true;
        }
        private void BotoesIniciarCadastroPL()
        {
            BtnInserirPL.Visible = false;
            BtnEditarPL.Visible = false;
            BtnExcluirPL.Visible = false;

            BtnConfirmarPL.Visible = true;
            BtnCancelarPL.Visible = true;
        }
        private void BotoesEncerrarCadastroAC()
        {
            BtnInserirAC.Visible = true;
            BtnEditarAC.Visible = true;
            BtnExcluirAC.Visible = true;

            BtnConfirmarAC.Visible = false;
            BtnCancelarAC.Visible = false;
        }
        private void BotoesEncerrarCadastroPC()
        {
            BtnInserirPC.Visible = true;
            BtnEditarPC.Visible = true;
            BtnExcluirPC.Visible = true;

            BtnConfirmarPC.Visible = false;
            BtnCancelarPC.Visible = false;
        }
        private void BotoesEncerrarCadastroAI()
        {
            BtnInserirAI.Visible = true;
            BtnEditarAI.Visible = true;
            BtnExcluirAI.Visible = true;

            BtnConfirmarAI.Visible = false;
            BtnCancelarAI.Visible = false;
        }
        private void BotoesEncerrarCadastroPL()
        {
            BtnInserirPL.Visible = true;
            BtnEditarPL.Visible = true;
            BtnExcluirPL.Visible = true;

            BtnConfirmarPL.Visible = false;
            BtnCancelarPL.Visible = false;
        }
        private void VerificarSelecionadoAC()
        {
            if (DgvAC.CurrentCell.ColumnIndex < 2)
            {
                DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[1].Selected = false;
                BtnEditarAC.Visible = false;
                BtnExcluirAC.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[DgvAC.CurrentCell.ColumnIndex].Value) != 0)
                {
                    BtnEditarAC.Visible = true;
                    BtnExcluirAC.Visible = true;
                }
                else
                {
                    BtnEditarAC.Visible = false;
                    BtnExcluirAC.Visible = false;
                }

            }
        }
        private void VerificarSelecionadoPC()
        {
            if (DgvPC.CurrentCell.ColumnIndex < 2)
            {
                DgvPC.Rows[DgvPC.CurrentRow.Index].Cells[1].Selected = false;
                BtnEditarPC.Visible = false;
                BtnExcluirPC.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(DgvPC.Rows[DgvPC.CurrentRow.Index].Cells[DgvPC.CurrentCell.ColumnIndex].Value) != 0)
                {
                    BtnEditarPC.Visible = true;
                    BtnExcluirPC.Visible = true;
                }
                else
                {
                    BtnEditarPC.Visible = false;
                    BtnExcluirPC.Visible = false;
                }

            }
        }
        private void VerificarSelecionadoAI()
        {
            if (DgvAI.CurrentCell.ColumnIndex < 2)
            {
                DgvAI.Rows[DgvAI.CurrentRow.Index].Cells[1].Selected = false;
                BtnEditarAI.Visible = false;
                BtnExcluirAI.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(DgvAI.Rows[DgvAI.CurrentRow.Index].Cells[DgvAI.CurrentCell.ColumnIndex].Value) != 0)
                {
                    BtnEditarAI.Visible = true;
                    BtnExcluirAI.Visible = true;
                }
                else
                {
                    BtnEditarAI.Visible = false;
                    BtnExcluirAI.Visible = false;
                }

            }
        }
        private void VerificarSelecionadoPL()
        {
            if (DgvPL.CurrentCell.ColumnIndex < 2)
            {
                DgvPL.Rows[DgvPL.CurrentRow.Index].Cells[1].Selected = false;
                BtnEditarPL.Visible = false;
                BtnExcluirPL.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(DgvPL.Rows[DgvPL.CurrentRow.Index].Cells[DgvPL.CurrentCell.ColumnIndex].Value) != 0)
                {
                    BtnEditarPL.Visible = true;
                    BtnExcluirPL.Visible = true;
                }
                else
                {
                    BtnEditarPL.Visible = false;
                    BtnExcluirPL.Visible = false;
                }

            }
        }
        private void SomaValoresTotalAtivo()
        {
            LblTotalAno3A.Text = (Convert.ToDouble(LblTotalAno3AC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAno3AI.Text.Remove(0, 2))).ToString("C");
            LblTotalAno2A.Text = (Convert.ToDouble(LblTotalAno2AC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAno2AI.Text.Remove(0, 2))).ToString("C");
            LblTotalAnoA.Text = (Convert.ToDouble(LblTotalAnoAC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAnoAI.Text.Remove(0, 2))).ToString("C");
        }
        private void SomaValoresTotalPassivo()
        {
            LblTotalAno3P.Text = (Convert.ToDouble(LblTotalAno3PC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAno3PL.Text.Remove(0, 2))).ToString("C");
            LblTotalAno2P.Text = (Convert.ToDouble(LblTotalAno2PC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAno2PL.Text.Remove(0, 2))).ToString("C");
            LblTotalAnoP.Text = (Convert.ToDouble(LblTotalAnoPC.Text.Remove(0, 2)) + Convert.ToDouble(LblTotalAnoPL.Text.Remove(0, 2))).ToString("C");
        }

        //Ativos Circulantes
        private void BtnConfirmarAC_Click(object sender, EventArgs e)
        {
            if(CbxDetalhesAC.Text != "" && TxtAnoAC.Text != "" && TxtValorAC.Text != "")
            {
                double valor = Convert.ToDouble(TxtValorAC.Text);

                if (valor != 0)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(CbxDetalhesAC.SelectedValue), Convert.ToInt32(TxtAnoAC.Text));
                    balanco.Codigodetalhe = Convert.ToInt32(CbxDetalhesAC.SelectedValue);
                    balanco.Ano = Convert.ToInt32(TxtAnoAC.Text);
                    balanco.Valor = Convert.ToDouble(TxtValorAC.Text);

                    if (balanco.Codigo == 0)
                    {
                        balancoNegocio.Inserir(balanco);
                    }
                    else
                    {
                        balancoNegocio.Alterar(balanco);
                    }

                    FecharCamposAC();
                    BotoesEncerrarCadastroAC();
                    LimpaCamposAC();
                    CarregaGridAc();
                    SomaValoresGridAc();
                    SomaValoresTotalAtivo();
                }
                else
                {
                    MessageBox.Show("Digite um valor diferente de '0' para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorAC.Focus();
                }
            }
            else
            {
                if(CbxDetalhesAC.Text == "")
                {
                    MessageBox.Show("Selecione um Ativo Circulante!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbxDetalhesAC.Focus();
                }else if(TxtAnoAC.Text == "")
                {
                    MessageBox.Show("Digite um ano para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAnoAC.Focus();

                }else
                {
                    MessageBox.Show("Digite um valor para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorAC.Focus();
                }
            }
        }
        private void BtnCancelarAC_Click(object sender, EventArgs e)
        {
            FecharCamposAC();
            BotoesEncerrarCadastroAC();
            LimpaCamposAC();

            VerificarSelecionadoAC();
        }
        private void BtnEditarAC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvAC.CurrentCell.ColumnIndex) > 1)
            {
                AbrirCamposAC();
                BotoesIniciarCadastroAC();

                TxtAnoAC.Text = DgvAC.Columns[DgvAC.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6);
                TxtValorAC.Text = DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[DgvAC.CurrentCell.ColumnIndex].Value.ToString();
                CbxDetalhesAC.Text = DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[1].Value.ToString();

                CbxDetalhesAC.Focus();
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Ativo Circulante da Tabela para ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnExcluirAC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvAC.CurrentCell.ColumnIndex) > 1)
            {
                if (MessageBox.Show("Deseja fazer a exclusão do valor da tabela que está selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(DgvAC.Columns[DgvAC.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6)));

                    if (balancoNegocio.Excluir(balanco.Codigo).ToString() == "0" && balanco.Codigo != 0)
                    {
                        MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridAc();
                        SomaValoresGridAc();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados valores para a exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Ativo Circulante da Tabela para ser Excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DgvAC_SelectionChanged(object sender, EventArgs e)
        {
            VerificarSelecionadoAC();
        }
        private void BtnAtivoC_Click(object sender, EventArgs e)
        {
            FrmDetalhe frmDetalhe = new FrmDetalhe("AC");
            frmDetalhe.ShowDialog();
            CarregaGridAc();
            SomaValoresGridAc();
        }
        private void BtnPassivoC_Click(object sender, EventArgs e)
        {
            FrmDetalhe frmDetalhe = new FrmDetalhe("PC");
            frmDetalhe.ShowDialog();
            CarregaGridPc();
            SomaValoresGridPc();

        }
        private void BtnAtivoI_Click(object sender, EventArgs e)
        {
            FrmDetalhe frmDetalhe = new FrmDetalhe("AI");
            frmDetalhe.ShowDialog();
            CarregaGridAi();
            SomaValoresGridAi();
        }
        private void BtnPassivoL_Click(object sender, EventArgs e)
        {
            FrmDetalhe frmDetalhe = new FrmDetalhe("PL");
            frmDetalhe.ShowDialog();
            CarregaGridPl();
            SomaValoresGridPl();
        }
        private void TxtAnoAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtAnoPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtAnoAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtAnoPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtValorAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValorAC.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == '-')
            {
                if (TxtValorAC.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtValorPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValorPC.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == '-')
            {
                if (TxtValorPC.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtValorAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValorAI.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            if (e.KeyChar == '-')
            {
                if (TxtValorAI.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void TxtValorPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (TxtValorPL.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if(e.KeyChar == '-')
            {
                if (TxtValorPL.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void BtnInserirAC_Click(object sender, EventArgs e)
        {
            AbrirCamposAC();
            BotoesIniciarCadastroAC();
        }
        private void BtnInserirPC_Click(object sender, EventArgs e)
        {
            AbrirCamposPC();
            BotoesIniciarCadastroPC();
        }
        private void BtnInserirAI_Click(object sender, EventArgs e)
        {
            AbrirCamposAI();
            BotoesIniciarCadastroAI();
        }
        private void BtnInserirPL_Click(object sender, EventArgs e)
        {
            AbrirCamposPL();
            BotoesIniciarCadastroPL();
        }
        private void BtnConfirmarPC_Click(object sender, EventArgs e)
        {
            if (CbxDetalhesPC.Text != "" && TxtAnoPC.Text != "" && TxtValorPC.Text != "")
            {
                double valor = Convert.ToDouble(TxtValorPC.Text);

                if (valor != 0)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(CbxDetalhesPC.SelectedValue), Convert.ToInt32(TxtAnoPC.Text));
                    balanco.Codigodetalhe = Convert.ToInt32(CbxDetalhesPC.SelectedValue);
                    balanco.Ano = Convert.ToInt32(TxtAnoPC.Text);
                    balanco.Valor = Convert.ToDouble(TxtValorPC.Text);

                    if (balanco.Codigo == 0)
                    {
                        balancoNegocio.Inserir(balanco);
                    }
                    else
                    {
                        balancoNegocio.Alterar(balanco);
                    }

                    FecharCamposPC();
                    BotoesEncerrarCadastroPC();
                    LimpaCamposPC();
                    CarregaGridPc();
                    SomaValoresGridPc();
                    SomaValoresTotalPassivo();
                }
                else
                {
                    MessageBox.Show("Digite um valor diferente de '0' para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorPC.Focus();
                }
            }
            else
            {
                if (CbxDetalhesPC.Text == "")
                {
                    MessageBox.Show("Selecione um Passivo Circulante!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbxDetalhesPC.Focus();
                }
                else if (TxtAnoPC.Text == "")
                {
                    MessageBox.Show("Digite um ano para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAnoPC.Focus();

                }
                else
                {
                    MessageBox.Show("Digite um valor para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorPC.Focus();
                }
            }
        }
        private void BtnConfirmarAI_Click(object sender, EventArgs e)
        {
            if (CbxDetalhesAI.Text != "" && TxtAnoAI.Text != "" && TxtValorAI.Text != "")
            {
                double valor = Convert.ToDouble(TxtValorAI.Text);

                if (valor != 0)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(CbxDetalhesAI.SelectedValue), Convert.ToInt32(TxtAnoAI.Text));
                    balanco.Codigodetalhe = Convert.ToInt32(CbxDetalhesAI.SelectedValue);
                    balanco.Ano = Convert.ToInt32(TxtAnoAI.Text);
                    balanco.Valor = Convert.ToDouble(TxtValorAI.Text);

                    if (balanco.Codigo == 0)
                    {
                        balancoNegocio.Inserir(balanco);
                    }
                    else
                    {
                        balancoNegocio.Alterar(balanco);
                    }

                    FecharCamposAI();
                    BotoesEncerrarCadastroAI();
                    LimpaCamposAI();
                    CarregaGridAi();
                    SomaValoresGridAi();
                    SomaValoresTotalAtivo();
                }
                else
                {
                    MessageBox.Show("Digite um valor diferente de '0' para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorAC.Focus();
                }
            }
            else
            {
                if (CbxDetalhesAC.Text == "")
                {
                    MessageBox.Show("Selecione um Ativo Imobilizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbxDetalhesAI.Focus();
                }
                else if (TxtAnoAC.Text == "")
                {
                    MessageBox.Show("Digite um ano para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAnoAI.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um valor para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorAI.Focus();
                }
            }
        }
        private void BtnConfirmarPL_Click(object sender, EventArgs e)
        {
            if (CbxDetalhesPL.Text != "" && TxtAnoPL.Text != "" && TxtValorPL.Text != "")
            {
                double valor = Convert.ToDouble(TxtValorPL.Text);

                if (valor != 0)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(CbxDetalhesPL.SelectedValue), Convert.ToInt32(TxtAnoPL.Text));
                    balanco.Codigodetalhe = Convert.ToInt32(CbxDetalhesPL.SelectedValue);
                    balanco.Ano = Convert.ToInt32(TxtAnoPL.Text);
                    balanco.Valor = Convert.ToDouble(TxtValorPL.Text);

                    if (balanco.Codigo == 0)
                    {
                        balancoNegocio.Inserir(balanco);
                    }
                    else
                    {
                        balancoNegocio.Alterar(balanco);
                    }

                    FecharCamposPL();
                    BotoesEncerrarCadastroPL();
                    LimpaCamposPL();
                    CarregaGridPl();
                    SomaValoresGridPl();
                    SomaValoresTotalPassivo();
                }
                else
                {
                    MessageBox.Show("Digite um valor diferente de '0' para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorPL.Focus();
                }
            }
            else
            {
                if (CbxDetalhesPL.Text == "")
                {
                    MessageBox.Show("Selecione um Patrimônio Líquido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbxDetalhesPL.Focus();
                }
                else if (TxtAnoPL.Text == "")
                {
                    MessageBox.Show("Digite um ano para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAnoPL.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um valor para confirmar o cadastro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtValorPL.Focus();
                }
            }
        }
        private void BtnCancelarPC_Click(object sender, EventArgs e)
        {
            FecharCamposPC();
            BotoesEncerrarCadastroPC();
            LimpaCamposPC();

            VerificarSelecionadoPC();
        }
        private void BtnCancelarAI_Click(object sender, EventArgs e)
        {
            FecharCamposAI();
            BotoesEncerrarCadastroAI();
            LimpaCamposAI();

            VerificarSelecionadoAI();
        }
        private void BtnCancelarPL_Click(object sender, EventArgs e)
        {
            FecharCamposPL();
            BotoesEncerrarCadastroPL();
            LimpaCamposPL();

            VerificarSelecionadoPL();
        }
        private void BtnEditarPC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvPC.CurrentCell.ColumnIndex) > 1)
            {
                AbrirCamposPC();
                BotoesIniciarCadastroPC();

                TxtAnoPC.Text = DgvPC.Columns[DgvPC.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6);
                TxtValorPC.Text = DgvPC.Rows[DgvPC.CurrentRow.Index].Cells[DgvPC.CurrentCell.ColumnIndex].Value.ToString();
                CbxDetalhesPC.Text = DgvPC.Rows[DgvPC.CurrentRow.Index].Cells[1].Value.ToString();

                CbxDetalhesPC.Focus();
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Passivo Circulante da Tabela para ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnEditarAI_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvAI.CurrentCell.ColumnIndex) > 1)
            {
                AbrirCamposAI();
                BotoesIniciarCadastroAI();

                TxtAnoAI.Text = DgvAI.Columns[DgvAI.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6);
                TxtValorAI.Text = DgvAI.Rows[DgvAI.CurrentRow.Index].Cells[DgvAI.CurrentCell.ColumnIndex].Value.ToString();
                CbxDetalhesAI.Text = DgvAI.Rows[DgvAI.CurrentRow.Index].Cells[1].Value.ToString();

                CbxDetalhesAI.Focus();
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Ativo Imobilizado da Tabela para ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnEditarPL_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvPL.CurrentCell.ColumnIndex) > 1)
            {
                AbrirCamposPL();
                BotoesIniciarCadastroPL();

                TxtAnoPL.Text = DgvPL.Columns[DgvPL.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6);
                TxtValorPL.Text = DgvPL.Rows[DgvPL.CurrentRow.Index].Cells[DgvPL.CurrentCell.ColumnIndex].Value.ToString();
                CbxDetalhesPL.Text = DgvPL.Rows[DgvPL.CurrentRow.Index].Cells[1].Value.ToString();

                CbxDetalhesPL.Focus();
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Patrimônio Líquido da Tabela para ser Editado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnExcluirPC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvPC.CurrentCell.ColumnIndex) > 1)
            {
                if (MessageBox.Show("Deseja fazer a exclusão do valor da tabela que está selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(DgvPC.Rows[DgvPC.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(DgvPC.Columns[DgvPC.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6)));

                    if (balancoNegocio.Excluir(balanco.Codigo).ToString() == "0" && balanco.Codigo != 0)
                    {
                        MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridPc();
                        SomaValoresGridPc();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados valores para a exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Passivo Circulante da Tabela para ser Excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnExcluirAI_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvAI.CurrentCell.ColumnIndex) > 1)
            {
                if (MessageBox.Show("Deseja fazer a exclusão do valor da tabela que está selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(DgvAI.Rows[DgvAI.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(DgvAI.Columns[DgvAI.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6)));

                    if (balancoNegocio.Excluir(balanco.Codigo).ToString() == "0" && balanco.Codigo != 0)
                    {
                        MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridAi();
                        SomaValoresGridAi();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados valores para a exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Ativo Imobilizado da Tabela para ser Excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnExcluirPL_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvPL.CurrentCell.ColumnIndex) > 1)
            {
                if (MessageBox.Show("Deseja fazer a exclusão do valor da tabela que está selecionado?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Balanco balanco = new Balanco();
                    BalancoNegocio balancoNegocio = new BalancoNegocio();

                    balanco = balancoNegocio.SeExistir(Convert.ToInt32(DgvPL.Rows[DgvPL.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(DgvPL.Columns[DgvPL.CurrentCell.ColumnIndex].HeaderText.Remove(0, 6)));

                    if (balancoNegocio.Excluir(balanco.Codigo).ToString() == "0" && balanco.Codigo != 0)
                    {
                        MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaGridPl();
                        SomaValoresGridPl();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados valores para a exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o Valor de um Patrimônio Líquido da Tabela para ser Excluido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DgvPC_SelectionChanged(object sender, EventArgs e)
        {
            VerificarSelecionadoPC();
        }
        private void DgvAI_SelectionChanged(object sender, EventArgs e)
        {
            VerificarSelecionadoAI();
        }
        private void DgvPL_SelectionChanged(object sender, EventArgs e)
        {
            VerificarSelecionadoPL();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            FrmManual frmManual = new FrmManual();
            frmManual.ShowDialog();
        }

        private void BtnDesenvolvedor_Click(object sender, EventArgs e)
        {
            FrmDesenvolvedor frmDesenvolvedor = new FrmDesenvolvedor();
            frmDesenvolvedor.ShowDialog();
        }
    }
}

//if(DgvAC.CurrentCell.ColumnIndex)
//MessageBox.Show(DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[DgvAC.CurrentCell.ColumnIndex].Value.ToString());
//CbxDetalhesAC.Text = DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[1].Value.ToString();
//MessageBox.Show(DgvAC.CurrentCell.ColumnIndex.ToString());
//MessageBox.Show(DgvAC.Rows[DgvAC.CurrentRow.Index].Cells[DgvAC.CurrentCell.ColumnIndex].Value.ToString());
//TxtAnoAC.Text = 
