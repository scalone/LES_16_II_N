namespace LES_15_I_N
{
    partial class frmcbo
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
            this.txtcbocodi = new System.Windows.Forms.TextBox();
            this.lbcbocodi = new System.Windows.Forms.Label();
            this.txtcbonome = new System.Windows.Forms.TextBox();
            this.lbcbonome = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcbocodi
            // 
            this.txtcbocodi.Location = new System.Drawing.Point(80, 15);
            this.txtcbocodi.Name = "txtcbocodi";
            this.txtcbocodi.Size = new System.Drawing.Size(103, 20);
            this.txtcbocodi.TabIndex = 35;
            this.txtcbocodi.Leave += new System.EventHandler(this.txtcbocodi_Leave);
            // 
            // lbcbocodi
            // 
            this.lbcbocodi.AutoSize = true;
            this.lbcbocodi.Location = new System.Drawing.Point(12, 20);
            this.lbcbocodi.Name = "lbcbocodi";
            this.lbcbocodi.Size = new System.Drawing.Size(55, 13);
            this.lbcbocodi.TabIndex = 34;
            this.lbcbocodi.Text = "CÓDIGO: ";
            // 
            // txtcbonome
            // 
            this.txtcbonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcbonome.Location = new System.Drawing.Point(80, 65);
            this.txtcbonome.Name = "txtcbonome";
            this.txtcbonome.Size = new System.Drawing.Size(262, 20);
            this.txtcbonome.TabIndex = 41;
            // 
            // lbcbonome
            // 
            this.lbcbonome.AutoSize = true;
            this.lbcbonome.Location = new System.Drawing.Point(12, 70);
            this.lbcbonome.Name = "lbcbonome";
            this.lbcbonome.Size = new System.Drawing.Size(45, 13);
            this.lbcbonome.TabIndex = 40;
            this.lbcbonome.Text = "NOME: ";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 45;
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
            this.btexcluir.TabIndex = 44;
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
            this.btgravar.TabIndex = 43;
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
            this.btincluir.TabIndex = 42;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // frmcbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtcbonome);
            this.Controls.Add(this.lbcbonome);
            this.Controls.Add(this.txtcbocodi);
            this.Controls.Add(this.lbcbocodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcbo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos CBOs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcbocodi;
        private System.Windows.Forms.Label lbcbocodi;
        private System.Windows.Forms.TextBox txtcbonome;
        private System.Windows.Forms.Label lbcbonome;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
    }
}