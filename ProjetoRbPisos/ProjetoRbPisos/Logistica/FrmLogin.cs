using DALLogistica.Repository;
using System;

using System.Windows.Forms;

namespace LogisticaEntregas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void BtnRestauracao_Click(object sender, EventArgs e)
        {

        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean temUsuario = false;
                var listaUsuarios = new DLusuario().Listar();

                //var usuario = listaUsuarios.Where(u => u.Login == TxtLogin.Text && u.Senha == TxtSenha.Text).FirstOrDefault();
                //if(usuario != null) - é a mesma coisa que foi feita em baixo mas simplificado
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].Login == TxtLogin.Text && listaUsuarios[i].Senha == TxtSenha.Text)
                    {
                        temUsuario = true;
                    }
                }
                if (temUsuario == true)
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario inválido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtLogin_Click(object sender, EventArgs e)
        {
            TxtLogin.Text = Convert.ToString(null);
        }

        private void TxtSenha_Click(object sender, EventArgs e)
        {
            TxtSenha.Text = Convert.ToString(null);
        }
    }
}
