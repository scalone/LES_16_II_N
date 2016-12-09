namespace LES_16_II_N
{
    partial class frmUnidade
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
            this.lbunicodi = new System.Windows.Forms.Label();
            this.lbuninome = new System.Windows.Forms.Label();
            this.txtunicodi = new System.Windows.Forms.TextBox();
            this.txtuninome = new System.Windows.Forms.TextBox();
            this.btincluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbunicodi
            // 
            this.lbunicodi.AutoSize = true;
            this.lbunicodi.Location = new System.Drawing.Point(12, 18);
            this.lbunicodi.Name = "lbunicodi";
            this.lbunicodi.Size = new System.Drawing.Size(49, 13);
            this.lbunicodi.TabIndex = 0;
            this.lbunicodi.Text = "CODIGO";
            // 
            // lbuninome
            // 
            this.lbuninome.AutoSize = true;
            this.lbuninome.Location = new System.Drawing.Point(13, 53);
            this.lbuninome.Name = "lbuninome";
            this.lbuninome.Size = new System.Drawing.Size(39, 13);
            this.lbuninome.TabIndex = 1;
            this.lbuninome.Text = "NOME";
            // 
            // txtunicodi
            // 
            this.txtunicodi.Location = new System.Drawing.Point(67, 14);
            this.txtunicodi.Name = "txtunicodi";
            this.txtunicodi.Size = new System.Drawing.Size(100, 20);
            this.txtunicodi.TabIndex = 2;
            // 
            // txtuninome
            // 
            this.txtuninome.Location = new System.Drawing.Point(68, 48);
            this.txtuninome.Name = "txtuninome";
            this.txtuninome.Size = new System.Drawing.Size(100, 20);
            this.txtuninome.TabIndex = 3;
            // 
            // btincluir
            // 
            this.btincluir.Location = new System.Drawing.Point(16, 227);
            this.btincluir.Name = "btincluir";
            this.btincluir.Size = new System.Drawing.Size(75, 23);
            this.btincluir.TabIndex = 4;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // btgravar
            // 
            this.btgravar.Location = new System.Drawing.Point(98, 227);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 23);
            this.btgravar.TabIndex = 5;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.btgravar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(180, 227);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 6;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(262, 227);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 7;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // frmUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.txtuninome);
            this.Controls.Add(this.txtunicodi);
            this.Controls.Add(this.lbuninome);
            this.Controls.Add(this.lbunicodi);
            this.Name = "frmUnidade";
            this.Text = "frmUnidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbunicodi;
        private System.Windows.Forms.Label lbuninome;
        private System.Windows.Forms.TextBox txtunicodi;
        private System.Windows.Forms.TextBox txtuninome;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btvoltar;
    }
}