namespace LES_16_II_N
{
    partial class frmpais
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
            this.lbpaicodi = new System.Windows.Forms.Label();
            this.txtpaicodi = new System.Windows.Forms.TextBox();
            this.lbpainome = new System.Windows.Forms.Label();
            this.txtpainome = new System.Windows.Forms.TextBox();
            this.btincluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpaicodi
            // 
            this.lbpaicodi.AutoSize = true;
            this.lbpaicodi.Location = new System.Drawing.Point(12, 20);
            this.lbpaicodi.Name = "lbpaicodi";
            this.lbpaicodi.Size = new System.Drawing.Size(55, 13);
            this.lbpaicodi.TabIndex = 0;
            this.lbpaicodi.Text = "CÓDIGO: ";
            // 
            // txtpaicodi
            // 
            this.txtpaicodi.Location = new System.Drawing.Point(80, 15);
            this.txtpaicodi.Name = "txtpaicodi";
            this.txtpaicodi.Size = new System.Drawing.Size(50, 20);
            this.txtpaicodi.TabIndex = 1;
            this.txtpaicodi.Leave += new System.EventHandler(this.txtpaicodi_Leave);
            // 
            // lbpainome
            // 
            this.lbpainome.AutoSize = true;
            this.lbpainome.Location = new System.Drawing.Point(12, 70);
            this.lbpainome.Name = "lbpainome";
            this.lbpainome.Size = new System.Drawing.Size(45, 13);
            this.lbpainome.TabIndex = 2;
            this.lbpainome.Text = "NOME: ";
            // 
            // txtpainome
            // 
            this.txtpainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpainome.Location = new System.Drawing.Point(80, 65);
            this.txtpainome.Name = "txtpainome";
            this.txtpainome.Size = new System.Drawing.Size(250, 20);
            this.txtpainome.TabIndex = 3;
            // 
            // btincluir
            // 
            this.btincluir.Enabled = false;
            this.btincluir.Location = new System.Drawing.Point(8, 338);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 4;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Enabled = false;
            this.btgravar.Location = new System.Drawing.Point(108, 338);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 5;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Enabled = false;
            this.btexcluir.Location = new System.Drawing.Point(208, 338);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 6;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(308, 338);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmpais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtpainome);
            this.Controls.Add(this.lbpainome);
            this.Controls.Add(this.txtpaicodi);
            this.Controls.Add(this.lbpaicodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Países";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmpais_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbpaicodi;
        private System.Windows.Forms.TextBox txtpaicodi;
        private System.Windows.Forms.Label lbpainome;
        private System.Windows.Forms.TextBox txtpainome;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btVoltar;
    }
}