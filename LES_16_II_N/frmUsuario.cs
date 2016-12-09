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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtusocodi.Clear();
            txtusonome.Clear();
            txtusobloq.Clear();
            txtusodata.Clear();
            txtusonivel.Clear();
            txtusoqtde.Clear();
            txtusosenha.Clear();
            txtusocodi.Focus();
        }

        private void txtusocodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtusocodi_Leave(sender, e);
            }
        }

        private void txtusocodi_Leave(object sender, EventArgs e)
        {
            if (txtusocodi.Text != "")
            {
                string strConsulta = "SELECT * FROM USUARIO WHERE FUNCODI = '" + txtusocodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        btincluir.Enabled = false;
                        btgravar.Enabled = true;
                        btexcluir.Enabled = true;

                        txtusonome.Text = dr["USONOME"].ToString();
                        txtusonivel.Text = dr["USONIVEL"].ToString();
                        txtusodata.Text = dr["USODATA"].ToString();
                        txtusoqtde.Text = dr["USOQTDE"].ToString();
                        txtusobloq.Text = dr["USOBLOQ"].ToString();
                    }
                    else
                    {
                        if ((MessageBox.Show("Usuário não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtusonome.Text = "";
                            txtusosenha.Text = "";
                            txtusonivel.Text = "";
                            txtusodata.Text = "";
                            txtusoqtde.Text = "";
                            txtusobloq.Text = "";
                            txtusonome.Focus();
                        }
                    }
                    Conexao.Active(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btincluir_Click(object sender, EventArgs e)
        {
            if (txtusonome.Text != "")
            {
                string strInclui = "INSERT INTO USUARIO VALUES(" + txtusocodi.Text + ", '" + txtusonome.Text +
                    "', '" + txtusosenha.Text + "', " + txtusonivel.Text + ", '" + txtusodata.Text +
                    "', '" + txtusoqtde.Text + "', '" + txtusobloq.Text + "')";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Conexao.Active(false);
            }
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            if (txtusonome.Text != "")
            {
                string strAtualiza = "UPDATE USUARIO SET USONOME = '" + txtusonome.Text + "', " +
                    "USOSENHA = '" + txtusosenha.Text + "', " +
                    "USONIVEL = '" + txtusonivel.Text + "', " +
                    "USODATA = '" + txtusodata.Text + "', " +
                    "USOQTDE = '" + txtusoqtde.Text + "', " +
                    "USOBLOQ = '" + txtusobloq.Text + "' " +
                    "WHERE FUNCODI = '" + txtusocodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Conexao.Active(false);
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (txtusonome.Text != "")
            {
                string strExclui = "DELETE FROM USUARIO WHERE FUNCODI = '" + txtusocodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    btexcluir.Enabled = false;
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Conexao.Active(false);
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
