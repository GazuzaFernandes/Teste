
namespace LogisticaEntregas
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSenha = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtLogin = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.BtnRestauracao = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnEntrar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
            this.TxtFabrica = new Retaguarda.iTalk.iTalk_TextBox_Small();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Logistica.Properties.Resources.RB;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TxtSenha, "TxtSenha");
            this.TxtSenha.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSenha.MaxLength = 32767;
            this.TxtSenha.Multiline = false;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.ReadOnly = false;
            this.TxtSenha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSenha.UseSystemPasswordChar = true;
            
            this.TxtSenha.Click += new System.EventHandler(this.TxtSenha_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TxtLogin, "TxtLogin");
            this.TxtLogin.ForeColor = System.Drawing.Color.DimGray;
            this.TxtLogin.MaxLength = 32767;
            this.TxtLogin.Multiline = false;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.ReadOnly = false;
            this.TxtLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLogin.UseSystemPasswordChar = false;
          
            this.TxtLogin.Click += new System.EventHandler(this.TxtLogin_Click);
            // 
            // BtnRestauracao
            // 
            this.BtnRestauracao.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnRestauracao, "BtnRestauracao");
            this.BtnRestauracao.ForeColor = System.Drawing.Color.White;
            this.BtnRestauracao.Image = global::Logistica.Properties.Resources.icons8_armazenamento_na_núvem_30;
            this.BtnRestauracao.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRestauracao.Name = "BtnRestauracao";
            this.BtnRestauracao.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnRestauracao.Click += new System.EventHandler(this.BtnRestauracao_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnEntrar, "BtnEntrar");
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Image = null;
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnDeletar, "BtnDeletar");
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = null;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // TxtFabrica
            // 
            this.TxtFabrica.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TxtFabrica, "TxtFabrica");
            this.TxtFabrica.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFabrica.MaxLength = 32767;
            this.TxtFabrica.Multiline = false;
            this.TxtFabrica.Name = "TxtFabrica";
            this.TxtFabrica.ReadOnly = false;
            this.TxtFabrica.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFabrica.UseSystemPasswordChar = false;
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnRestauracao);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.TxtFabrica);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Retaguarda.iTalk.iTalk_Button_2 BtnDeletar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtFabrica;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtLogin;
        private Retaguarda.iTalk.iTalk_Button_2 BtnRestauracao;
        private Retaguarda.iTalk.iTalk_Button_2 BtnEntrar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtSenha;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}