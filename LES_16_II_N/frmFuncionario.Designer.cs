namespace LES_16_II_N
{
    partial class frmfuncionario
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
            this.txtfuncodi = new System.Windows.Forms.TextBox();
            this.lbfuncodi = new System.Windows.Forms.Label();
            this.cbfucnome = new System.Windows.Forms.ComboBox();
            this.lbfucnome = new System.Windows.Forms.Label();
            this.cbdeptonome = new System.Windows.Forms.ComboBox();
            this.lbdeptonome = new System.Windows.Forms.Label();
            this.cbendende = new System.Windows.Forms.ComboBox();
            this.lbendende = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btgravar = new System.Windows.Forms.Button();
            this.btincluir = new System.Windows.Forms.Button();
            this.txtfunnome = new System.Windows.Forms.TextBox();
            this.lbfunnome = new System.Windows.Forms.Label();
            this.txtfunsala = new System.Windows.Forms.TextBox();
            this.lbfunsala = new System.Windows.Forms.Label();
            this.txtfundtna = new System.Windows.Forms.TextBox();
            this.lbfundtna = new System.Windows.Forms.Label();
            this.txtfuncpf = new System.Windows.Forms.TextBox();
            this.lbfuncpf = new System.Windows.Forms.Label();
            this.txtfunrg = new System.Windows.Forms.TextBox();
            this.lbfunrg = new System.Windows.Forms.Label();
            this.txtfunfone = new System.Windows.Forms.TextBox();
            this.lbfunfone = new System.Windows.Forms.Label();
            this.txtfuncelu = new System.Windows.Forms.TextBox();
            this.lbfuncelu = new System.Windows.Forms.Label();
            this.txtfuncel1 = new System.Windows.Forms.TextBox();
            this.lbfuncel1 = new System.Windows.Forms.Label();
            this.cbestadonome = new System.Windows.Forms.ComboBox();
            this.lbestadonome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfuncodi
            // 
            this.txtfuncodi.Location = new System.Drawing.Point(80, 15);
            this.txtfuncodi.Name = "txtfuncodi";
            this.txtfuncodi.Size = new System.Drawing.Size(103, 20);
            this.txtfuncodi.TabIndex = 35;
            this.txtfuncodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfuncodi_KeyPress);
            this.txtfuncodi.Leave += new System.EventHandler(this.txtfuncodi_Leave);
            // 
            // lbfuncodi
            // 
            this.lbfuncodi.AutoSize = true;
            this.lbfuncodi.Location = new System.Drawing.Point(12, 20);
            this.lbfuncodi.Name = "lbfuncodi";
            this.lbfuncodi.Size = new System.Drawing.Size(55, 13);
            this.lbfuncodi.TabIndex = 34;
            this.lbfuncodi.Text = "CÓDIGO: ";
            // 
            // cbfucnome
            // 
            this.cbfucnome.FormattingEnabled = true;
            this.cbfucnome.Location = new System.Drawing.Point(80, 165);
            this.cbfucnome.Name = "cbfucnome";
            this.cbfucnome.Size = new System.Drawing.Size(290, 21);
            this.cbfucnome.TabIndex = 47;
            // 
            // lbfucnome
            // 
            this.lbfucnome.AutoSize = true;
            this.lbfucnome.Location = new System.Drawing.Point(12, 170);
            this.lbfucnome.Name = "lbfucnome";
            this.lbfucnome.Size = new System.Drawing.Size(57, 13);
            this.lbfucnome.TabIndex = 46;
            this.lbfucnome.Text = "FUNÇÃO: ";
            // 
            // cbdeptonome
            // 
            this.cbdeptonome.FormattingEnabled = true;
            this.cbdeptonome.Location = new System.Drawing.Point(80, 190);
            this.cbdeptonome.Name = "cbdeptonome";
            this.cbdeptonome.Size = new System.Drawing.Size(290, 21);
            this.cbdeptonome.TabIndex = 49;
            // 
            // lbdeptonome
            // 
            this.lbdeptonome.AutoSize = true;
            this.lbdeptonome.Location = new System.Drawing.Point(12, 195);
            this.lbdeptonome.Name = "lbdeptonome";
            this.lbdeptonome.Size = new System.Drawing.Size(50, 13);
            this.lbdeptonome.TabIndex = 48;
            this.lbdeptonome.Text = "DEPTO: ";
            // 
            // cbendende
            // 
            this.cbendende.FormattingEnabled = true;
            this.cbendende.Location = new System.Drawing.Point(80, 215);
            this.cbendende.Name = "cbendende";
            this.cbendende.Size = new System.Drawing.Size(290, 21);
            this.cbendende.TabIndex = 51;
            // 
            // lbendende
            // 
            this.lbendende.AutoSize = true;
            this.lbendende.Location = new System.Drawing.Point(12, 220);
            this.lbendende.Name = "lbendende";
            this.lbendende.Size = new System.Drawing.Size(73, 13);
            this.lbendende.TabIndex = 50;
            this.lbendende.Text = "ENDEREÇO: ";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(308, 338);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 55;
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
            this.btexcluir.TabIndex = 54;
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
            this.btgravar.TabIndex = 53;
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
            this.btincluir.TabIndex = 52;
            this.btincluir.Text = "Incluir";
            this.btincluir.UseVisualStyleBackColor = true;
            this.btincluir.Click += new System.EventHandler(this.btincluir_Click);
            // 
            // txtfunnome
            // 
            this.txtfunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnome.Location = new System.Drawing.Point(80, 40);
            this.txtfunnome.Name = "txtfunnome";
            this.txtfunnome.Size = new System.Drawing.Size(290, 20);
            this.txtfunnome.TabIndex = 57;
            // 
            // lbfunnome
            // 
            this.lbfunnome.AutoSize = true;
            this.lbfunnome.Location = new System.Drawing.Point(12, 45);
            this.lbfunnome.Name = "lbfunnome";
            this.lbfunnome.Size = new System.Drawing.Size(45, 13);
            this.lbfunnome.TabIndex = 56;
            this.lbfunnome.Text = "NOME: ";
            // 
            // txtfunsala
            // 
            this.txtfunsala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunsala.Location = new System.Drawing.Point(80, 65);
            this.txtfunsala.Name = "txtfunsala";
            this.txtfunsala.Size = new System.Drawing.Size(103, 20);
            this.txtfunsala.TabIndex = 59;
            // 
            // lbfunsala
            // 
            this.lbfunsala.AutoSize = true;
            this.lbfunsala.Location = new System.Drawing.Point(12, 70);
            this.lbfunsala.Name = "lbfunsala";
            this.lbfunsala.Size = new System.Drawing.Size(59, 13);
            this.lbfunsala.TabIndex = 58;
            this.lbfunsala.Text = "SALÁRIO: ";
            // 
            // txtfundtna
            // 
            this.txtfundtna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfundtna.Location = new System.Drawing.Point(267, 65);
            this.txtfundtna.Name = "txtfundtna";
            this.txtfundtna.Size = new System.Drawing.Size(103, 20);
            this.txtfundtna.TabIndex = 61;
            // 
            // lbfundtna
            // 
            this.lbfundtna.AutoSize = true;
            this.lbfundtna.Location = new System.Drawing.Point(199, 70);
            this.lbfundtna.Name = "lbfundtna";
            this.lbfundtna.Size = new System.Drawing.Size(42, 13);
            this.lbfundtna.TabIndex = 60;
            this.lbfundtna.Text = "DATA: ";
            // 
            // txtfuncpf
            // 
            this.txtfuncpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncpf.Location = new System.Drawing.Point(80, 90);
            this.txtfuncpf.Name = "txtfuncpf";
            this.txtfuncpf.Size = new System.Drawing.Size(103, 20);
            this.txtfuncpf.TabIndex = 63;
            // 
            // lbfuncpf
            // 
            this.lbfuncpf.AutoSize = true;
            this.lbfuncpf.Location = new System.Drawing.Point(12, 95);
            this.lbfuncpf.Name = "lbfuncpf";
            this.lbfuncpf.Size = new System.Drawing.Size(33, 13);
            this.lbfuncpf.TabIndex = 62;
            this.lbfuncpf.Text = "CPF: ";
            // 
            // txtfunrg
            // 
            this.txtfunrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunrg.Location = new System.Drawing.Point(267, 90);
            this.txtfunrg.Name = "txtfunrg";
            this.txtfunrg.Size = new System.Drawing.Size(103, 20);
            this.txtfunrg.TabIndex = 65;
            // 
            // lbfunrg
            // 
            this.lbfunrg.AutoSize = true;
            this.lbfunrg.Location = new System.Drawing.Point(199, 95);
            this.lbfunrg.Name = "lbfunrg";
            this.lbfunrg.Size = new System.Drawing.Size(29, 13);
            this.lbfunrg.TabIndex = 64;
            this.lbfunrg.Text = "RG: ";
            // 
            // txtfunfone
            // 
            this.txtfunfone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunfone.Location = new System.Drawing.Point(80, 115);
            this.txtfunfone.Name = "txtfunfone";
            this.txtfunfone.Size = new System.Drawing.Size(103, 20);
            this.txtfunfone.TabIndex = 67;
            // 
            // lbfunfone
            // 
            this.lbfunfone.AutoSize = true;
            this.lbfunfone.Location = new System.Drawing.Point(12, 120);
            this.lbfunfone.Name = "lbfunfone";
            this.lbfunfone.Size = new System.Drawing.Size(42, 13);
            this.lbfunfone.TabIndex = 66;
            this.lbfunfone.Text = "FONE: ";
            // 
            // txtfuncelu
            // 
            this.txtfuncelu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncelu.Location = new System.Drawing.Point(267, 115);
            this.txtfuncelu.Name = "txtfuncelu";
            this.txtfuncelu.Size = new System.Drawing.Size(103, 20);
            this.txtfuncelu.TabIndex = 69;
            // 
            // lbfuncelu
            // 
            this.lbfuncelu.AutoSize = true;
            this.lbfuncelu.Location = new System.Drawing.Point(199, 120);
            this.lbfuncelu.Name = "lbfuncelu";
            this.lbfuncelu.Size = new System.Drawing.Size(62, 13);
            this.lbfuncelu.TabIndex = 68;
            this.lbfuncelu.Text = "CELULAR: ";
            // 
            // txtfuncel1
            // 
            this.txtfuncel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncel1.Location = new System.Drawing.Point(267, 140);
            this.txtfuncel1.Name = "txtfuncel1";
            this.txtfuncel1.Size = new System.Drawing.Size(103, 20);
            this.txtfuncel1.TabIndex = 71;
            // 
            // lbfuncel1
            // 
            this.lbfuncel1.AutoSize = true;
            this.lbfuncel1.Location = new System.Drawing.Point(199, 145);
            this.lbfuncel1.Name = "lbfuncel1";
            this.lbfuncel1.Size = new System.Drawing.Size(59, 13);
            this.lbfuncel1.TabIndex = 70;
            this.lbfuncel1.Text = "OUTROS: ";
            // 
            // cbestadonome
            // 
            this.cbestadonome.FormattingEnabled = true;
            this.cbestadonome.Location = new System.Drawing.Point(80, 242);
            this.cbestadonome.Name = "comboBox1";
            this.cbestadonome.Size = new System.Drawing.Size(290, 21);
            this.cbestadonome.TabIndex = 72;
            // 
            // lbestadonome
            // 
            this.lbestadonome.AutoSize = true;
            this.lbestadonome.Location = new System.Drawing.Point(12, 245);
            this.lbestadonome.Name = "label1";
            this.lbestadonome.Size = new System.Drawing.Size(54, 13);
            this.lbestadonome.TabIndex = 73;
            this.lbestadonome.Text = "ESTADO:";
            // 
            // frmfuncionario
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.lbestadonome);
            this.Controls.Add(this.cbestadonome);
            this.Controls.Add(this.txtfuncel1);
            this.Controls.Add(this.lbfuncel1);
            this.Controls.Add(this.txtfuncelu);
            this.Controls.Add(this.lbfuncelu);
            this.Controls.Add(this.txtfunfone);
            this.Controls.Add(this.lbfunfone);
            this.Controls.Add(this.txtfunrg);
            this.Controls.Add(this.lbfunrg);
            this.Controls.Add(this.txtfuncpf);
            this.Controls.Add(this.lbfuncpf);
            this.Controls.Add(this.txtfundtna);
            this.Controls.Add(this.lbfundtna);
            this.Controls.Add(this.txtfunsala);
            this.Controls.Add(this.lbfunsala);
            this.Controls.Add(this.txtfunnome);
            this.Controls.Add(this.lbfunnome);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.btincluir);
            this.Controls.Add(this.cbendende);
            this.Controls.Add(this.lbendende);
            this.Controls.Add(this.cbdeptonome);
            this.Controls.Add(this.lbdeptonome);
            this.Controls.Add(this.cbfucnome);
            this.Controls.Add(this.lbfucnome);
            this.Controls.Add(this.txtfuncodi);
            this.Controls.Add(this.lbfuncodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Funcionários";
            this.Load += new System.EventHandler(this.frmfuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfuncodi;
        private System.Windows.Forms.Label lbfuncodi;
        private System.Windows.Forms.ComboBox cbfucnome;
        private System.Windows.Forms.Label lbfucnome;
        private System.Windows.Forms.ComboBox cbdeptonome;
        private System.Windows.Forms.Label lbdeptonome;
        private System.Windows.Forms.ComboBox cbendende;
        private System.Windows.Forms.Label lbendende;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btincluir;
        private System.Windows.Forms.TextBox txtfunnome;
        private System.Windows.Forms.Label lbfunnome;
        private System.Windows.Forms.TextBox txtfunsala;
        private System.Windows.Forms.Label lbfunsala;
        private System.Windows.Forms.TextBox txtfundtna;
        private System.Windows.Forms.Label lbfundtna;
        private System.Windows.Forms.TextBox txtfuncpf;
        private System.Windows.Forms.Label lbfuncpf;
        private System.Windows.Forms.TextBox txtfunrg;
        private System.Windows.Forms.Label lbfunrg;
        private System.Windows.Forms.TextBox txtfunfone;
        private System.Windows.Forms.Label lbfunfone;
        private System.Windows.Forms.TextBox txtfuncelu;
        private System.Windows.Forms.Label lbfuncelu;
        private System.Windows.Forms.TextBox txtfuncel1;
        private System.Windows.Forms.Label lbfuncel1;
        private System.Windows.Forms.ComboBox cbestadonome;
        private System.Windows.Forms.Label lbestadonome;
    }
}