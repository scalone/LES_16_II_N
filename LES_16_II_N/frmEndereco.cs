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
    public partial class frmendereco : Form
    {
        public frmendereco()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtendcep.Clear();
            txtendende.Clear();
            cbbainome.SelectedIndex = 0;
            txtendcep.Focus();
        }

        private void txtendcep_Leave(object sender, EventArgs e)
        {
            string temp = txtendcep.Text;

            Conexao.Active(true);

            if (txtendcep.Text != "     -") // 5 espaços em branco + traço
            {
                string strConsulta =
                    "SELECT ENDCEP, ENDENDE, BAICODI FROM ENDERECO WHERE ENDCEP = '" + txtendcep.Text + "'";

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        btincluir.Enabled = false;
                        btgravar.Enabled = true;
                        btexcluir.Enabled = true;
                        txtendcep.Text = dr["ENDCEP"].ToString();
                        txtendende.Text = dr["ENDENDE"].ToString();
                        int i = 0;

                        for (i = 0; i < cbbainome.Items.Count; i++)
                        {
                            cbbainome.SelectedIndex = i;

                            if (cbbainome.SelectedValue.ToString() == dr["BAICODI"].ToString())
                            {
                                return;
                            }
                        }
                        txtendende.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Endereço não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtendende.Text = "";
                            cbbainome.SelectedIndex = 0;
                            txtendende.Focus();
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
            Conexao.Active(true);

            if (txtendende.Text != "")
            {
                string strIncluir =
                "INSERT INTO ENDERECO " +
                "VALUES(" + "'" + txtendcep.Text + "', '" + txtendende.Text + "', '" + cbbainome.SelectedValue.ToString() + "'" + " )";

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    limpar();
                    txtendcep.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Conexao.Active(false);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM ENDERECO WHERE ENDCEP = '" + txtendcep.Text + "' ";

            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limpar();
                txtendcep.Focus();
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

        private void frmEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEndereco_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM BAIRRO";

            cbbainome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["BAINOME"].ToString(), Convert.ToInt32(dr["BAICODI"]));
                }
                this.cbbainome.DataSource = new BindingSource(dict, null);
                this.cbbainome.DisplayMember = "key";
                this.cbbainome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            Conexao.Active(true);

            if (txtendende.Text != "")
            {
                string strAtualiza =
                "UPDATE ENDERECO SET ENDENDE = '" + txtendende.Text +
                "', BAICODI = '" + cbbainome.SelectedValue.ToString() + "' WHERE ENDCEP = '" + txtendcep.Text + "'";

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtendcep.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Conexao.Active(false);
        }
    }
}
