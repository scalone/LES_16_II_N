namespace LES_16_II_N
{
    partial class frmUsuario
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
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.txtusonome = new System.Windows.Forms.TextBox();
            this.txtusocodi = new System.Windows.Forms.TextBox();
            this.lbuninome = new System.Windows.Forms.Label();
            this.lbunicodi = new System.Windows.Forms.Label();
            this.txtusosenha = new System.Windows.Forms.TextBox();
            this.lbusosenha = new System.Windows.Forms.Label();
            this.txtusonivel = new System.Windows.Forms.TextBox();
            this.lbusonivel = new System.Windows.Forms.Label();
            this.txtusodata = new System.Windows.Forms.TextBox();
            this.lbusodata = new System.Windows.Forms.Label();
            this.txtusoqtde = new System.Windows.Forms.TextBox();
            this.lbusoqtd = new System.Windows.Forms.Label();
            this.txtusobloq = new System.Windows.Forms.TextBox();
            this.lbusobloq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(258, 225);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 15;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(176, 225);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 14;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(94, 225);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 13;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btincluir
            // 
            this.btincluir.Location = new System.Drawing.Point(12, 225);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 12;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtusonome
            // 
            this.txtusonome.Location = new System.Drawing.Point(63, 38);
            this.txtusonome.Name = "txtusonome";
            this.txtusonome.Size = new System.Drawing.Size(270, 20);
            this.txtusonome.TabIndex = 11;
            // 
            // txtusocodi
            // 
            this.txtusocodi.Location = new System.Drawing.Point(63, 12);
            this.txtusocodi.Name = "txtusocodi";
            this.txtusocodi.Size = new System.Drawing.Size(100, 20);
            this.txtusocodi.TabIndex = 10;
            this.txtusocodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusocodi_KeyPress);
            this.txtusocodi.Leave += new System.EventHandler(this.txtusocodi_Leave);
            // 
            // lbuninome
            // 
            this.lbuninome.AutoSize = true;
            this.lbuninome.Location = new System.Drawing.Point(8, 43);
            this.lbuninome.Name = "lbuninome";
            this.lbuninome.Size = new System.Drawing.Size(39, 13);
            this.lbuninome.TabIndex = 9;
            this.lbuninome.Text = "NOME";
            // 
            // lbunicodi
            // 
            this.lbunicodi.AutoSize = true;
            this.lbunicodi.Location = new System.Drawing.Point(8, 16);
            this.lbunicodi.Name = "lbunicodi";
            this.lbunicodi.Size = new System.Drawing.Size(49, 13);
            this.lbunicodi.TabIndex = 8;
            this.lbunicodi.Text = "CODIGO";
            // 
            // txtusosenha
            // 
            this.txtusosenha.Location = new System.Drawing.Point(63, 64);
            this.txtusosenha.Name = "txtusosenha";
            this.txtusosenha.Size = new System.Drawing.Size(270, 20);
            this.txtusosenha.TabIndex = 17;
            this.txtusosenha.UseSystemPasswordChar = true;
            this.txtusosenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbusosenha
            // 
            this.lbusosenha.AutoSize = true;
            this.lbusosenha.Location = new System.Drawing.Point(8, 69);
            this.lbusosenha.Name = "lbusosenha";
            this.lbusosenha.Size = new System.Drawing.Size(44, 13);
            this.lbusosenha.TabIndex = 16;
            this.lbusosenha.Text = "SENHA";
            this.lbusosenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusonivel
            // 
            this.txtusonivel.Location = new System.Drawing.Point(63, 90);
            this.txtusonivel.Name = "txtusonivel";
            this.txtusonivel.Size = new System.Drawing.Size(100, 20);
            this.txtusonivel.TabIndex = 19;
            // 
            // lbusonivel
            // 
            this.lbusonivel.AutoSize = true;
            this.lbusonivel.Location = new System.Drawing.Point(8, 95);
            this.lbusonivel.Name = "lbusonivel";
            this.lbusonivel.Size = new System.Drawing.Size(38, 13);
            this.lbusonivel.TabIndex = 18;
            this.lbusonivel.Text = "NIVEL";
            // 
            // txtusodata
            // 
            this.txtusodata.Location = new System.Drawing.Point(63, 116);
            this.txtusodata.Name = "txtusodata";
            this.txtusodata.Size = new System.Drawing.Size(100, 20);
            this.txtusodata.TabIndex = 21;
            // 
            // lbusodata
            // 
            this.lbusodata.AutoSize = true;
            this.lbusodata.Location = new System.Drawing.Point(8, 121);
            this.lbusodata.Name = "lbusodata";
            this.lbusodata.Size = new System.Drawing.Size(36, 13);
            this.lbusodata.TabIndex = 20;
            this.lbusodata.Text = "DATA";
            // 
            // txtusoqtde
            // 
            this.txtusoqtde.Location = new System.Drawing.Point(63, 142);
            this.txtusoqtde.Name = "txtusoqtde";
            this.txtusoqtde.Size = new System.Drawing.Size(100, 20);
            this.txtusoqtde.TabIndex = 23;
            // 
            // lbusoqtd
            // 
            this.lbusoqtd.AutoSize = true;
            this.lbusoqtd.Location = new System.Drawing.Point(8, 147);
            this.lbusoqtd.Name = "lbusoqtd";
            this.lbusoqtd.Size = new System.Drawing.Size(30, 13);
            this.lbusoqtd.TabIndex = 22;
            this.lbusoqtd.Text = "QTD";
            // 
            // txtusobloq
            // 
            this.txtusobloq.Location = new System.Drawing.Point(63, 168);
            this.txtusobloq.Name = "txtusobloq";
            this.txtusobloq.Size = new System.Drawing.Size(100, 20);
            this.txtusobloq.TabIndex = 25;
            // 
            // lbusobloq
            // 
            this.lbusobloq.AutoSize = true;
            this.lbusobloq.Location = new System.Drawing.Point(8, 173);
            this.lbusobloq.Name = "lbusobloq";
            this.lbusobloq.Size = new System.Drawing.Size(36, 13);
            this.lbusobloq.TabIndex = 24;
            this.lbusobloq.Text = "BLOQ";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.txtusobloq);
            this.Controls.Add(this.lbusobloq);
            this.Controls.Add(this.txtusoqtde);
            this.Controls.Add(this.lbusoqtd);
            this.Controls.Add(this.txtusodata);
            this.Controls.Add(this.lbusodata);
            this.Controls.Add(this.txtusonivel);
            this.Controls.Add(this.lbusonivel);
            this.Controls.Add(this.txtusosenha);
            this.Controls.Add(this.lbusosenha);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtusonome);
            this.Controls.Add(this.txtusocodi);
            this.Controls.Add(this.lbuninome);
            this.Controls.Add(this.lbunicodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtusonome;
        private System.Windows.Forms.TextBox txtusocodi;
        private System.Windows.Forms.Label lbuninome;
        private System.Windows.Forms.Label lbunicodi;
        private System.Windows.Forms.TextBox txtusosenha;
        private System.Windows.Forms.Label lbusosenha;
        private System.Windows.Forms.TextBox txtusonivel;
        private System.Windows.Forms.Label lbusonivel;
        private System.Windows.Forms.TextBox txtusodata;
        private System.Windows.Forms.Label lbusodata;
        private System.Windows.Forms.TextBox txtusoqtde;
        private System.Windows.Forms.Label lbusoqtd;
        private System.Windows.Forms.TextBox txtusobloq;
        private System.Windows.Forms.Label lbusobloq;
    }
}