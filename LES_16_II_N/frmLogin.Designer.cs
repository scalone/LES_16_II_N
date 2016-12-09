namespace LES_16_II_N
{
    partial class frmLogin
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
            this.txtusunome = new System.Windows.Forms.TextBox();
            this.lbusunome = new System.Windows.Forms.Label();
            this.txtususenha = new System.Windows.Forms.TextBox();
            this.lbususenha = new System.Windows.Forms.Label();
            this.btsair = new System.Windows.Forms.Button();
            this.btentrar = new System.Windows.Forms.Button();
            this.ckmostrasenha = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusunome
            // 
            this.txtusunome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusunome.Location = new System.Drawing.Point(98, 190);
            this.txtusunome.Name = "txtusunome";
            this.txtusunome.Size = new System.Drawing.Size(200, 20);
            this.txtusunome.TabIndex = 59;
            // 
            // lbusunome
            // 
            this.lbusunome.AutoSize = true;
            this.lbusunome.Location = new System.Drawing.Point(172, 163);
            this.lbusunome.Name = "lbusunome";
            this.lbusunome.Size = new System.Drawing.Size(39, 13);
            this.lbusunome.TabIndex = 58;
            this.lbusunome.Text = "NOME";
            // 
            // txtususenha
            // 
            this.txtususenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtususenha.Location = new System.Drawing.Point(98, 254);
            this.txtususenha.Name = "txtususenha";
            this.txtususenha.PasswordChar = '*';
            this.txtususenha.Size = new System.Drawing.Size(200, 20);
            this.txtususenha.TabIndex = 61;
            // 
            // lbususenha
            // 
            this.lbususenha.AutoSize = true;
            this.lbususenha.Location = new System.Drawing.Point(172, 227);
            this.lbususenha.Name = "lbususenha";
            this.lbususenha.Size = new System.Drawing.Size(44, 13);
            this.lbususenha.TabIndex = 60;
            this.lbususenha.Text = "SENHA";
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(308, 338);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 63;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btentrar
            // 
            this.btentrar.Location = new System.Drawing.Point(8, 338);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(75, 23);
            this.btentrar.TabIndex = 62;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = true;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // ckmostrasenha
            // 
            this.ckmostrasenha.AutoSize = true;
            this.ckmostrasenha.Location = new System.Drawing.Point(152, 281);
            this.ckmostrasenha.Name = "ckmostrasenha";
            this.ckmostrasenha.Size = new System.Drawing.Size(95, 17);
            this.ckmostrasenha.TabIndex = 64;
            this.ckmostrasenha.Text = "Mostrar Senha";
            this.ckmostrasenha.UseVisualStyleBackColor = true;
            this.ckmostrasenha.CheckedChanged += new System.EventHandler(this.ckmostrasenha_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LES_16_II_N.Properties.Resources.Administracao;
            this.pictureBox1.Location = new System.Drawing.Point(115, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckmostrasenha);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.txtususenha);
            this.Controls.Add(this.lbususenha);
            this.Controls.Add(this.txtusunome);
            this.Controls.Add(this.lbusunome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusunome;
        private System.Windows.Forms.Label lbusunome;
        private System.Windows.Forms.TextBox txtususenha;
        private System.Windows.Forms.Label lbususenha;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btentrar;
        private System.Windows.Forms.CheckBox ckmostrasenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}