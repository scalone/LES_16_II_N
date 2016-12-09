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
    public partial class frmgrupo : Form
    {
        public frmgrupo()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtgrucodi.Clear();
            txtgrunome.Clear();
            txtgrucodi.Focus();
        }

        private void frmgrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtgrucodi_Leave(object sender, EventArgs e)
        {
            if (txtgrucodi.Text != "")
            {
                string strConsulta = "SELECT GRUNOME FROM GRUPO WHERE GRUCODI = '" + txtgrucodi.Text + "'";

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
                        txtgrunome.Text = dr["GRUNOME"].ToString();
                        txtgrunome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Grupo não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtgrunome.Text = "";
                            txtgrunome.Focus();
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

        private void btincluir_Click(object sender, EventArgs e)
        {
            if (txtgrunome.Text != "")
            {
                string strIncluir = "INSERT INTO GRUPO VALUES('" + txtgrucodi.Text + "', '" + txtgrunome.Text + "' )";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtgrucodi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            if (txtgrunome.Text != "")
            {
                string strAtualiza = "UPDATE GRUPO SET GRUNOME = '" + txtgrunome.Text + "' WHERE GRUCODI = " + txtgrucodi.Text + "";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtgrucodi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (txtgrucodi.Text != "")
            {
                string strDelete = "DELETE FROM GRUPO WHERE GRUCODI = '" + txtgrucodi.Text + "' ";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    limpar();
                    txtgrucodi.Focus();
                    btexcluir.Enabled = false;
                    btgravar.Enabled = false;
                    MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
