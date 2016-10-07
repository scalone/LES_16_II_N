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
    public partial class frmpais : Form
    {
        public frmpais()
        {
            InitializeComponent();
        }

        private void btincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO PAIS"
                               + " VALUES("
                               + "'" + txtpaicodi.Text + "', '" + txtpainome.Text + "'"
                               + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                limpar();
                txtpaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso !!!");
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM PAIS WHERE PAICODI = '" + (txtpaicodi.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limpar();
                txtpaicodi.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void frmpais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);

            if (txtpaicodi.Text != "")
            {
                string strConsulta = "SELECT PAICODI, PAINOME FROM PAIS WHERE PAICODI = '" + txtpaicodi.Text + "'";

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        btincluir.Enabled = false;
                        btgravar.Enabled = true;
                        btexcluir.Enabled = true;
                        txtpainome.Text = dr["PAINOME"].ToString();
                        txtpainome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("País não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtpainome.Text = "";
                            txtpainome.Focus();
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

        private void limpar()
        {
            txtpaicodi.Clear();
            txtpainome.Clear();
            txtpaicodi.Focus();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
