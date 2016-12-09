namespace LES_16_II_N
{
    partial class frmproduto
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
            this.txtprocust = new System.Windows.Forms.TextBox();
            this.lbprocust = new System.Windows.Forms.Label();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.lbpronome = new System.Windows.Forms.Label();
            this.txtprocodi = new System.Windows.Forms.TextBox();
            this.lbprocodi = new System.Windows.Forms.Label();
            this.txtpromarg = new System.Windows.Forms.TextBox();
            this.lbpromarg = new System.Windows.Forms.Label();
            this.txtprovend = new System.Windows.Forms.TextBox();
            this.lbprovend = new System.Windows.Forms.Label();
            this.txtproesto = new System.Windows.Forms.TextBox();
            this.lbproesto = new System.Windows.Forms.Label();
            this.txtproloca = new System.Windows.Forms.TextBox();
            this.lbproloca = new System.Windows.Forms.Label();
            this.txtproobs = new System.Windows.Forms.TextBox();
            this.lbproobs = new System.Windows.Forms.Label();
            this.cbgrunome = new System.Windows.Forms.ComboBox();
            this.lbgrunome = new System.Windows.Forms.Label();
            this.cbuninome = new System.Windows.Forms.ComboBox();
            this.lbuninome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 29;
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
            this.btexcluir.TabIndex = 28;
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
            this.btgravar.TabIndex = 27;
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
            this.btincluir.TabIndex = 26;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtprocust
            // 
            this.txtprocust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtprocust.Location = new System.Drawing.Point(113, 95);
            this.txtprocust.Name = "txtprocust";
            this.txtprocust.Size = new System.Drawing.Size(78, 20);
            this.txtprocust.TabIndex = 22;
            // 
            // lbprocust
            // 
            this.lbprocust.AutoSize = true;
            this.lbprocust.Location = new System.Drawing.Point(12, 100);
            this.lbprocust.Name = "lbprocust";
            this.lbprocust.Size = new System.Drawing.Size(90, 13);
            this.lbprocust.TabIndex = 24;
            this.lbprocust.Text = "PREÇO CUSTO: ";
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(113, 55);
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(268, 20);
            this.txtpronome.TabIndex = 20;
            // 
            // lbpronome
            // 
            this.lbpronome.AutoSize = true;
            this.lbpronome.Location = new System.Drawing.Point(53, 60);
            this.lbpronome.Name = "lbpronome";
            this.lbpronome.Size = new System.Drawing.Size(45, 13);
            this.lbpronome.TabIndex = 21;
            this.lbpronome.Text = "NOME: ";
            // 
            // txtprocodi
            // 
            this.txtprocodi.Location = new System.Drawing.Point(113, 15);
            this.txtprocodi.Name = "txtprocodi";
            this.txtprocodi.Size = new System.Drawing.Size(103, 20);
            this.txtprocodi.TabIndex = 19;
            this.txtprocodi.Leave += new System.EventHandler(this.txtprocodi_Leave);
            // 
            // lbprocodi
            // 
            this.lbprocodi.AutoSize = true;
            this.lbprocodi.Location = new System.Drawing.Point(49, 20);
            this.lbprocodi.Name = "lbprocodi";
            this.lbprocodi.Size = new System.Drawing.Size(55, 13);
            this.lbprocodi.TabIndex = 18;
            this.lbprocodi.Text = "CÓDIGO: ";
            // 
            // txtpromarg
            // 
            this.txtpromarg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpromarg.Location = new System.Drawing.Point(303, 95);
            this.txtpromarg.Name = "txtpromarg";
            this.txtpromarg.Size = new System.Drawing.Size(78, 20);
            this.txtpromarg.TabIndex = 30;
            // 
            // lbpromarg
            // 
            this.lbpromarg.AutoSize = true;
            this.lbpromarg.Location = new System.Drawing.Point(202, 100);
            this.lbpromarg.Name = "lbpromarg";
            this.lbpromarg.Size = new System.Drawing.Size(101, 13);
            this.lbpromarg.TabIndex = 31;
            this.lbpromarg.Text = "MARGEM LUCRO: ";
            // 
            // txtprovend
            // 
            this.txtprovend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtprovend.Location = new System.Drawing.Point(113, 135);
            this.txtprovend.Name = "txtprovend";
            this.txtprovend.Size = new System.Drawing.Size(78, 20);
            this.txtprovend.TabIndex = 32;
            // 
            // lbprovend
            // 
            this.lbprovend.AutoSize = true;
            this.lbprovend.Location = new System.Drawing.Point(12, 140);
            this.lbprovend.Name = "lbprovend";
            this.lbprovend.Size = new System.Drawing.Size(90, 13);
            this.lbprovend.TabIndex = 33;
            this.lbprovend.Text = "PREÇO VENDA: ";
            // 
            // txtproesto
            // 
            this.txtproesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproesto.Location = new System.Drawing.Point(306, 135);
            this.txtproesto.Name = "txtproesto";
            this.txtproesto.Size = new System.Drawing.Size(78, 20);
            this.txtproesto.TabIndex = 34;
            // 
            // lbproesto
            // 
            this.lbproesto.AutoSize = true;
            this.lbproesto.Location = new System.Drawing.Point(205, 140);
            this.lbproesto.Name = "lbproesto";
            this.lbproesto.Size = new System.Drawing.Size(98, 13);
            this.lbproesto.TabIndex = 35;
            this.lbproesto.Text = "QTDE ESTOQUE: ";
            // 
            // txtproloca
            // 
            this.txtproloca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproloca.Location = new System.Drawing.Point(113, 175);
            this.txtproloca.Name = "txtproloca";
            this.txtproloca.Size = new System.Drawing.Size(268, 20);
            this.txtproloca.TabIndex = 36;
            // 
            // lbproloca
            // 
            this.lbproloca.AutoSize = true;
            this.lbproloca.Location = new System.Drawing.Point(12, 180);
            this.lbproloca.Name = "lbproloca";
            this.lbproloca.Size = new System.Drawing.Size(86, 13);
            this.lbproloca.TabIndex = 37;
            this.lbproloca.Text = "LOCALIZAÇÃO: ";
            // 
            // txtproobs
            // 
            this.txtproobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproobs.Location = new System.Drawing.Point(113, 215);
            this.txtproobs.Multiline = true;
            this.txtproobs.Name = "txtproobs";
            this.txtproobs.Size = new System.Drawing.Size(268, 50);
            this.txtproobs.TabIndex = 38;
            // 
            // lbproobs
            // 
            this.lbproobs.AutoSize = true;
            this.lbproobs.Location = new System.Drawing.Point(12, 220);
            this.lbproobs.Name = "lbproobs";
            this.lbproobs.Size = new System.Drawing.Size(86, 13);
            this.lbproobs.TabIndex = 39;
            this.lbproobs.Text = "OBSERVAÇÃO: ";
            // 
            // cbgrunome
            // 
            this.cbgrunome.FormattingEnabled = true;
            this.cbgrunome.Location = new System.Drawing.Point(113, 271);
            this.cbgrunome.Name = "cbgrunome";
            this.cbgrunome.Size = new System.Drawing.Size(268, 21);
            this.cbgrunome.TabIndex = 41;
            // 
            // lbgrunome
            // 
            this.lbgrunome.AutoSize = true;
            this.lbgrunome.Location = new System.Drawing.Point(45, 276);
            this.lbgrunome.Name = "lbgrunome";
            this.lbgrunome.Size = new System.Drawing.Size(52, 13);
            this.lbgrunome.TabIndex = 40;
            this.lbgrunome.Text = "GRUPO: ";
            // 
            // cbuninome
            // 
            this.cbuninome.FormattingEnabled = true;
            this.cbuninome.Location = new System.Drawing.Point(113, 298);
            this.cbuninome.Name = "cbuninome";
            this.cbuninome.Size = new System.Drawing.Size(268, 21);
            this.cbuninome.TabIndex = 43;
            // 
            // lbuninome
            // 
            this.lbuninome.AutoSize = true;
            this.lbuninome.Location = new System.Drawing.Point(45, 303);
            this.lbuninome.Name = "lbuninome";
            this.lbuninome.Size = new System.Drawing.Size(59, 13);
            this.lbuninome.TabIndex = 42;
            this.lbuninome.Text = "UNIDADE:";
            // 
            // frmproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbuninome);
            this.Controls.Add(this.lbuninome);
            this.Controls.Add(this.cbgrunome);
            this.Controls.Add(this.lbgrunome);
            this.Controls.Add(this.txtproobs);
            this.Controls.Add(this.lbproobs);
            this.Controls.Add(this.txtproloca);
            this.Controls.Add(this.lbproloca);
            this.Controls.Add(this.txtproesto);
            this.Controls.Add(this.lbproesto);
            this.Controls.Add(this.txtprovend);
            this.Controls.Add(this.lbprovend);
            this.Controls.Add(this.txtpromarg);
            this.Controls.Add(this.lbpromarg);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtprocust);
            this.Controls.Add(this.lbprocust);
            this.Controls.Add(this.txtpronome);
            this.Controls.Add(this.lbpronome);
            this.Controls.Add(this.txtprocodi);
            this.Controls.Add(this.lbprocodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Produtos";
            this.Load += new System.EventHandler(this.frmproduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtprocust;
        private System.Windows.Forms.Label lbprocust;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.Label lbpronome;
        private System.Windows.Forms.TextBox txtprocodi;
        private System.Windows.Forms.Label lbprocodi;
        private System.Windows.Forms.TextBox txtpromarg;
        private System.Windows.Forms.Label lbpromarg;
        private System.Windows.Forms.TextBox txtprovend;
        private System.Windows.Forms.Label lbprovend;
        private System.Windows.Forms.TextBox txtproesto;
        private System.Windows.Forms.Label lbproesto;
        private System.Windows.Forms.TextBox txtproloca;
        private System.Windows.Forms.Label lbproloca;
        private System.Windows.Forms.TextBox txtproobs;
        private System.Windows.Forms.Label lbproobs;
        private System.Windows.Forms.ComboBox cbgrunome;
        private System.Windows.Forms.Label lbgrunome;
        private System.Windows.Forms.ComboBox cbuninome;
        private System.Windows.Forms.Label lbuninome;
    }
}