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
    public partial class frmfuncao : Form
    {
        public frmfuncao()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtfuccodi.Clear();
            txtfucnome.Clear();
            cbcbonome.SelectedIndex = 0;
            txtfuccodi.Focus();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmfuncao_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM CBO";

            cbcbonome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["CBONOME"].ToString(), Convert.ToInt32(dr["CBOCODI"]));
                }
                this.cbcbonome.DataSource = new BindingSource(dict, null);
                this.cbcbonome.DisplayMember = "key";
                this.cbcbonome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Conexao.Active(false);
        }

        private void txtfuccodi_Leave(object sender, EventArgs e)
        {
            if (txtfuccodi.Text != "")
            {
                string strConsulta = "SELECT FUCNOME, CBOCODI FROM FUNCAO WHERE FUCCODI = '" + txtfuccodi.Text + "'";
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
                        txtfucnome.Text = dr["FUCNOME"].ToString();
                        txtfucnome.Focus();
                        int i = 0;

                        for (i = 0; i < this.cbcbonome.Items.Count; i++)
                        {
                            this.cbcbonome.SelectedIndex = i;

                            if (this.cbcbonome.SelectedValue.ToString() == dr["CBOCODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("CBO não encontrado!");
                        this.cbcbonome.SelectedIndex = 0;
                        txtfuccodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Função não encontrada \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtfucnome.Text = "";
                            cbcbonome.SelectedIndex = 0;
                            txtfucnome.Focus();
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
            if (txtfucnome.Text != "")
            {
                string strInclui = 
                    "INSERT INTO FUNCAO VALUES('" + txtfuccodi.Text + "', '" + txtfucnome.Text + "', '" + cbcbonome.SelectedValue.ToString() + "')";

                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtfuccodi.Focus();
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
            if (txtfucnome.Text != "")
            {
                string strAtualiza = 
                    "UPDATE FUNCAO SET FUCNOME = '" + txtfucnome.Text + "', CBOCODI = '" + cbcbonome.SelectedValue.ToString() + "' WHERE FUCCODI = '" + txtfuccodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtfuccodi.Focus();
                    txtfuccodi.Focus();
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
            if (txtfucnome.Text != "")
            {
                string strExclui = "DELETE FROM FUNCAO WHERE FUCCODI = '" + txtfuccodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                    txtfuccodi.Focus();
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
