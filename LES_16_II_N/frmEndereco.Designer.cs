namespace LES_16_II_N
{
    partial class frmendereco
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
            this.lbcodibai = new System.Windows.Forms.Label();
            this.txtendende = new System.Windows.Forms.TextBox();
            this.lbendende = new System.Windows.Forms.Label();
            this.lbendcep = new System.Windows.Forms.Label();
            this.txtendcep = new System.Windows.Forms.MaskedTextBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.cbbainome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbcodibai
            // 
            this.lbcodibai.AutoSize = true;
            this.lbcodibai.Location = new System.Drawing.Point(12, 120);
            this.lbcodibai.Name = "lbcodibai";
            this.lbcodibai.Size = new System.Drawing.Size(54, 13);
            this.lbcodibai.TabIndex = 16;
            this.lbcodibai.Text = "BAIRRO: ";
            // 
            // txtendende
            // 
            this.txtendende.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendende.Location = new System.Drawing.Point(80, 65);
            this.txtendende.Name = "txtendende";
            this.txtendende.Size = new System.Drawing.Size(250, 20);
            this.txtendende.TabIndex = 16;
            // 
            // lbendende
            // 
            this.lbendende.AutoSize = true;
            this.lbendende.Location = new System.Drawing.Point(13, 70);
            this.lbendende.Name = "lbendende";
            this.lbendende.Size = new System.Drawing.Size(73, 13);
            this.lbendende.TabIndex = 14;
            this.lbendende.Text = "ENDEREÇO: ";
            // 
            // lbendcep
            // 
            this.lbendcep.AutoSize = true;
            this.lbendcep.Location = new System.Drawing.Point(13, 20);
            this.lbendcep.Name = "lbendcep";
            this.lbendcep.Size = new System.Drawing.Size(34, 13);
            this.lbendcep.TabIndex = 12;
            this.lbendcep.Text = "CEP: ";
            // 
            // txtendcep
            // 
            this.txtendcep.Location = new System.Drawing.Point(80, 15);
            this.txtendcep.Mask = "00000-999";
            this.txtendcep.Name = "txtendcep";
            this.txtendcep.Size = new System.Drawing.Size(100, 20);
            this.txtendcep.TabIndex = 15;
            this.txtendcep.Leave += new System.EventHandler(this.txtendcep_Leave);
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 21;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(208, 338);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 20;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(108, 338);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 19;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btincluir
            // 
            this.btincluir.Location = new System.Drawing.Point(8, 338);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 18;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // cbbainome
            // 
            this.cbbainome.FormattingEnabled = true;
            this.cbbainome.Location = new System.Drawing.Point(80, 115);
            this.cbbainome.Name = "cbbainome";
            this.cbbainome.Size = new System.Drawing.Size(203, 21);
            this.cbbainome.TabIndex = 22;
            // 
            // frmendereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbbainome);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtendcep);
            this.Controls.Add(this.lbcodibai);
            this.Controls.Add(this.txtendende);
            this.Controls.Add(this.lbendende);
            this.Controls.Add(this.lbendcep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmendereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Endereços";
            this.Load += new System.EventHandler(this.frmEndereco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEndereco_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodibai;
        private System.Windows.Forms.TextBox txtendende;
        private System.Windows.Forms.Label lbendende;
        private System.Windows.Forms.Label lbendcep;
        private System.Windows.Forms.MaskedTextBox txtendcep;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.ComboBox cbbainome;
    }
}