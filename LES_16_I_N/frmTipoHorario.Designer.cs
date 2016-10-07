namespace LES_15_I_N
{
    partial class frmtipohorario
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
            this.txtthocodi = new System.Windows.Forms.TextBox();
            this.lbthocodi = new System.Windows.Forms.Label();
            this.txtthonome = new System.Windows.Forms.TextBox();
            this.lbthonome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 25;
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
            this.btexcluir.TabIndex = 24;
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
            this.btgravar.TabIndex = 23;
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
            this.btincluir.TabIndex = 22;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtthocodi
            // 
            this.txtthocodi.Location = new System.Drawing.Point(80, 15);
            this.txtthocodi.Name = "txtthocodi";
            this.txtthocodi.Size = new System.Drawing.Size(103, 20);
            this.txtthocodi.TabIndex = 27;
            this.txtthocodi.Leave += new System.EventHandler(this.txtthocodi_Leave);
            // 
            // lbthocodi
            // 
            this.lbthocodi.AutoSize = true;
            this.lbthocodi.Location = new System.Drawing.Point(12, 20);
            this.lbthocodi.Name = "lbthocodi";
            this.lbthocodi.Size = new System.Drawing.Size(55, 13);
            this.lbthocodi.TabIndex = 26;
            this.lbthocodi.Text = "CÓDIGO: ";
            // 
            // txtthonome
            // 
            this.txtthonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtthonome.Location = new System.Drawing.Point(80, 65);
            this.txtthonome.Name = "txtthonome";
            this.txtthonome.Size = new System.Drawing.Size(183, 20);
            this.txtthonome.TabIndex = 29;
            // 
            // lbthonome
            // 
            this.lbthonome.AutoSize = true;
            this.lbthonome.Location = new System.Drawing.Point(12, 70);
            this.lbthonome.Name = "lbthonome";
            this.lbthonome.Size = new System.Drawing.Size(45, 13);
            this.lbthonome.TabIndex = 28;
            this.lbthonome.Text = "NOME: ";
            // 
            // frmtipohorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.txtthonome);
            this.Controls.Add(this.lbthonome);
            this.Controls.Add(this.txtthocodi);
            this.Controls.Add(this.lbthocodi);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtipohorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Tipos dos Horários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtthocodi;
        private System.Windows.Forms.Label lbthocodi;
        private System.Windows.Forms.TextBox txtthonome;
        private System.Windows.Forms.Label lbthonome;
    }
}