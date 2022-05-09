using System;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmImpressao : Form
    {
   //     public FrmImpressao(DateTime Dataentrega, string Proposta, string Cliente, string Obra, ReportDataSource rs, string NotaFiscal, string Comentario)
      //  {
      //      InitializeComponent();
            //try
            //{
            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.ReportEmbeddedResource = "RBCOMERCIO.ImpressaoProposta.rdlc";
            //    Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[6];
            //    p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Proposta", Proposta);
            //    p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Cliente", Cliente);
            //    p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Obra", Obra);
            //    p[3] = new Microsoft.Reporting.WinForms.ReportParameter("NotaFiscal", NotaFiscal);
            //    p[4] = new Microsoft.Reporting.WinForms.ReportParameter("Comentario", Comentario);
            //    p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Dataentrega", Dataentrega.ToString());

            //    reportViewer1.LocalReport.SetParameters(p);
            //    reportViewer1.LocalReport.DataSources.Add(rs);
            //    reportViewer1.LocalReport.Refresh();
            //    reportViewer1.RefreshReport();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro: " + ex.Message);
            //}
     //   }


        private void FrmImpressao_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }
    }
}
