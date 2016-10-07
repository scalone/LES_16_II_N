using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_15_I_N
{
    public partial class frmcbo : Form
    {
        public frmcbo()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtcbocodi.Clear();
            txtcbonome.Clear();
            txtcbocodi.Focus();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtcbocodi_Leave(object sender, EventArgs e)
        {
            if (txtcbocodi.Text != "")
            {
                string strConsulta = "SELECT CBONOME FROM CBO WHERE CBOCODI = '" + txtcbocodi.Text + "'";
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
                        txtcbonome.Text = dr["CBONOME"].ToString();
                        txtcbonome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("CBO não encontrada \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtcbonome.Text = "";
                            txtcbonome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Conexao.Active(false);
            }
        }

        private void btincluir_Click(object sender, EventArgs e)
        {
            if (txtcbonome.Text != "")
            {
                string strInclui = "INSERT INTO CBO VALUES('" + txtcbocodi.Text + "', '" + txtcbonome.Text + "')";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtcbocodi.Focus();
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
            if (txtcbonome.Text != "")
            {
                string strAtualiza = "UPDATE CBO SET CBONOME = '" + txtcbonome.Text + "' WHERE CBOCODI = '" + txtcbocodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtcbocodi.Focus();
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    btexcluir.Enabled = false;
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
            if (txtcbonome.Text != "")
            {
                string strExclui = "DELETE FROM CBO WHERE CBOCODI = '" + txtcbocodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                    txtcbocodi.Focus();
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    btexcluir.Enabled = false;
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
