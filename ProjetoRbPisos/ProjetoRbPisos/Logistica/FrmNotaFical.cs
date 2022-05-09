using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmNotaFical : Form
    {
        public FrmNotaFical()
        {
            InitializeComponent();
        }

        private void FrmNotaFical_Load(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.FromArgb(0, 64, 0);
            tabPage2.BackColor = Color.FromArgb(0, 64, 0);
            TabCarta.BackColor = Color.FromArgb(0, 64, 0);
            TabCance.BackColor = Color.FromArgb(0, 64, 0);
            TabCodigo.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimparCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
