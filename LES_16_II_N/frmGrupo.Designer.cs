namespace LES_16_II_N
{
    partial class frmgrupo
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
            this.txtgrucodi = new System.Windows.Forms.TextBox();
            this.lbgrucodi = new System.Windows.Forms.Label();
            this.txtgrunome = new System.Windows.Forms.TextBox();
            this.lbgrunome = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtgrucodi
            // 
            this.txtgrucodi.Location = new System.Drawing.Point(80, 15);
            this.txtgrucodi.Name = "txtgrucodi";
            this.txtgrucodi.Size = new System.Drawing.Size(88, 20);
            this.txtgrucodi.TabIndex = 9;
            this.txtgrucodi.Leave += new System.EventHandler(this.txtgrucodi_Leave);
            // 
            // lbgrucodi
            // 
            this.lbgrucodi.AutoSize = true;
            this.lbgrucodi.Location = new System.Drawing.Point(12, 20);
            this.lbgrucodi.Name = "lbgrucodi";
            this.lbgrucodi.Size = new System.Drawing.Size(55, 13);
            this.lbgrucodi.TabIndex = 8;
            this.lbgrucodi.Text = "CÓDIGO: ";
            // 
            // txtgrunome
            // 
            this.txtgrunome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrunome.Location = new System.Drawing.Point(80, 65);
            this.txtgrunome.Name = "txtgrunome";
            this.txtgrunome.Size = new System.Drawing.Size(250, 20);
            this.txtgrunome.TabIndex = 11;
            // 
            // lbgrunome
            // 
            this.lbgrunome.AutoSize = true;
            this.lbgrunome.Location = new System.Drawing.Point(12, 70);
            this.lbgrunome.Name = "lbgrunome";
            this.lbgrunome.Size = new System.Drawing.Size(45, 13);
            this.lbgrunome.TabIndex = 12;
            this.lbgrunome.Text = "NOME: ";
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
            // frmgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtgrunome);
            this.Controls.Add(this.lbgrunome);
            this.Controls.Add(this.txtgrucodi);
            this.Controls.Add(this.lbgrucodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Grupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgrucodi;
        private System.Windows.Forms.Label lbgrucodi;
        private System.Windows.Forms.TextBox txtgrunome;
        private System.Windows.Forms.Label lbgrunome;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
    }
}