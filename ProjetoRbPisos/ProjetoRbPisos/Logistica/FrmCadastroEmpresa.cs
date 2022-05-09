using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmCadastroEmpresa : Form
    {
        public int empresaid;
        public string empresa;
        public string construtora;
        public FrmCadastroEmpresa()
        {
            InitializeComponent();
        }
        private void FrmCadastroEmpresa_Load(object sender, EventArgs e)
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
                var listarEmpresa = new DLcadastrarempresa().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbEmpresa.Checked)
                        listarEmpresa = listarEmpresa.Where(p => p.empresa.ToLower().Contains(pesquisa)).ToList();
                    else if (RbConstrutora.Checked)
                        listarEmpresa = listarEmpresa.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                }
                DgvCadastroEmpresa.DataSource = listarEmpresa;
                MontarGrid(DgvCadastroEmpresa);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastroEmpresa)
        {
            try
            {
                DgvCadastroEmpresa.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(DgvCadastroEmpresa);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "empresaid", "empresa", "construtora", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "id", "EMPRESA", "CONSTRUTORA / ARTQ", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 45, 45 }, DgvCadastroEmpresa.Width - 15); //O total tem que ficar em 100% 
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
            empresaid = Convert.ToInt32(TxtCodigoId.Text);
            empresa = TxtEmpresa.Text;
            construtora = TxtConstrutora.Text;
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
                        var cadastraratualizar = new DLcadastrarempresa().ConsultarPorId(id);
                        cadastraratualizar.empresaid = Convert.ToInt32(TxtCodigoId.Text);
                        cadastraratualizar.empresa = TxtEmpresa.Text;
                        cadastraratualizar.construtora = TxtConstrutora.Text;
                        new DLcadastrarempresa().Atualizar(cadastraratualizar);
                        MessageBox.Show("Empresa/Cliente atualizado com Sucesso ");
                        LimparCampos();                        
                        Carregargrid();
                    }
                    else
                    {
                        var cadastrobranco = new cadastrarempresa();
                        cadastrobranco.empresa = TxtEmpresa.Text;
                        cadastrobranco.construtora = TxtConstrutora.Text;
                        var idcarreto = new DLcadastrarempresa().Inserir(cadastrobranco);
                        MessageBox.Show(" Empresa/Cliente " + idcarreto + "Criado com Sucesso");
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
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            TxtCodigoId.Text = Convert.ToString(null);
            TxtEmpresa.Text = Convert.ToString(null);
            TxtConstrutora.Text = Convert.ToString(null);
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(TxtCodigoId.Text, out id);
            if (id > 0)
            {
                new DLcadastrarempresa().Excluir(new cadastrarempresa { empresaid = id });
                MessageBox.Show("Empresa/Cliente excluída com sucesso!");
                Carregargrid();
                TxtCodigoId.Text = Convert.ToString(null);
            }
            else
            {
                MessageBox.Show("id Invalido");
            }
        }
        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            RbConstrutora.Checked = false;
            RbEmpresa.Checked = false;
            LimparCampos();
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString(null);
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Carregargrid(true);
                MontarGrid(DgvCadastroEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvCadastroEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigoId.Text = Convert.ToString(DgvCadastroEmpresa.Rows[e.RowIndex].Cells[0].Value);
                TxtEmpresa.Text = Convert.ToString(DgvCadastroEmpresa.Rows[e.RowIndex].Cells[1].Value);
                TxtConstrutora.Text = Convert.ToString(DgvCadastroEmpresa.Rows[e.RowIndex].Cells[2].Value);
                hablitarbotao(true);
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void hablitarbotao(bool habilitar)
        {
            BtnSelecionar.Enabled = habilitar;
        }
    }
}
