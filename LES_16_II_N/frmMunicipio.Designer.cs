namespace LES_16_II_N
{
    partial class frmmunicipio
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
            this.txtmuncodi = new System.Windows.Forms.TextBox();
            this.lbmuncodi = new System.Windows.Forms.Label();
            this.txtmunnome = new System.Windows.Forms.TextBox();
            this.lbmunnome = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.lbmunest = new System.Windows.Forms.Label();
            this.cbestnome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtmuncodi
            // 
            this.txtmuncodi.Location = new System.Drawing.Point(80, 15);
            this.txtmuncodi.Name = "txtmuncodi";
            this.txtmuncodi.Size = new System.Drawing.Size(100, 20);
            this.txtmuncodi.TabIndex = 9;
            this.txtmuncodi.Leave += new System.EventHandler(this.txtmuncodi_Leave);
            // 
            // lbmuncodi
            // 
            this.lbmuncodi.AutoSize = true;
            this.lbmuncodi.Location = new System.Drawing.Point(12, 20);
            this.lbmuncodi.Name = "lbmuncodi";
            this.lbmuncodi.Size = new System.Drawing.Size(55, 13);
            this.lbmuncodi.TabIndex = 8;
            this.lbmuncodi.Text = "CÓDIGO: ";
            // 
            // txtmunnome
            // 
            this.txtmunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunnome.Location = new System.Drawing.Point(80, 65);
            this.txtmunnome.Name = "txtmunnome";
            this.txtmunnome.Size = new System.Drawing.Size(203, 20);
            this.txtmunnome.TabIndex = 13;
            // 
            // lbmunnome
            // 
            this.lbmunnome.AutoSize = true;
            this.lbmunnome.Location = new System.Drawing.Point(12, 70);
            this.lbmunnome.Name = "lbmunnome";
            this.lbmunnome.Size = new System.Drawing.Size(45, 13);
            this.lbmunnome.TabIndex = 12;
            this.lbmunnome.Text = "NOME: ";
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
            // lbmunest
            // 
            this.lbmunest.AutoSize = true;
            this.lbmunest.Location = new System.Drawing.Point(12, 120);
            this.lbmunest.Name = "lbmunest";
            this.lbmunest.Size = new System.Drawing.Size(57, 13);
            this.lbmunest.TabIndex = 22;
            this.lbmunest.Text = "ESTADO: ";
            // 
            // cbestnome
            // 
            this.cbestnome.FormattingEnabled = true;
            this.cbestnome.Location = new System.Drawing.Point(80, 115);
            this.cbestnome.Name = "cbestnome";
            this.cbestnome.Size = new System.Drawing.Size(203, 21);
            this.cbestnome.TabIndex = 24;
            // 
            // frmmunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbestnome);
            this.Controls.Add(this.lbmunest);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtmunnome);
            this.Controls.Add(this.lbmunnome);
            this.Controls.Add(this.txtmuncodi);
            this.Controls.Add(this.lbmuncodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Municípios";
            this.Load += new System.EventHandler(this.frmmunicipio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmunicipio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmuncodi;
        private System.Windows.Forms.Label lbmuncodi;
        private System.Windows.Forms.TextBox txtmunnome;
        private System.Windows.Forms.Label lbmunnome;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.Label lbmunest;
        private System.Windows.Forms.ComboBox cbestnome;
    }
}