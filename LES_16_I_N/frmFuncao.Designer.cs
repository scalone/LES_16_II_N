namespace LES_15_I_N
{
    partial class frmfuncao
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
            this.txtfuccodi = new System.Windows.Forms.TextBox();
            this.lbfuccodi = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.txtfucnome = new System.Windows.Forms.TextBox();
            this.lbfucnome = new System.Windows.Forms.Label();
            this.lbcbonome = new System.Windows.Forms.Label();
            this.cbcbonome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtfuccodi
            // 
            this.txtfuccodi.Location = new System.Drawing.Point(80, 15);
            this.txtfuccodi.Name = "txtfuccodi";
            this.txtfuccodi.Size = new System.Drawing.Size(103, 20);
            this.txtfuccodi.TabIndex = 33;
            this.txtfuccodi.Leave += new System.EventHandler(this.txtfuccodi_Leave);
            // 
            // lbfuccodi
            // 
            this.lbfuccodi.AutoSize = true;
            this.lbfuccodi.Location = new System.Drawing.Point(12, 20);
            this.lbfuccodi.Name = "lbfuccodi";
            this.lbfuccodi.Size = new System.Drawing.Size(55, 13);
            this.lbfuccodi.TabIndex = 32;
            this.lbfuccodi.Text = "CÓDIGO: ";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 37;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Enabled = false;
            this.btexcluir.Location = new System.Drawing.Point(208, 338);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 36;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Enabled = false;
            this.btgravar.Location = new System.Drawing.Point(108, 338);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 35;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btincluir
            // 
            this.btincluir.Enabled = false;
            this.btincluir.Location = new System.Drawing.Point(8, 338);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 34;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtfucnome
            // 
            this.txtfucnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfucnome.Location = new System.Drawing.Point(80, 65);
            this.txtfucnome.Name = "txtfucnome";
            this.txtfucnome.Size = new System.Drawing.Size(262, 20);
            this.txtfucnome.TabIndex = 39;
            // 
            // lbfucnome
            // 
            this.lbfucnome.AutoSize = true;
            this.lbfucnome.Location = new System.Drawing.Point(12, 70);
            this.lbfucnome.Name = "lbfucnome";
            this.lbfucnome.Size = new System.Drawing.Size(45, 13);
            this.lbfucnome.TabIndex = 38;
            this.lbfucnome.Text = "NOME: ";
            // 
            // lbcbonome
            // 
            this.lbcbonome.AutoSize = true;
            this.lbcbonome.Location = new System.Drawing.Point(12, 120);
            this.lbcbonome.Name = "lbcbonome";
            this.lbcbonome.Size = new System.Drawing.Size(35, 13);
            this.lbcbonome.TabIndex = 44;
            this.lbcbonome.Text = "CBO: ";
            // 
            // cbcbonome
            // 
            this.cbcbonome.FormattingEnabled = true;
            this.cbcbonome.Location = new System.Drawing.Point(80, 115);
            this.cbcbonome.Name = "cbcbonome";
            this.cbcbonome.Size = new System.Drawing.Size(262, 21);
            this.cbcbonome.TabIndex = 45;
            // 
            // frmfuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbcbonome);
            this.Controls.Add(this.lbcbonome);
            this.Controls.Add(this.txtfucnome);
            this.Controls.Add(this.lbfucnome);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtfuccodi);
            this.Controls.Add(this.lbfuccodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção das Funções";
            this.Load += new System.EventHandler(this.frmfuncao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfuccodi;
        private System.Windows.Forms.Label lbfuccodi;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtfucnome;
        private System.Windows.Forms.Label lbfucnome;
        private System.Windows.Forms.Label lbcbonome;
        private System.Windows.Forms.ComboBox cbcbonome;
    }
}