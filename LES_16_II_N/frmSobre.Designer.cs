namespace LES_16_II_N
{
    partial class frmsobre
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
            this.lbnome = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbcidadeuf = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.txtfinalidade = new System.Windows.Forms.TextBox();
            this.pctautor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctautor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 13);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(164, 13);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome: Thiago Scalone de Sousa";
            this.lbnome.Click += new System.EventHandler(this.lbnome_Click);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(12, 61);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(153, 13);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "E-mail: thiago@scalone.com.br";
            // 
            // lbcelular
            // 
            this.lbcelular.AutoSize = true;
            this.lbcelular.Location = new System.Drawing.Point(12, 110);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(126, 13);
            this.lbcelular.TabIndex = 2;
            this.lbcelular.Text = "Celular: (16) 992 410 585";
            // 
            // lbcidadeuf
            // 
            this.lbcidadeuf.AutoSize = true;
            this.lbcidadeuf.Location = new System.Drawing.Point(12, 159);
            this.lbcidadeuf.Name = "lbcidadeuf";
            this.lbcidadeuf.Size = new System.Drawing.Size(125, 13);
            this.lbcidadeuf.TabIndex = 3;
            this.lbcidadeuf.Text = "Cidade - UF: Franca - SP";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 4;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // txtfinalidade
            // 
            this.txtfinalidade.Enabled = false;
            this.txtfinalidade.Location = new System.Drawing.Point(15, 193);
            this.txtfinalidade.Multiline = true;
            this.txtfinalidade.Name = "txtfinalidade";
            this.txtfinalidade.Size = new System.Drawing.Size(365, 125);
            this.txtfinalidade.TabIndex = 6;
            this.txtfinalidade.Text = "Esse sistema controla Login, Funcionários, Produtos, Pedidos e as Vendas de uma e" +
    "mpresa.";
            // 
            // pctautor
            // 
            this.pctautor.Image = global::LES_16_II_N.Properties.Resources.IMG_0452;
            this.pctautor.Location = new System.Drawing.Point(196, 13);
            this.pctautor.Name = "pctautor";
            this.pctautor.Size = new System.Drawing.Size(184, 159);
            this.pctautor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctautor.TabIndex = 5;
            this.pctautor.TabStop = false;
            // 
            // frmsobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.txtfinalidade);
            this.Controls.Add(this.pctautor);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.lbcidadeuf);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Autor";
            ((System.ComponentModel.ISupportInitialize)(this.pctautor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbcidadeuf;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.PictureBox pctautor;
        private System.Windows.Forms.TextBox txtfinalidade;
    }
}