
using DALLogistica.Entities;
using DALLogistica.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProposta = new DLproposta().Listar();
                CarregarPrincipal();
                var listaramostra = new DLamostracliente().Listar();
                CarregarAmostra();
                var listarferramenta = new DLFerramentas().Listar();
                CarregarFerramenta();              
                var listarmontagem = new DLmontagem().Listar();
                CarregarMontagem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
        private void CarregarFerramenta(bool isPesquisa = false)
        {
            try
            {
                var listarFerramentas = new DLFerramentas().Listarferramenta();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked)
                        listarFerramentas = listarFerramentas.Where(p => p.funcionario.ToLower().Contains(pesquisa)).ToList();
                }
                DgvFerramentas.DataSource = listarFerramentas;
                MontarFerramentas(DgvFerramentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarFerramentas(DataGridView dgvFerramentas)
        {
            DgvFerramentas.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvFerramentas);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "funcionario", "retirada", "devolucao", "material", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "FUNCIONARIO", "RETIRADA", "DEVOLUÇÃO", "MATERIAL", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 10, 50, }, DgvFerramentas.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarMontagem(bool isPesquisa = false)
        {
            try
            {
                var listarMontagem = new DLmontagem().ListarMontagem();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked) ;
                    //listarMontagem = listarMontagem.Where(p => p..ToLower().Contains(pesquisa)).ToList();
                }
                DgvMontagem.DataSource = listarMontagem;
                MontarMontagem(DgvMontagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarMontagem(DataGridView dgvMontagem)
        {
            DgvMontagem.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvMontagem);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "montagemid", "montador", "dataenvio", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Id", "Montador", "Data do Envio", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 5, 25, 15, 54, }, DgvMontagem.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarAmostra(bool isPesquisa = false)
        {
            try
            {
                var listarAmostra = new DLamostracliente().ListarAmostraclienteStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = TxtPesquisar.Text.ToLower();
                    if (RbCliente.Checked);
                     listarAmostra = listarAmostra.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    if (RbEndereco.Checked);
                    listarAmostra = listarAmostra.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                }
                DgvAmostra.DataSource = listarAmostra;
                MontarAmostras(DgvAmostra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarAmostras(DataGridView dgvAmostra)
        {
            DgvAmostra.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvAmostra);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "amostraid", "construtora", "dataentrega", "obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Id", "Cliente / Arqt", "Data da Entrega", "Endereço", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 5, 25, 15, 54, }, DgvAmostra.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarPrincipal(bool isPesquisa = false)
        {
            try
            {
                var listaPropostaStatus = new DLproposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    if (RbFinalizado.Checked)//==
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Finalizado")).ToList();
                    else if (RbPendente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Pendente")).ToList();
                    else if (RbImediato.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Imediato")).ToList();
                    else if (RbCancelado.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Cancelado")).ToList();

                    var pesquisa = TxtPesquisar.Text.ToLower();

                    if (RbFabrica.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.fabrica.ToLower().Contains(pesquisa)).ToList();
                    else if (RbMaterial.Checked)
                    {
                        listaPropostaStatus = new DLproposta().ListarPropostaStatus(pesquisa);
                    }
                    else if (RbEng.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.engresp.ToLower().Contains(pesquisa)).ToList();
                    else if (RbPedidoRb.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdrb.ToLower().Contains(pesquisa)).ToList();
                    else if (RbPedidoVenda.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdvenda.ToLower().Contains(pesquisa)).ToList();
                    else if (RbProposta.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.propostaa.ToLower().Contains(pesquisa)).ToList();
                    else if (RbCliente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (RbEndereco.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (RbComentario.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.comentario.ToLower().Contains(pesquisa)).ToList();
                    else if (RbNf.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.notafiscal.ToLower().Contains(pesquisa)).ToList();
                }
                DgvPrincipal.DataSource = listaPropostaStatus;
                MontarProposta(DgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarProposta(DataGridView dgvPrincipal)
        {
            DgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(DgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "dataprevista", "fabrica", "engresp", "pdrb", "pdvenda", "propostaa", "construtora", "obra", "notafiscal", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "DATA PREVISTA", "FABRICA", "RESP.", "PD RB", "PD VENDA", "PROPOSTA", "CLIENTE", "OBRA", "NF", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 9, 9, 10, 8, 8, 8, 12, 29, 7, }, DgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void BtnProposta_Click(object sender, EventArgs e)
        {
            FrmPropostas proposta = new FrmPropostas();
            proposta.ShowDialog();
            CarregarPrincipal();
        }
        private void BtnAmostra_Click(object sender, EventArgs e)
        {
            FrmAmostraCliente amostra = new FrmAmostraCliente();
            amostra.ShowDialog();
            CarregarAmostra();
        }
        private void BtnMontagem_Click(object sender, EventArgs e)
        {
            FrmMontagemAmostras montagem = new FrmMontagemAmostras();
            montagem.ShowDialog();
            CarregarMontagem();

        }
        private void BtnFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas ferramenta = new FrmFerramentas();
            ferramenta.ShowDialog();
            CarregarFerramenta();
        }
        private void BtnMaterial_Click(object sender, EventArgs e)
        {
            FrmMaterial material = new FrmMaterial();
            material.ShowDialog();
        }
        private void BtnNotaFiscal_Click(object sender, EventArgs e)
        {
            FrmNotaFical notafiscal = new FrmNotaFical();
            notafiscal.ShowDialog();
        }
        private void BtnArt_Click(object sender, EventArgs e)
        {
            FrmArt art = new FrmArt();
            art.ShowDialog();
        }
        private void BtnLimparPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoLimpeza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void BtnPesquisarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoPesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void ReducaoCodigoPesquisar()
        {
            CarregarAmostra(true);
            MontarAmostras(DgvAmostra);
            CarregarFerramenta(true);
            MontarFerramentas(DgvFerramentas);
            CarregarMontagem(true);
            MontarMontagem(DgvMontagem);
            CarregarPrincipal(true);
            MontarProposta(DgvPrincipal);
        }
        private void BtnLimparFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoLimpeza();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void ReducaoCodigoLimpeza()
        {
            try
            {
                TxtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
                RbFabrica.Checked = false;
                RbEng.Checked = false;
                RbPedidoRb.Checked = false;
                RbEndereco.Checked = false;
                RbPedidoVenda.Checked = false;
                RbNf.Checked = false;
                RbMaterial.Checked = false;
                RbProposta.Checked = false;
                RbComentario.Checked = false;
                RbCancelado.Checked = false;
                RbCliente.Checked = false;
                RbPendente.Checked = false;
                RbFinalizado.Checked = false;
                RbImediato.Checked = false;
                CarregarAmostra();
                CarregarFerramenta();
                CarregarMontagem();
                CarregarPrincipal();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
           
        }
        private void TxtPesquisar_Click(object sender, EventArgs e)
        {
            TxtPesquisar.Text = Convert.ToString(null);
        }
        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReducaoCodigoPesquisar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new proposta();
                prop.propostaid = Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
                FrmPropostas frmproposta = new FrmPropostas();
                frmproposta._proposta = prop;
                frmproposta.ShowDialog();
                CarregarPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvPrincipal.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvPrincipal.Rows[i].Cells[23].Value);
                switch (valor)
                {
                    case "Imediato": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Pendente": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case "Finalizado": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new amostracliente();
                prop.amostraid = Convert.ToInt32(DgvAmostra.Rows[e.RowIndex].Cells[0].Value);
                FrmAmostraCliente frmAmostraCliente = new FrmAmostraCliente();
                frmAmostraCliente._amostracliente = prop;
                frmAmostraCliente.ShowDialog();
                CarregarAmostra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvAmostra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvAmostra.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvAmostra.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvAmostra.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvProducao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new montagem();
                prop.montagemid = Convert.ToInt32(DgvAmostra.Rows[e.RowIndex].Cells[0].Value);
                FrmMontagemAmostras montagem = new FrmMontagemAmostras();
                montagem._montagem = prop;
                montagem.ShowDialog();
                CarregarMontagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvProducao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvMontagem.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvMontagem.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case "Cancelado": DgvMontagem.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }
        private void DgvFerramentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ferra = new Ferramentas();
                ferra.ferramentaid = Convert.ToInt32(DgvFerramentas.Rows[e.RowIndex].Cells[0].Value);
                FrmFerramentas frmFerramentas = new FrmFerramentas();
                frmFerramentas._ferramentas = ferra;
                frmFerramentas.ShowDialog();
                CarregarFerramenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void DgvFerramentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < DgvFerramentas.Rows.Count; i++)
            {
                var valor = Convert.ToString(DgvFerramentas.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "Pendente": DgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "Finalizado": DgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen; break;
                }
            }
        }

        private void BtnDeletarRodape_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletarm2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletarM3_Click(object sender, EventArgs e)
        {

        }
    }
}
