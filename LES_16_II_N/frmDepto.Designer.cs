namespace LES_16_II_N
{
    partial class frmdepto
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
            this.txtdepcodi = new System.Windows.Forms.TextBox();
            this.lbdepcodi = new System.Windows.Forms.Label();
            this.txtdepnome = new System.Windows.Forms.TextBox();
            this.lbdepnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btexcluir.Enabled = false;
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
            this.btgravar.Enabled = false;
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
            this.btincluir.Enabled = false;
            this.btincluir.Location = new System.Drawing.Point(8, 338);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 18;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtdepcodi
            // 
            this.txtdepcodi.Location = new System.Drawing.Point(80, 15);
            this.txtdepcodi.Name = "txtdepcodi";
            this.txtdepcodi.Size = new System.Drawing.Size(103, 20);
            this.txtdepcodi.TabIndex = 23;
            this.txtdepcodi.Leave += new System.EventHandler(this.txtdepcodi_Leave);
            // 
            // lbdepcodi
            // 
            this.lbdepcodi.AutoSize = true;
            this.lbdepcodi.Location = new System.Drawing.Point(12, 20);
            this.lbdepcodi.Name = "lbdepcodi";
            this.lbdepcodi.Size = new System.Drawing.Size(55, 13);
            this.lbdepcodi.TabIndex = 22;
            this.lbdepcodi.Text = "CÓDIGO: ";
            // 
            // txtdepnome
            // 
            this.txtdepnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdepnome.Location = new System.Drawing.Point(80, 65);
            this.txtdepnome.Name = "txtdepnome";
            this.txtdepnome.Size = new System.Drawing.Size(183, 20);
            this.txtdepnome.TabIndex = 25;
            // 
            // lbdepnome
            // 
            this.lbdepnome.AutoSize = true;
            this.lbdepnome.Location = new System.Drawing.Point(12, 70);
            this.lbdepnome.Name = "lbdepnome";
            this.lbdepnome.Size = new System.Drawing.Size(45, 13);
            this.lbdepnome.TabIndex = 24;
            this.lbdepnome.Text = "NOME: ";
            // 
            // frmdepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.txtdepnome);
            this.Controls.Add(this.lbdepnome);
            this.Controls.Add(this.txtdepcodi);
            this.Controls.Add(this.lbdepcodi);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Departamentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmdepto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtdepcodi;
        private System.Windows.Forms.Label lbdepcodi;
        private System.Windows.Forms.TextBox txtdepnome;
        private System.Windows.Forms.Label lbdepnome;
    }
}