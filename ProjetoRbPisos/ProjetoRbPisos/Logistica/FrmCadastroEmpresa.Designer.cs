
namespace LogisticaEntregas
{
    partial class FrmCadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEmpresa));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnLimpar = new Retaguarda.iTalk.iTalk_Button_2();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPesquisar = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtEmpresa = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtConstrutora = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.RbConstrutora = new System.Windows.Forms.RadioButton();
            this.RbEmpresa = new System.Windows.Forms.RadioButton();
            this.BtnSelecionar = new Retaguarda.iTalk.iTalk_Button_2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvCadastroEmpresa = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 38);
            this.label2.TabIndex = 38;
            this.label2.Text = "Empresa / Fabrica:";
            // 
            // TxtCodigoId
            // 
            this.TxtCodigoId.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodigoId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtCodigoId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCodigoId.Location = new System.Drawing.Point(25, 11);
            this.TxtCodigoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodigoId.MaxLength = 32767;
            this.TxtCodigoId.Multiline = false;
            this.TxtCodigoId.Name = "TxtCodigoId";
            this.TxtCodigoId.ReadOnly = false;
            this.TxtCodigoId.Size = new System.Drawing.Size(53, 33);
            this.TxtCodigoId.TabIndex = 37;
            this.TxtCodigoId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCodigoId.UseSystemPasswordChar = false;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeletar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnDeletar.ForeColor = System.Drawing.Color.White;
            this.BtnDeletar.Image = global::Logistica.Properties.Resources.icons8_lixeira_cheia_80;
            this.BtnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeletar.Location = new System.Drawing.Point(705, 183);
            this.BtnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(103, 87);
            this.BtnDeletar.TabIndex = 36;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_96;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(520, 183);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(107, 87);
            this.BtnSalvar.TabIndex = 35;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_80;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLimpar.Location = new System.Drawing.Point(898, 183);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 87);
            this.BtnLimpar.TabIndex = 39;
            this.BtnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "Constr / Cliente:";
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.TxtPesquisar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPesquisar.Location = new System.Drawing.Point(25, 146);
            this.TxtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPesquisar.MaxLength = 32767;
            this.TxtPesquisar.Multiline = false;
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.ReadOnly = false;
            this.TxtPesquisar.Size = new System.Drawing.Size(279, 33);
            this.TxtPesquisar.TabIndex = 37;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPesquisar.UseSystemPasswordChar = false;
            this.TxtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            this.TxtPesquisar.Click += new System.EventHandler(this.TxtPesquisar_Click);
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.TxtEmpresa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtEmpresa.ForeColor = System.Drawing.Color.DimGray;
            this.TxtEmpresa.Location = new System.Drawing.Point(356, 17);
            this.TxtEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmpresa.MaxLength = 32767;
            this.TxtEmpresa.Multiline = false;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.ReadOnly = false;
            this.TxtEmpresa.Size = new System.Drawing.Size(618, 33);
            this.TxtEmpresa.TabIndex = 37;
            this.TxtEmpresa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmpresa.UseSystemPasswordChar = false;
            // 
            // TxtConstrutora
            // 
            this.TxtConstrutora.BackColor = System.Drawing.Color.Transparent;
            this.TxtConstrutora.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtConstrutora.ForeColor = System.Drawing.Color.DimGray;
            this.TxtConstrutora.Location = new System.Drawing.Point(245, 83);
            this.TxtConstrutora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtConstrutora.MaxLength = 32767;
            this.TxtConstrutora.Multiline = false;
            this.TxtConstrutora.Name = "TxtConstrutora";
            this.TxtConstrutora.ReadOnly = false;
            this.TxtConstrutora.Size = new System.Drawing.Size(618, 33);
            this.TxtConstrutora.TabIndex = 37;
            this.TxtConstrutora.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtConstrutora.UseSystemPasswordChar = false;
            // 
            // RbConstrutora
            // 
            this.RbConstrutora.AutoSize = true;
            this.RbConstrutora.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.RbConstrutora.ForeColor = System.Drawing.Color.White;
            this.RbConstrutora.Location = new System.Drawing.Point(25, 229);
            this.RbConstrutora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbConstrutora.Name = "RbConstrutora";
            this.RbConstrutora.Size = new System.Drawing.Size(250, 42);
            this.RbConstrutora.TabIndex = 40;
            this.RbConstrutora.TabStop = true;
            this.RbConstrutora.Text = "Constr / Cliente:";
            this.RbConstrutora.UseVisualStyleBackColor = true;
            // 
            // RbEmpresa
            // 
            this.RbEmpresa.AutoSize = true;
            this.RbEmpresa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.RbEmpresa.ForeColor = System.Drawing.Color.White;
            this.RbEmpresa.Location = new System.Drawing.Point(25, 183);
            this.RbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbEmpresa.Name = "RbEmpresa";
            this.RbEmpresa.Size = new System.Drawing.Size(270, 42);
            this.RbEmpresa.TabIndex = 41;
            this.RbEmpresa.TabStop = true;
            this.RbEmpresa.Text = "Empresa / Fabrica";
            this.RbEmpresa.UseVisualStyleBackColor = true;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelecionar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnSelecionar.ForeColor = System.Drawing.Color.White;
            this.BtnSelecionar.Image = global::Logistica.Properties.Resources.icons8_mão_para_a_direita_96;
            this.BtnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSelecionar.Location = new System.Drawing.Point(342, 183);
            this.BtnSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(103, 87);
            this.BtnSelecionar.TabIndex = 39;
            this.BtnSelecionar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvCadastroEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 319);
            this.panel1.TabIndex = 42;
            // 
            // DgvCadastroEmpresa
            // 
            this.DgvCadastroEmpresa.AllowUserToAddRows = false;
            this.DgvCadastroEmpresa.AllowUserToDeleteRows = false;
            this.DgvCadastroEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.DgvCadastroEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCadastroEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCadastroEmpresa.Location = new System.Drawing.Point(0, 0);
            this.DgvCadastroEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvCadastroEmpresa.Name = "DgvCadastroEmpresa";
            this.DgvCadastroEmpresa.ReadOnly = true;
            this.DgvCadastroEmpresa.RowHeadersWidth = 51;
            this.DgvCadastroEmpresa.RowTemplate.Height = 29;
            this.DgvCadastroEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCadastroEmpresa.Size = new System.Drawing.Size(1342, 319);
            this.DgvCadastroEmpresa.TabIndex = 0;
            this.DgvCadastroEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroEmpresa_CellDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(1126, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // FrmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RbEmpresa);
            this.Controls.Add(this.RbConstrutora);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConstrutora);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.TxtCodigoId);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Empresas, Fabrica, Clientes, Arqt";
            this.Load += new System.EventHandler(this.FrmCadastroEmpresa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCadastroEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtCodigoId;
        private Retaguarda.iTalk.iTalk_Button_2 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_2 BtnSalvar;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLimpar;
        private System.Windows.Forms.Label label1;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtPesquisar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtEmpresa;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtConstrutora;
        private System.Windows.Forms.RadioButton RbConstrutora;
        private System.Windows.Forms.RadioButton RbEmpresa;
        private Retaguarda.iTalk.iTalk_Button_2 BtnSelecionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvCadastroEmpresa;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}