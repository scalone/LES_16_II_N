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
    public partial class frmbairro : Form
    {
        public frmbairro()
        {
            InitializeComponent();
        }

        private void btincluir_Click(object sender, EventArgs e)
        {
            Conexao.Active(true);

            string strIncluir =
                "INSERT INTO BAIRRO " +
                "VALUES(" + "'" + txtbaicodi.Text + "', '" + txtbainome.Text + "', '" + cbmunnome.SelectedValue.ToString() + "'" + " )";

            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            if (txtbainome.Text != "")
            {
                string strAtualiza =
                "UPDATE MUNICIPIO SET MUNNOME = '" + txtbainome.Text +
                "', ESTCODI = " + cbmunnome.SelectedValue.ToString() + " WHERE ESTCODI = " + txtbaicodi.Text + "";

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtbaicodi.Focus();
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
            string strDelete = "DELETE FROM BAIRRO WHERE BAICODI = '" + txtbaicodi.Text + "' ";
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limpar();
                txtbaicodi.Focus();
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

        private void frmbairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void limpar()
        {
            txtbaicodi.Clear();
            txtbainome.Clear();
            cbmunnome.SelectedIndex = 0;
            txtbaicodi.Focus();
        }

        private void txtbaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);

            if (txtbaicodi.Text != "")
            {
                string strConsulta =
                    "SELECT BAICODI, BAINOME, MUNCODI FROM BAIRRO WHERE BAICODI = '" + txtbaicodi.Text + "'";

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        btincluir.Enabled = false;
                        btgravar.Enabled = true;
                        btexcluir.Enabled = true;
                        txtbainome.Text = dr["BAINOME"].ToString();
                        int i = 0;

                        for (i = 0; i < cbmunnome.Items.Count; i++)
                        {
                            this.cbmunnome.SelectedIndex = i;

                            if (this.cbmunnome.SelectedValue.ToString() == dr["MUNCODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("Bairro não encontrado!");
                        this.cbmunnome.SelectedIndex = 0;
                        txtbaicodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Bairro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtbainome.Text = "";
                            cbmunnome.SelectedIndex = 0;
                            txtbainome.Focus();
                        }
                    }
                }
                catch(Exception ex)
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

        private void frmbairro_Load(object sender, EventArgs e)
        {
            string strCarrega = "SELECT * FROM MUNICIPIO";

            cbmunnome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strCarrega, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string,int>();

                while (dr.Read())
                {
                    dict.Add(dr["MUNNOME"].ToString(), Convert.ToInt32(dr["MUNCODI"]));
                }
                this.cbmunnome.DataSource = new BindingSource(dict, null);
                this.cbmunnome.DisplayMember = "key";
                this.cbmunnome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }
    }
}
