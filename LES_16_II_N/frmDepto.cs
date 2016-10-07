using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_15_II_N
{
    public partial class frmdepto : Form
    {
        public frmdepto()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtdepcodi.Clear();
            txtdepnome.Clear();
            txtdepcodi.Focus();
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtdepcodi_Leave(object sender, EventArgs e)
        {
            if (txtdepcodi.Text != "")
            {
                string strConsulta = "SELECT DEPNOME FROM DEPTO WHERE DEPCODI = '" + txtdepcodi.Text + "'";

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
                        txtdepnome.Text = dr["DEPNOME"].ToString();
                        txtdepnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Departamento não encontrado \n deseja cadastra-lo?", "Cadastro", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtdepnome.Text = "";
                            txtdepnome.Focus();
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
            if (txtdepnome.Text != "")
            {
                string strIncluir = "INSERT INTO DEPTO VALUES('"+ txtdepcodi.Text +"', '" + txtdepnome.Text + "')";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtdepcodi.Focus();
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
            if (txtdepnome.Text != "")
            {
                string strAtualiza =
                        "UPDATE DEPTO SET DEPNOME = '" + txtdepnome.Text + "' WHERE DEPCODI = '" + txtdepcodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtdepcodi.Focus();
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
            if (txtdepnome.Text != "")
            {
                string strExclui = "DELETE FROM DEPTO WHERE DEPCODI = '" + txtdepcodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    limpar();
                    txtdepcodi.Focus();
                    btexcluir.Enabled = false;
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    MessageBox.Show("Registro excluído com sucesso!");
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
