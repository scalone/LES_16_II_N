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
    public partial class frmtipohorario : Form
    {
        public frmtipohorario()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtthocodi.Clear();
            txtthonome.Clear();
            txtthocodi.Focus();
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtthocodi_Leave(object sender, EventArgs e)
        {
            if (txtthocodi.Text != "")
            {
                string strConsulta = "SELECT THONOME FROM TIPO_HORARIO WHERE THOCODI = '" + txtthocodi.Text + "'";

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
                        txtthonome.Text = dr["THONOME"].ToString();
                        txtthonome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Tipo de Horário não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtthonome.Text = "";
                            txtthonome.Focus();
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
            if (txtthonome.Text != "")
            {
                string strInclui = "INSERT INTO TIPO_HORARIO VALUES('"+ txtthocodi.Text +"', '" + txtthonome.Text + "')";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtthocodi.Focus();
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
            if (txtthonome.Text != "")
            {
                string strAtualiza = 
                    "UPDATE TIPO_HORARIO SET THONOME = '" + txtthonome.Text + "' WHERE THOCODI = '" + txtthocodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtthocodi.Focus();
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
            if (txtthonome.Text != "")
            {
                string strExclui = "DELETE FROM TIPO_HORARIO WHERE THOCODI = '" + txtthocodi.Text + "'";

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
                    txtthocodi.Focus();
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
