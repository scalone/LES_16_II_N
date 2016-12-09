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
    public partial class frmramo : Form
    {
        public frmramo()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtramcodi.Clear();
            txtramnome.Clear();
            txtramobse.Clear();
            txtramcodi.Focus();
        }

        private void frmramo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtramcodi_Leave(object sender, EventArgs e)
        {
            if (txtramcodi.Text != "")
            {
                string strConsulta = "SELECT * FROM RAMO WHERE RAMCODI = '" + txtramcodi.Text + "'";

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
                        txtramnome.Text = dr["RAMNOME"].ToString();
                        txtramobse.Text = dr["RAMOBSE"].ToString();
                        txtramnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Ramo não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtramnome.Text = "";
                            txtramobse.Text = "";
                            txtramnome.Focus();
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
            if (txtramnome.Text != "")
            {
                string strIncluir = "INSERT INTO RAMO VALUES('" + txtramcodi.Text + "', '" + txtramnome.Text + "', '" + txtramobse.Text + "' )";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtramcodi.Focus();
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
            if (txtramnome.Text != "")
            {
                string strAtualiza = "UPDATE RAMO SET RAMNOME = '" + txtramnome.Text + "', RAMOBSE = '" + txtramobse.Text + "' WHERE RAMCODI = " + txtramcodi.Text + "";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtramcodi.Focus();
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
            if (txtramcodi.Text != "")
            {
                string strDelete = "DELETE FROM RAMO WHERE RAMCODI = '" + txtramcodi.Text + "' ";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    limpar();
                    txtramcodi.Focus();
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
