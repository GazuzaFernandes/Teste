
namespace LogisticaEntregas
{
    partial class FrmMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RbEmpresa = new System.Windows.Forms.RadioButton();
            this.BtnLimpar = new Retaguarda.iTalk.iTalk_Button_2();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaterial = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtPesquisar = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.TxtCodigoId = new Retaguarda.iTalk.iTalk_TextBox_Small();
            this.BtnDeletar = new Retaguarda.iTalk.iTalk_Button_2();
            this.BtnSalvar = new Retaguarda.iTalk.iTalk_Button_2();
            this.RtbComentario = new Retaguarda.iTalk.iTalk_RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 282);
            this.panel1.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // RbEmpresa
            // 
            this.RbEmpresa.AutoSize = true;
            this.RbEmpresa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.RbEmpresa.ForeColor = System.Drawing.Color.White;
            this.RbEmpresa.Location = new System.Drawing.Point(266, 22);
            this.RbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbEmpresa.Name = "RbEmpresa";
            this.RbEmpresa.Size = new System.Drawing.Size(106, 29);
            this.RbEmpresa.TabIndex = 70;
            this.RbEmpresa.Text = "Material";
            this.RbEmpresa.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Image = global::Logistica.Properties.Resources.icons8_apagar_80;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(994, 120);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 73);
            this.BtnLimpar.TabIndex = 69;
            this.BtnLimpar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 38);
            this.label2.TabIndex = 67;
            this.label2.Text = "Material:";
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.BackColor = System.Drawing.Color.Transparent;
            this.TxtMaterial.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMaterial.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMaterial.Location = new System.Drawing.Point(329, 72);
            this.TxtMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMaterial.MaxLength = 32767;
            this.TxtMaterial.Multiline = false;
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.ReadOnly = false;
            this.TxtMaterial.Size = new System.Drawing.Size(777, 33);
            this.TxtMaterial.TabIndex = 62;
            this.TxtMaterial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMaterial.UseSystemPasswordChar = false;
            // 
            // TxtPesquisar
            // 
            this.TxtPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.TxtPesquisar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPesquisar.Location = new System.Drawing.Point(504, 22);
            this.TxtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPesquisar.MaxLength = 32767;
            this.TxtPesquisar.Multiline = false;
            this.TxtPesquisar.Name = "TxtPesquisar";
            this.TxtPesquisar.ReadOnly = false;
            this.TxtPesquisar.Size = new System.Drawing.Size(319, 33);
            this.TxtPesquisar.TabIndex = 63;
            this.TxtPesquisar.Text = "Digite para Pesquisar:";
            this.TxtPesquisar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPesquisar.UseSystemPasswordChar = false;
            // 
            // TxtCodigoId
            // 
            this.TxtCodigoId.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodigoId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtCodigoId.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCodigoId.Location = new System.Drawing.Point(24, 18);
            this.TxtCodigoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodigoId.MaxLength = 32767;
            this.TxtCodigoId.Multiline = false;
            this.TxtCodigoId.Name = "TxtCodigoId";
            this.TxtCodigoId.ReadOnly = false;
            this.TxtCodigoId.Size = new System.Drawing.Size(53, 33);
            this.TxtCodigoId.TabIndex = 64;
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
            this.BtnDeletar.Location = new System.Drawing.Point(846, 120);
            this.BtnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(103, 73);
            this.BtnDeletar.TabIndex = 59;
            this.BtnDeletar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Image = global::Logistica.Properties.Resources.icons8_salvar_96;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalvar.Location = new System.Drawing.Point(692, 120);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 73);
            this.BtnSalvar.TabIndex = 58;
            this.BtnSalvar.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // RtbComentario
            // 
            this.RtbComentario.AutoWordSelection = false;
            this.RtbComentario.BackColor = System.Drawing.Color.Transparent;
            this.RtbComentario.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.RtbComentario.ForeColor = System.Drawing.Color.DimGray;
            this.RtbComentario.Location = new System.Drawing.Point(12, 120);
            this.RtbComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RtbComentario.Name = "RtbComentario";
            this.RtbComentario.ReadOnly = false;
            this.RtbComentario.Size = new System.Drawing.Size(659, 118);
            this.RtbComentario.TabIndex = 72;
            this.RtbComentario.Text = "Para que é usado: ";
            this.RtbComentario.WordWrap = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(376, 22);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 29);
            this.radioButton1.TabIndex = 70;
            this.radioButton1.Text = "Utilização:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Logistica.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(1143, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1304, 590);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RtbComentario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RbEmpresa);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.TxtPesquisar);
            this.Controls.Add(this.TxtCodigoId);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações de Materiais";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RbEmpresa;
        private Retaguarda.iTalk.iTalk_Button_2 BtnLimpar;
        private System.Windows.Forms.Label label2;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtMaterial;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtPesquisar;
        private Retaguarda.iTalk.iTalk_TextBox_Small TxtCodigoId;
        private Retaguarda.iTalk.iTalk_Button_2 BtnDeletar;
        private Retaguarda.iTalk.iTalk_Button_2 BtnSalvar;
        private Retaguarda.iTalk.iTalk_RichTextBox RtbComentario;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}