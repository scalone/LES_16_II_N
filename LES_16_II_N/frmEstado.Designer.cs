namespace LES_16_II_N
{
    partial class frmestado
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
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.lbestnome = new System.Windows.Forms.Label();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.lbestuf = new System.Windows.Forms.Label();
            this.txtestcodi = new System.Windows.Forms.TextBox();
            this.lbestcodi = new System.Windows.Forms.Label();
            this.txtesticms = new System.Windows.Forms.TextBox();
            this.lbesticms = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.lbpaisnome = new System.Windows.Forms.Label();
            this.cbpaisnome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtestnome
            // 
            this.txtestnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestnome.Location = new System.Drawing.Point(80, 115);
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.Size = new System.Drawing.Size(250, 20);
            this.txtestnome.TabIndex = 9;
            // 
            // lbestnome
            // 
            this.lbestnome.AutoSize = true;
            this.lbestnome.Location = new System.Drawing.Point(12, 120);
            this.lbestnome.Name = "lbestnome";
            this.lbestnome.Size = new System.Drawing.Size(45, 13);
            this.lbestnome.TabIndex = 10;
            this.lbestnome.Text = "NOME: ";
            // 
            // txtestuf
            // 
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(80, 65);
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.Size = new System.Drawing.Size(50, 20);
            this.txtestuf.TabIndex = 8;
            // 
            // lbestuf
            // 
            this.lbestuf.AutoSize = true;
            this.lbestuf.Location = new System.Drawing.Point(12, 70);
            this.lbestuf.Name = "lbestuf";
            this.lbestuf.Size = new System.Drawing.Size(27, 13);
            this.lbestuf.TabIndex = 8;
            this.lbestuf.Text = "UF: ";
            // 
            // txtestcodi
            // 
            this.txtestcodi.Location = new System.Drawing.Point(80, 15);
            this.txtestcodi.Name = "txtestcodi";
            this.txtestcodi.Size = new System.Drawing.Size(50, 20);
            this.txtestcodi.TabIndex = 7;
            this.txtestcodi.Leave += new System.EventHandler(this.txtestcodi_Leave);
            // 
            // lbestcodi
            // 
            this.lbestcodi.AutoSize = true;
            this.lbestcodi.Location = new System.Drawing.Point(12, 20);
            this.lbestcodi.Name = "lbestcodi";
            this.lbestcodi.Size = new System.Drawing.Size(55, 13);
            this.lbestcodi.TabIndex = 6;
            this.lbestcodi.Text = "CÓDIGO: ";
            // 
            // txtesticms
            // 
            this.txtesticms.Location = new System.Drawing.Point(80, 165);
            this.txtesticms.Name = "txtesticms";
            this.txtesticms.Size = new System.Drawing.Size(100, 20);
            this.txtesticms.TabIndex = 10;
            // 
            // lbesticms
            // 
            this.lbesticms.AutoSize = true;
            this.lbesticms.Location = new System.Drawing.Point(12, 170);
            this.lbesticms.Name = "lbesticms";
            this.lbesticms.Size = new System.Drawing.Size(39, 13);
            this.lbesticms.TabIndex = 12;
            this.lbesticms.Text = "ICMS: ";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 17;
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
            this.btexcluir.TabIndex = 16;
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
            this.btgravar.TabIndex = 15;
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
            this.btincluir.TabIndex = 14;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // lbpaisnome
            // 
            this.lbpaisnome.AutoSize = true;
            this.lbpaisnome.Location = new System.Drawing.Point(12, 220);
            this.lbpaisnome.Name = "lbpaisnome";
            this.lbpaisnome.Size = new System.Drawing.Size(37, 13);
            this.lbpaisnome.TabIndex = 18;
            this.lbpaisnome.Text = "PAIS: ";
            // 
            // cbpaisnome
            // 
            this.cbpaisnome.FormattingEnabled = true;
            this.cbpaisnome.Location = new System.Drawing.Point(80, 215);
            this.cbpaisnome.Name = "cbpaisnome";
            this.cbpaisnome.Size = new System.Drawing.Size(121, 21);
            this.cbpaisnome.TabIndex = 19;
            // 
            // frmestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbpaisnome);
            this.Controls.Add(this.lbpaisnome);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtesticms);
            this.Controls.Add(this.lbesticms);
            this.Controls.Add(this.txtestnome);
            this.Controls.Add(this.lbestnome);
            this.Controls.Add(this.txtestuf);
            this.Controls.Add(this.lbestuf);
            this.Controls.Add(this.txtestcodi);
            this.Controls.Add(this.lbestcodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.Load += new System.EventHandler(this.frmestado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmestado_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtestnome;
        private System.Windows.Forms.Label lbestnome;
        private System.Windows.Forms.TextBox txtestuf;
        private System.Windows.Forms.Label lbestuf;
        private System.Windows.Forms.TextBox txtestcodi;
        private System.Windows.Forms.Label lbestcodi;
        private System.Windows.Forms.TextBox txtesticms;
        private System.Windows.Forms.Label lbesticms;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.Label lbpaisnome;
        private System.Windows.Forms.ComboBox cbpaisnome;
    }
}