using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmCadastroItens : Form
    {
        public int madeiraid;
        public string material;
        public string comprimento;
        public string qtdcaixa;
        public FrmCadastroItens()
        {
            InitializeComponent();
        }
        private void FrmCadastroItens_Load(object sender, EventArgs e)
        {
            try
            {
                bloquearbotao(false);
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarmadeira = new DLcadastrarmadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbMaterial.Checked)
                        listarmadeira = listarmadeira.Where(p => p.pisomadeira.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCadastroMadeira.DataSource = listarmadeira;
                MontarGrid(DgvCadastroMadeira);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastroMadeira)
        {
            try
            {
                DgvCadastroMadeira.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCadastroMadeira);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "madeiraid", "pisomadeira", "comprimentos", "m2caixa" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "id", "PISO", "COMPRIMENTOS", "UND. MEDIDA" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 50, 30, 8, }, DgvCadastroMadeira.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void bloquearbotao(bool desabilitar)
        {
            BtnSelecionar.Enabled = desabilitar;
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            madeiraid = Convert.ToInt32(TxtCodigoId.Text);
            material = TxtMaterial.Text;
            comprimento = TxtObs.Text;
            qtdcaixa = TxtQtd.Text;
            Hide();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(TxtCodigoId.Text, out id);
                    if (id > 0)
                    {
                        var cadastraratualizar = new DLcadastrarmadeira().ConsultarPorId(id);
                        cadastraratualizar.madeiraid = Convert.ToInt32(TxtCodigoId.Text);
                        cadastraratualizar.pisomadeira = TxtMaterial.Text;
                        cadastraratualizar.comprimentos = TxtObs.Text;
                        cadastraratualizar.m2caixa = Convert.ToDecimal(TxtQtd.Text);
                        new DLcadastrarmadeira().Atualizar(cadastraratualizar);
                        MessageBox.Show("Piso atualizado com Sucesso ");
                        LimparCampos();                        
                        Carregargrid();
                    }
                    else
                    {
                        var cadastrobranco = new cadastrarmadeira();
                        cadastrobranco.pisomadeira = TxtCodigoId.Text;
                        cadastrobranco.comprimentos = TxtMaterial.Text;
                        cadastrobranco.m2caixa = Convert.ToDecimal(TxtObs.Text);
                        var idcarreto = new DLcadastrarmadeira().Inserir(cadastrobranco);
                        MessageBox.Show(" Piso " + idcarreto + "Criado com Sucesso");
                        LimparCampos();
                        Carregargrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            TxtMaterial.Text = Convert.ToString(null);
            TxtObs.Text = Convert.ToString(null);
            TxtQtd.Text = Convert.ToString(1);
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(TxtCodigoId.Text, out id);
            if (id > 0)
            {
                new DLcadastrarmadeira().Excluir(new cadastrarmadeira { madeiraid = id });
                MessageBox.Show("Item excluído com sucesso!");
                Carregargrid();
                TxtCodigoId.Text = Convert.ToString(null);
            }
            else
            {
                MessageBox.Show("id Invalido");
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            RbMaterial.Checked = false;
            LimparCampos();
            TxtPesquisar.Text = Convert.ToString("Digite para PEsquisar:");
            Carregargrid(true);
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Carregargrid(true);
                MontarGrid(DgvCadastroMadeira);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvCadastroMadeira_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigoId.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[0].Value);
                TxtMaterial.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[1].Value);
                TxtObs.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[2].Value);
                TxtQtd.Text = Convert.ToString(DgvCadastroMadeira.Rows[e.RowIndex].Cells[3].Value);
                habilitarbotao(true);
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void habilitarbotao(bool habilitar)
        {
            BtnSelecionar.Enabled = habilitar;
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString(null);
        }
    }
}
