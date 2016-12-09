namespace LES_16_II_N
{
    partial class frmramo
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
            this.txtramnome = new System.Windows.Forms.TextBox();
            this.lbramnome = new System.Windows.Forms.Label();
            this.txtramcodi = new System.Windows.Forms.TextBox();
            this.lbramcodi = new System.Windows.Forms.Label();
            this.txtramobse = new System.Windows.Forms.TextBox();
            this.lbramobse = new System.Windows.Forms.Label();
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
            // txtramnome
            // 
            this.txtramnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtramnome.Location = new System.Drawing.Point(80, 65);
            this.txtramnome.Name = "txtramnome";
            this.txtramnome.Size = new System.Drawing.Size(250, 20);
            this.txtramnome.TabIndex = 24;
            // 
            // lbramnome
            // 
            this.lbramnome.AutoSize = true;
            this.lbramnome.Location = new System.Drawing.Point(12, 70);
            this.lbramnome.Name = "lbramnome";
            this.lbramnome.Size = new System.Drawing.Size(45, 13);
            this.lbramnome.TabIndex = 25;
            this.lbramnome.Text = "NOME: ";
            // 
            // txtramcodi
            // 
            this.txtramcodi.Location = new System.Drawing.Point(80, 15);
            this.txtramcodi.Name = "txtramcodi";
            this.txtramcodi.Size = new System.Drawing.Size(88, 20);
            this.txtramcodi.TabIndex = 23;
            this.txtramcodi.Leave += new System.EventHandler(this.txtramcodi_Leave);
            // 
            // lbramcodi
            // 
            this.lbramcodi.AutoSize = true;
            this.lbramcodi.Location = new System.Drawing.Point(12, 20);
            this.lbramcodi.Name = "lbramcodi";
            this.lbramcodi.Size = new System.Drawing.Size(55, 13);
            this.lbramcodi.TabIndex = 22;
            this.lbramcodi.Text = "CÓDIGO: ";
            // 
            // txtramobse
            // 
            this.txtramobse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtramobse.Location = new System.Drawing.Point(80, 118);
            this.txtramobse.Multiline = true;
            this.txtramobse.Name = "txtramobse";
            this.txtramobse.Size = new System.Drawing.Size(250, 126);
            this.txtramobse.TabIndex = 30;
            // 
            // lbramobse
            // 
            this.lbramobse.AutoSize = true;
            this.lbramobse.Location = new System.Drawing.Point(12, 123);
            this.lbramobse.Name = "lbramobse";
            this.lbramobse.Size = new System.Drawing.Size(42, 13);
            this.lbramobse.TabIndex = 31;
            this.lbramobse.Text = "OBSE: ";
            // 
            // frmramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.txtramobse);
            this.Controls.Add(this.lbramobse);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtramnome);
            this.Controls.Add(this.lbramnome);
            this.Controls.Add(this.txtramcodi);
            this.Controls.Add(this.lbramcodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Ramo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtramnome;
        private System.Windows.Forms.Label lbramnome;
        private System.Windows.Forms.TextBox txtramcodi;
        private System.Windows.Forms.Label lbramcodi;
        private System.Windows.Forms.TextBox txtramobse;
        private System.Windows.Forms.Label lbramobse;
    }
}