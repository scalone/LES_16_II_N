using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_16_II_N
{
    public partial class frmvenda : Form
    {
        int items = 1;
        float total_pedido = 0;
        float total_desc = 0;
        float valor_desc = 0;
        float valor_liquido = 0;

        public frmvenda()
        {
            InitializeComponent();
        }

        private void txtpedcodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            
            if (txtpedcodi.Text != "")
            {
                string strConsulta = 
                    "SELECT PE.PEDCODI, PE.PEDDTEM, PE.PEDCOND, PE.PEDDTBA, PE.CLICODI, PE.FUNCODI, PE.PEDOBS, PE.PEDTOTA, PE.PEDPERC, PE.PEDDESC, PE.PEDLIQU, C.CLINOME, F.FUNNOME FROM PEDIDO PE "
                    + "INNER JOIN CLIENTE C ON C.CLICODI = PE.CLICODI "
                    + "INNER JOIN FUNCIONARIO F ON F.FUNCODI = PE.FUNCODI " + "WHERE PE.PEDCODI =" + txtpedcodi.Text;
                
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaPed(dr);
                        txtpedcond.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Pedido não encontrado \n deseja cadastra-lo?", "Cadastro",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            txtpedcond.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void frmvendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void limpar()
        {
            txtpedcodi.Clear();
            txtpedcond.Clear();
            txtclicodi.Clear();
            txtfuncodi.Clear();
            txtpedobs.Clear();
            txtpedcodi.Focus();
        }

        private void ConsultaPed(FbDataReader dr)
        {
            txtpedcodi.Text = dr["PEDCODI"].ToString();
            txtpedcond.Text = dr["PEDCOND"].ToString();
            txtclicodi.Text = dr["CLINOME"].ToString();
            txtpedobs.Text = dr["PEDOBS"].ToString();
            string strSelect = 
                "SELECT I.ITECODI, I.PROCODI, I.ITEQTDE, "
                + "I.ITEVALO, I.ITETOTA, P.PRONOME FROM PEDIDO_ITEM I "
                + "INNER JOIN PRODUTO P ON I.PROCODI = P.PROCODI "
                + "WHERE I.PEDCODI =" + txtpedcodi.Text;
            
            Conexao.Active(true);

            try
            {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(strSelect, Conexao.FbCnn);
                
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    dgvitems.DataSource = dt;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void txtitecodi_Leave(object sender, EventArgs e)
        {
            if (txtitecodi.Text != "")
            {
                string strConsulta = "SELECT * FROM PRODUTO WHERE PROCODI = " + txtitecodi.Text;

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtpronome.Text = dr["PRONOME"].ToString();
                        txtitevalo.Text = dr["PROVEND"].ToString();
                        txtiteqtde.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else
            {
                if ((MessageBox.Show("Deseja incluir mais itens?", "Itens",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    string strIncluir = 
                        "INSERT INTO PEDIDO VALUES('" + txtpedcodi.Text + "', '" + txtdtped.Text + "', '" + txtdtped.Text + "', " + txtpedtota.Text + ", " + txtpedperc.Text +
                        ", " + txtpeddesc.Text + ", " + txtpedliqu.Text + ", '" + txtpedobs.Text + "', '" + txtpedcond.Text + "', '" + txtfuncodi.Text + "', '" + txtclicodi.Text + "')";

                    MessageBox.Show(strIncluir);

                    Conexao.Active(true);

                    try
                    {
                        FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pedido realizado com sucesso!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Conexao.Active(false);
                }
            }
        }

        private void txtclicodi_Leave(object sender, EventArgs e)
        {
            string strConsulta = "SELECT CLINOME FROM CLIENTE WHERE CLICODI = " + txtclicodi.Text;

            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtclinome.Text = dr["CLINOME"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void txtfuncodi_Leave(object sender, EventArgs e)
        {
            string strConsulta = "SELECT FUNNOME FROM FUNCIONARIO WHERE FUNCODI = " + txtfuncodi.Text;

            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtfunnome.Text = dr["FUNNOME"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void txtiteqtde_Leave(object sender, EventArgs e)
        {
            if (txtitecodi.Text != "" && txtiteqtde.Text != "")
            {

                if ((MessageBox.Show("Deseja incluir o item no carrinho?", "PRODUTOS",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    string strIncluir =
                            "INSERT INTO PEDIDO_ITEM VALUES('" + txtpedcodi.Text + "', '" + items.ToString() + "', '" + txtitecodi.Text +
                            "', '" + txtiteqtde.Text + "', '" + txtitevalo.Text + "', '" + (Convert.ToInt32(txtiteqtde.Text) * Convert.ToInt32(txtitevalo.Text)).ToString() +
                            "', 'NADA DE OBS')";

                    txtitetota.Text = (Convert.ToInt32(txtiteqtde.Text) * Convert.ToInt32(txtitevalo.Text)).ToString();
                    total_pedido += Convert.ToInt32(txtitetota.Text);
                    txtpedtota.Text = total_pedido.ToString();

                    if (txtpedperc.Text == "")
                    {
                        total_desc = 0;
                        txtpedperc.Text = total_desc.ToString();
                    }
                    else total_desc = Convert.ToInt32(txtpedperc.Text);

                    txtpeddesc.Text = (total_pedido * total_desc).ToString();

                    valor_liquido = (total_pedido - Convert.ToInt32(txtpeddesc.Text));
                    txtpedliqu.Text = valor_liquido.ToString();

                    Conexao.Active(true);

                    try
                    {
                        FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                        cmd.ExecuteNonQuery();
                        items++;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Conexao.Active(false);
                }
                string strSelect =
                "SELECT I.ITECODI, I.PROCODI, I.ITEQTDE, "
                + "I.ITEVALO, I.ITETOTA, P.PRONOME FROM PEDIDO_ITEM I "
                + "INNER JOIN PRODUTO P ON I.PROCODI = P.PROCODI "
                + "WHERE I.PEDCODI =" + txtpedcodi.Text;

                Conexao.Active(true);

                try
                {
                    DataTable dt = new DataTable();
                    FbDataAdapter da = new FbDataAdapter(strSelect, Conexao.FbCnn);

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        this.dgvitems.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }
    }
}
