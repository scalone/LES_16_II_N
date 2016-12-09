namespace LES_16_II_N
{
    partial class frmhorario
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
            this.txthorcodi = new System.Windows.Forms.TextBox();
            this.lbhorcodi = new System.Windows.Forms.Label();
            this.txthornome = new System.Windows.Forms.TextBox();
            this.lbhornome = new System.Windows.Forms.Label();
            this.txthormane = new System.Windows.Forms.TextBox();
            this.lbhormane = new System.Windows.Forms.Label();
            this.txthormans = new System.Windows.Forms.TextBox();
            this.lbhormans = new System.Windows.Forms.Label();
            this.txthortare = new System.Windows.Forms.TextBox();
            this.lbhortare = new System.Windows.Forms.Label();
            this.txthortars = new System.Windows.Forms.TextBox();
            this.lbhortars = new System.Windows.Forms.Label();
            this.cbthonome = new System.Windows.Forms.ComboBox();
            this.lbthonome = new System.Windows.Forms.Label();
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
            // txthorcodi
            // 
            this.txthorcodi.Location = new System.Drawing.Point(80, 15);
            this.txthorcodi.Name = "txthorcodi";
            this.txthorcodi.Size = new System.Drawing.Size(103, 20);
            this.txthorcodi.TabIndex = 31;
            this.txthorcodi.Leave += new System.EventHandler(this.txthorcodi_Leave);
            // 
            // lbhorcodi
            // 
            this.lbhorcodi.AutoSize = true;
            this.lbhorcodi.Location = new System.Drawing.Point(12, 20);
            this.lbhorcodi.Name = "lbhorcodi";
            this.lbhorcodi.Size = new System.Drawing.Size(55, 13);
            this.lbhorcodi.TabIndex = 30;
            this.lbhorcodi.Text = "CÓDIGO: ";
            // 
            // txthornome
            // 
            this.txthornome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthornome.Location = new System.Drawing.Point(80, 55);
            this.txthornome.Name = "txthornome";
            this.txthornome.Size = new System.Drawing.Size(183, 20);
            this.txthornome.TabIndex = 33;
            // 
            // lbhornome
            // 
            this.lbhornome.AutoSize = true;
            this.lbhornome.Location = new System.Drawing.Point(12, 60);
            this.lbhornome.Name = "lbhornome";
            this.lbhornome.Size = new System.Drawing.Size(45, 13);
            this.lbhornome.TabIndex = 32;
            this.lbhornome.Text = "NOME: ";
            // 
            // txthormane
            // 
            this.txthormane.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormane.Location = new System.Drawing.Point(128, 95);
            this.txthormane.Name = "txthormane";
            this.txthormane.Size = new System.Drawing.Size(135, 20);
            this.txthormane.TabIndex = 35;
            // 
            // lbhormane
            // 
            this.lbhormane.AutoSize = true;
            this.lbhormane.Location = new System.Drawing.Point(12, 100);
            this.lbhormane.Name = "lbhormane";
            this.lbhormane.Size = new System.Drawing.Size(107, 13);
            this.lbhormane.TabIndex = 34;
            this.lbhormane.Text = "ENTRADA MANHÃ: ";
            // 
            // txthormans
            // 
            this.txthormans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormans.Location = new System.Drawing.Point(128, 135);
            this.txthormans.Name = "txthormans";
            this.txthormans.Size = new System.Drawing.Size(135, 20);
            this.txthormans.TabIndex = 37;
            // 
            // lbhormans
            // 
            this.lbhormans.AutoSize = true;
            this.lbhormans.Location = new System.Drawing.Point(32, 140);
            this.lbhormans.Name = "lbhormans";
            this.lbhormans.Size = new System.Drawing.Size(87, 13);
            this.lbhormans.TabIndex = 36;
            this.lbhormans.Text = "SAÍDA MANHÃ: ";
            // 
            // txthortare
            // 
            this.txthortare.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortare.Location = new System.Drawing.Point(128, 175);
            this.txthortare.Name = "txthortare";
            this.txthortare.Size = new System.Drawing.Size(135, 20);
            this.txthortare.TabIndex = 39;
            // 
            // lbhortare
            // 
            this.lbhortare.AutoSize = true;
            this.lbhortare.Location = new System.Drawing.Point(12, 180);
            this.lbhortare.Name = "lbhortare";
            this.lbhortare.Size = new System.Drawing.Size(105, 13);
            this.lbhortare.TabIndex = 38;
            this.lbhortare.Text = "ENTRADA TARDE: ";
            // 
            // txthortars
            // 
            this.txthortars.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortars.Location = new System.Drawing.Point(128, 215);
            this.txthortars.Name = "txthortars";
            this.txthortars.Size = new System.Drawing.Size(135, 20);
            this.txthortars.TabIndex = 41;
            // 
            // lbhortars
            // 
            this.lbhortars.AutoSize = true;
            this.lbhortars.Location = new System.Drawing.Point(32, 220);
            this.lbhortars.Name = "lbhortars";
            this.lbhortars.Size = new System.Drawing.Size(85, 13);
            this.lbhortars.TabIndex = 40;
            this.lbhortars.Text = "SAÍDA TARDE: ";
            // 
            // cbthonome
            // 
            this.cbthonome.FormattingEnabled = true;
            this.cbthonome.Location = new System.Drawing.Point(128, 255);
            this.cbthonome.Name = "cbthonome";
            this.cbthonome.Size = new System.Drawing.Size(135, 21);
            this.cbthonome.TabIndex = 43;
            // 
            // lbthonome
            // 
            this.lbthonome.AutoSize = true;
            this.lbthonome.Location = new System.Drawing.Point(12, 260);
            this.lbthonome.Name = "lbthonome";
            this.lbthonome.Size = new System.Drawing.Size(109, 13);
            this.lbthonome.TabIndex = 42;
            this.lbthonome.Text = "TIPO DE HORÁRIO: ";
            // 
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.cbthonome);
            this.Controls.Add(this.lbthonome);
            this.Controls.Add(this.txthortars);
            this.Controls.Add(this.lbhortars);
            this.Controls.Add(this.txthortare);
            this.Controls.Add(this.lbhortare);
            this.Controls.Add(this.txthormans);
            this.Controls.Add(this.lbhormans);
            this.Controls.Add(this.txthormane);
            this.Controls.Add(this.lbhormane);
            this.Controls.Add(this.txthornome);
            this.Controls.Add(this.lbhornome);
            this.Controls.Add(this.txthorcodi);
            this.Controls.Add(this.lbhorcodi);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Horários";
            this.Load += new System.EventHandler(this.frmhorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txthorcodi;
        private System.Windows.Forms.Label lbhorcodi;
        private System.Windows.Forms.TextBox txthornome;
        private System.Windows.Forms.Label lbhornome;
        private System.Windows.Forms.TextBox txthormane;
        private System.Windows.Forms.Label lbhormane;
        private System.Windows.Forms.TextBox txthormans;
        private System.Windows.Forms.Label lbhormans;
        private System.Windows.Forms.TextBox txthortare;
        private System.Windows.Forms.Label lbhortare;
        private System.Windows.Forms.TextBox txthortars;
        private System.Windows.Forms.Label lbhortars;
        private System.Windows.Forms.ComboBox cbthonome;
        private System.Windows.Forms.Label lbthonome;
    }
}