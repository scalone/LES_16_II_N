namespace LES_15_I_N
{
    partial class frmbairro
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
            this.lbbaicodi = new System.Windows.Forms.Label();
            this.txtbaicodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbainome = new System.Windows.Forms.TextBox();
            this.btincluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.lbbaimun = new System.Windows.Forms.Label();
            this.cbmunnome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbbaicodi
            // 
            this.lbbaicodi.AutoSize = true;
            this.lbbaicodi.Location = new System.Drawing.Point(13, 20);
            this.lbbaicodi.Name = "lbbaicodi";
            this.lbbaicodi.Size = new System.Drawing.Size(55, 13);
            this.lbbaicodi.TabIndex = 0;
            this.lbbaicodi.Text = "CÓDIGO: ";
            // 
            // txtbaicodi
            // 
            this.txtbaicodi.Location = new System.Drawing.Point(80, 15);
            this.txtbaicodi.Name = "txtbaicodi";
            this.txtbaicodi.Size = new System.Drawing.Size(50, 20);
            this.txtbaicodi.TabIndex = 1;
            this.txtbaicodi.Leave += new System.EventHandler(this.txtbaicodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME: ";
            // 
            // txtbainome
            // 
            this.txtbainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbainome.Location = new System.Drawing.Point(80, 65);
            this.txtbainome.Name = "txtbainome";
            this.txtbainome.Size = new System.Drawing.Size(250, 20);
            this.txtbainome.TabIndex = 3;
            // 
            // btincluir
            // 
            this.btincluir.Location = new System.Drawing.Point(8, 338);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 6;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(108, 338);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 7;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(208, 338);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 8;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 9;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // lbbaimun
            // 
            this.lbbaimun.AutoSize = true;
            this.lbbaimun.Location = new System.Drawing.Point(12, 120);
            this.lbbaimun.Name = "lbbaimun";
            this.lbbaimun.Size = new System.Drawing.Size(69, 13);
            this.lbbaimun.TabIndex = 10;
            this.lbbaimun.Text = "MUNICÍPIO: ";
            // 
            // cbmunnome
            // 
            this.cbmunnome.FormattingEnabled = true;
            this.cbmunnome.Location = new System.Drawing.Point(80, 115);
            this.cbmunnome.Name = "cbmunnome";
            this.cbmunnome.Size = new System.Drawing.Size(203, 21);
            this.cbmunnome.TabIndex = 12;
            // 
            // frmbairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbmunnome);
            this.Controls.Add(this.lbbaimun);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtbainome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbaicodi);
            this.Controls.Add(this.lbbaicodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Bairros";
            this.Load += new System.EventHandler(this.frmbairro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmbairro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbaicodi;
        private System.Windows.Forms.TextBox txtbaicodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbainome;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Label lbbaimun;
        private System.Windows.Forms.ComboBox cbmunnome;
    }
}