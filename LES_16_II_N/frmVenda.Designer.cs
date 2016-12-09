namespace LES_16_II_N
{
    partial class frmvenda
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
            this.txtpedcodi = new System.Windows.Forms.TextBox();
            this.lbpedcodi = new System.Windows.Forms.Label();
            this.txtpedcond = new System.Windows.Forms.TextBox();
            this.lbpedcond = new System.Windows.Forms.Label();
            this.txtclicodi = new System.Windows.Forms.TextBox();
            this.lbclinome = new System.Windows.Forms.Label();
            this.txtfuncodi = new System.Windows.Forms.TextBox();
            this.lbfunnome = new System.Windows.Forms.Label();
            this.txtpedobs = new System.Windows.Forms.TextBox();
            this.lbpedobs = new System.Windows.Forms.Label();
            this.txtdtped = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdtba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclinome = new System.Windows.Forms.TextBox();
            this.txtfunnome = new System.Windows.Forms.TextBox();
            this.txtpednum = new System.Windows.Forms.TextBox();
            this.lbitecodi = new System.Windows.Forms.Label();
            this.txtitecodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtiteqtde = new System.Windows.Forms.TextBox();
            this.lbiteqtde = new System.Windows.Forms.Label();
            this.txtitevalo = new System.Windows.Forms.TextBox();
            this.lbvalortotal = new System.Windows.Forms.Label();
            this.txtitetota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvitems = new System.Windows.Forms.DataGridView();
            this.txtpedtota = new System.Windows.Forms.TextBox();
            this.lbpedtota = new System.Windows.Forms.Label();
            this.txtpedperc = new System.Windows.Forms.TextBox();
            this.lbpedperc = new System.Windows.Forms.Label();
            this.txtpeddesc = new System.Windows.Forms.TextBox();
            this.lbpeddesc = new System.Windows.Forms.Label();
            this.txtpedliqu = new System.Windows.Forms.TextBox();
            this.lbpedliqu = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITECODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEVALO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITETOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpedcodi
            // 
            this.txtpedcodi.Location = new System.Drawing.Point(97, 15);
            this.txtpedcodi.Name = "txtpedcodi";
            this.txtpedcodi.Size = new System.Drawing.Size(103, 20);
            this.txtpedcodi.TabIndex = 37;
            this.txtpedcodi.Leave += new System.EventHandler(this.txtpedcodi_Leave);
            // 
            // lbpedcodi
            // 
            this.lbpedcodi.AutoSize = true;
            this.lbpedcodi.Location = new System.Drawing.Point(12, 20);
            this.lbpedcodi.Name = "lbpedcodi";
            this.lbpedcodi.Size = new System.Drawing.Size(54, 13);
            this.lbpedcodi.TabIndex = 36;
            this.lbpedcodi.Text = "PEDIDO: ";
            // 
            // txtpedcond
            // 
            this.txtpedcond.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedcond.Location = new System.Drawing.Point(97, 40);
            this.txtpedcond.Name = "txtpedcond";
            this.txtpedcond.Size = new System.Drawing.Size(103, 20);
            this.txtpedcond.TabIndex = 59;
            // 
            // lbpedcond
            // 
            this.lbpedcond.AutoSize = true;
            this.lbpedcond.Location = new System.Drawing.Point(12, 45);
            this.lbpedcond.Name = "lbpedcond";
            this.lbpedcond.Size = new System.Drawing.Size(87, 13);
            this.lbpedcond.TabIndex = 58;
            this.lbpedcond.Text = "COND. PAGTO: ";
            // 
            // txtclicodi
            // 
            this.txtclicodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclicodi.Location = new System.Drawing.Point(97, 65);
            this.txtclicodi.Name = "txtclicodi";
            this.txtclicodi.Size = new System.Drawing.Size(103, 20);
            this.txtclicodi.TabIndex = 61;
            this.txtclicodi.Leave += new System.EventHandler(this.txtclicodi_Leave);
            // 
            // lbclinome
            // 
            this.lbclinome.AutoSize = true;
            this.lbclinome.Location = new System.Drawing.Point(12, 70);
            this.lbclinome.Name = "lbclinome";
            this.lbclinome.Size = new System.Drawing.Size(58, 13);
            this.lbclinome.TabIndex = 60;
            this.lbclinome.Text = "CLIENTE: ";
            // 
            // txtfuncodi
            // 
            this.txtfuncodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncodi.Location = new System.Drawing.Point(97, 90);
            this.txtfuncodi.Name = "txtfuncodi";
            this.txtfuncodi.Size = new System.Drawing.Size(103, 20);
            this.txtfuncodi.TabIndex = 63;
            this.txtfuncodi.Leave += new System.EventHandler(this.txtfuncodi_Leave);
            // 
            // lbfunnome
            // 
            this.lbfunnome.AutoSize = true;
            this.lbfunnome.Location = new System.Drawing.Point(12, 95);
            this.lbfunnome.Name = "lbfunnome";
            this.lbfunnome.Size = new System.Drawing.Size(71, 13);
            this.lbfunnome.TabIndex = 62;
            this.lbfunnome.Text = "VENDEDOR:";
            // 
            // txtpedobs
            // 
            this.txtpedobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedobs.Location = new System.Drawing.Point(97, 115);
            this.txtpedobs.Name = "txtpedobs";
            this.txtpedobs.Size = new System.Drawing.Size(525, 20);
            this.txtpedobs.TabIndex = 65;
            // 
            // lbpedobs
            // 
            this.lbpedobs.AutoSize = true;
            this.lbpedobs.Location = new System.Drawing.Point(12, 120);
            this.lbpedobs.Name = "lbpedobs";
            this.lbpedobs.Size = new System.Drawing.Size(83, 13);
            this.lbpedobs.TabIndex = 64;
            this.lbpedobs.Text = "OBSERVAÇÃO:";
            // 
            // txtdtped
            // 
            this.txtdtped.Location = new System.Drawing.Point(312, 15);
            this.txtdtped.Name = "txtdtped";
            this.txtdtped.Size = new System.Drawing.Size(103, 20);
            this.txtdtped.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "DATA EMISSÃO:";
            // 
            // txtdtba
            // 
            this.txtdtba.Enabled = false;
            this.txtdtba.Location = new System.Drawing.Point(312, 40);
            this.txtdtba.Name = "txtdtba";
            this.txtdtba.Size = new System.Drawing.Size(103, 20);
            this.txtdtba.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "DATA BAIXA:";
            // 
            // txtclinome
            // 
            this.txtclinome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclinome.Enabled = false;
            this.txtclinome.Location = new System.Drawing.Point(219, 65);
            this.txtclinome.Name = "txtclinome";
            this.txtclinome.Size = new System.Drawing.Size(403, 20);
            this.txtclinome.TabIndex = 70;
            // 
            // txtfunnome
            // 
            this.txtfunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnome.Enabled = false;
            this.txtfunnome.Location = new System.Drawing.Point(219, 90);
            this.txtfunnome.Name = "txtfunnome";
            this.txtfunnome.Size = new System.Drawing.Size(403, 20);
            this.txtfunnome.TabIndex = 71;
            // 
            // txtpednum
            // 
            this.txtpednum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpednum.Enabled = false;
            this.txtpednum.Location = new System.Drawing.Point(12, 165);
            this.txtpednum.Name = "txtpednum";
            this.txtpednum.Size = new System.Drawing.Size(56, 20);
            this.txtpednum.TabIndex = 73;
            // 
            // lbitecodi
            // 
            this.lbitecodi.AutoSize = true;
            this.lbitecodi.Location = new System.Drawing.Point(12, 145);
            this.lbitecodi.Name = "lbitecodi";
            this.lbitecodi.Size = new System.Drawing.Size(36, 13);
            this.lbitecodi.TabIndex = 72;
            this.lbitecodi.Text = "ITEM:";
            // 
            // txtitecodi
            // 
            this.txtitecodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtitecodi.Location = new System.Drawing.Point(97, 165);
            this.txtitecodi.Name = "txtitecodi";
            this.txtitecodi.Size = new System.Drawing.Size(56, 20);
            this.txtitecodi.TabIndex = 75;
            this.txtitecodi.Leave += new System.EventHandler(this.txtitecodi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "CÓDIGO:";
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(171, 165);
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(203, 20);
            this.txtpronome.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "PRODUTO:";
            // 
            // txtiteqtde
            // 
            this.txtiteqtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtiteqtde.Location = new System.Drawing.Point(380, 165);
            this.txtiteqtde.Name = "txtiteqtde";
            this.txtiteqtde.Size = new System.Drawing.Size(56, 20);
            this.txtiteqtde.TabIndex = 79;
            this.txtiteqtde.Leave += new System.EventHandler(this.txtiteqtde_Leave);
            // 
            // lbiteqtde
            // 
            this.lbiteqtde.AutoSize = true;
            this.lbiteqtde.Location = new System.Drawing.Point(380, 145);
            this.lbiteqtde.Name = "lbiteqtde";
            this.lbiteqtde.Size = new System.Drawing.Size(40, 13);
            this.lbiteqtde.TabIndex = 78;
            this.lbiteqtde.Text = "QTDE:";
            // 
            // txtitevalo
            // 
            this.txtitevalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtitevalo.Location = new System.Drawing.Point(442, 165);
            this.txtitevalo.Name = "txtitevalo";
            this.txtitevalo.Size = new System.Drawing.Size(81, 20);
            this.txtitevalo.TabIndex = 81;
            // 
            // lbvalortotal
            // 
            this.lbvalortotal.AutoSize = true;
            this.lbvalortotal.Location = new System.Drawing.Point(442, 145);
            this.lbvalortotal.Name = "lbvalortotal";
            this.lbvalortotal.Size = new System.Drawing.Size(81, 13);
            this.lbvalortotal.TabIndex = 80;
            this.lbvalortotal.Text = "VL. UNITARIO:";
            // 
            // txtitetota
            // 
            this.txtitetota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtitetota.Location = new System.Drawing.Point(529, 165);
            this.txtitetota.Name = "txtitetota";
            this.txtitetota.Size = new System.Drawing.Size(93, 20);
            this.txtitetota.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "TOTAL DO ITEM:";
            // 
            // dgvitems
            // 
            this.dgvitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.ITECODI,
            this.PRONOME,
            this.ITEQTDE,
            this.ITEVALO,
            this.ITETOTA});
            this.dgvitems.Location = new System.Drawing.Point(12, 192);
            this.dgvitems.Name = "dgvitems";
            this.dgvitems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvitems.Size = new System.Drawing.Size(610, 211);
            this.dgvitems.TabIndex = 84;
            // 
            // txtpedtota
            // 
            this.txtpedtota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedtota.Enabled = false;
            this.txtpedtota.Location = new System.Drawing.Point(9, 426);
            this.txtpedtota.Name = "txtpedtota";
            this.txtpedtota.Size = new System.Drawing.Size(84, 20);
            this.txtpedtota.TabIndex = 86;
            // 
            // lbpedtota
            // 
            this.lbpedtota.AutoSize = true;
            this.lbpedtota.Location = new System.Drawing.Point(4, 406);
            this.lbpedtota.Name = "lbpedtota";
            this.lbpedtota.Size = new System.Drawing.Size(89, 13);
            this.lbpedtota.TabIndex = 85;
            this.lbpedtota.Text = "TOTAL PEDIDO:";
            // 
            // txtpedperc
            // 
            this.txtpedperc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedperc.Location = new System.Drawing.Point(131, 426);
            this.txtpedperc.Name = "txtpedperc";
            this.txtpedperc.Size = new System.Drawing.Size(84, 20);
            this.txtpedperc.TabIndex = 88;
            // 
            // lbpedperc
            // 
            this.lbpedperc.AutoSize = true;
            this.lbpedperc.Location = new System.Drawing.Point(126, 406);
            this.lbpedperc.Name = "lbpedperc";
            this.lbpedperc.Size = new System.Drawing.Size(81, 13);
            this.lbpedperc.TabIndex = 87;
            this.lbpedperc.Text = "% DESCONTO:";
            // 
            // txtpeddesc
            // 
            this.txtpeddesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpeddesc.Location = new System.Drawing.Point(255, 426);
            this.txtpeddesc.Name = "txtpeddesc";
            this.txtpeddesc.Size = new System.Drawing.Size(84, 20);
            this.txtpeddesc.TabIndex = 90;
            // 
            // lbpeddesc
            // 
            this.lbpeddesc.AutoSize = true;
            this.lbpeddesc.Location = new System.Drawing.Point(256, 406);
            this.lbpeddesc.Name = "lbpeddesc";
            this.lbpeddesc.Size = new System.Drawing.Size(97, 13);
            this.lbpeddesc.TabIndex = 89;
            this.lbpeddesc.Text = "VLR. DESCONTO:";
            // 
            // txtpedliqu
            // 
            this.txtpedliqu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedliqu.Location = new System.Drawing.Point(379, 426);
            this.txtpedliqu.Name = "txtpedliqu";
            this.txtpedliqu.Size = new System.Drawing.Size(84, 20);
            this.txtpedliqu.TabIndex = 92;
            // 
            // lbpedliqu
            // 
            this.lbpedliqu.AutoSize = true;
            this.lbpedliqu.Location = new System.Drawing.Point(380, 406);
            this.lbpedliqu.Name = "lbpedliqu";
            this.lbpedliqu.Size = new System.Drawing.Size(81, 13);
            this.lbpedliqu.TabIndex = 91;
            this.lbpedliqu.Text = "VLR. LIQUIDO:";
            // 
            // Item
            // 
            this.Item.DataPropertyName = "itecodi";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // ITECODI
            // 
            this.ITECODI.DataPropertyName = "procodi";
            this.ITECODI.HeaderText = "Código";
            this.ITECODI.Name = "ITECODI";
            // 
            // PRONOME
            // 
            this.PRONOME.DataPropertyName = "pronome";
            this.PRONOME.HeaderText = "Nome do Produto";
            this.PRONOME.Name = "PRONOME";
            // 
            // ITEQTDE
            // 
            this.ITEQTDE.DataPropertyName = "iteqtde";
            this.ITEQTDE.HeaderText = "QTDE";
            this.ITEQTDE.Name = "ITEQTDE";
            // 
            // ITEVALO
            // 
            this.ITEVALO.DataPropertyName = "itevalo";
            this.ITEVALO.HeaderText = "Vlr. Unitário";
            this.ITEVALO.Name = "ITEVALO";
            // 
            // ITETOTA
            // 
            this.ITETOTA.DataPropertyName = "itetota";
            this.ITETOTA.HeaderText = "Total Item";
            this.ITETOTA.Name = "ITETOTA";
            // 
            // frmvenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 452);
            this.Controls.Add(this.txtpedliqu);
            this.Controls.Add(this.lbpedliqu);
            this.Controls.Add(this.txtpeddesc);
            this.Controls.Add(this.lbpeddesc);
            this.Controls.Add(this.txtpedperc);
            this.Controls.Add(this.lbpedperc);
            this.Controls.Add(this.txtpedtota);
            this.Controls.Add(this.lbpedtota);
            this.Controls.Add(this.dgvitems);
            this.Controls.Add(this.txtitetota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtitevalo);
            this.Controls.Add(this.lbvalortotal);
            this.Controls.Add(this.txtiteqtde);
            this.Controls.Add(this.lbiteqtde);
            this.Controls.Add(this.txtpronome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtitecodi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpednum);
            this.Controls.Add(this.lbitecodi);
            this.Controls.Add(this.txtfunnome);
            this.Controls.Add(this.txtclinome);
            this.Controls.Add(this.txtdtba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdtped);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpedobs);
            this.Controls.Add(this.lbpedobs);
            this.Controls.Add(this.txtfuncodi);
            this.Controls.Add(this.lbfunnome);
            this.Controls.Add(this.txtclicodi);
            this.Controls.Add(this.lbclinome);
            this.Controls.Add(this.txtpedcond);
            this.Controls.Add(this.lbpedcond);
            this.Controls.Add(this.txtpedcodi);
            this.Controls.Add(this.lbpedcodi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmvenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Vendas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmvendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpedcodi;
        private System.Windows.Forms.Label lbpedcodi;
        private System.Windows.Forms.TextBox txtpedcond;
        private System.Windows.Forms.Label lbpedcond;
        private System.Windows.Forms.TextBox txtclicodi;
        private System.Windows.Forms.Label lbclinome;
        private System.Windows.Forms.TextBox txtfuncodi;
        private System.Windows.Forms.Label lbfunnome;
        private System.Windows.Forms.TextBox txtpedobs;
        private System.Windows.Forms.Label lbpedobs;
        private System.Windows.Forms.TextBox txtdtped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdtba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclinome;
        private System.Windows.Forms.TextBox txtfunnome;
        private System.Windows.Forms.TextBox txtpednum;
        private System.Windows.Forms.Label lbitecodi;
        private System.Windows.Forms.TextBox txtitecodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtiteqtde;
        private System.Windows.Forms.Label lbiteqtde;
        private System.Windows.Forms.TextBox txtitevalo;
        private System.Windows.Forms.Label lbvalortotal;
        private System.Windows.Forms.TextBox txtitetota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvitems;
        private System.Windows.Forms.TextBox txtpedtota;
        private System.Windows.Forms.Label lbpedtota;
        private System.Windows.Forms.TextBox txtpedperc;
        private System.Windows.Forms.Label lbpedperc;
        private System.Windows.Forms.TextBox txtpeddesc;
        private System.Windows.Forms.Label lbpeddesc;
        private System.Windows.Forms.TextBox txtpedliqu;
        private System.Windows.Forms.Label lbpedliqu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITECODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRONOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEVALO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITETOTA;
    }
}