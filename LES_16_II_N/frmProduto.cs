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
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtprocodi.Clear();
            txtpronome.Clear();
            txtprocust.Clear();
            txtpromarg.Clear();
            txtprovend.Clear();
            txtproesto.Clear();
            txtproloca.Clear();
            txtproobs.Clear();
            txtprocodi.Focus();
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtprocodi_Leave(object sender, EventArgs e)
        {
            if (txtprocodi.Text != "")
            {
                string strConsulta = "SELECT * FROM PRODUTO WHERE PROCODI = '" + txtprocodi.Text + "'";
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
                        txtprocodi.Text = dr["PROCODI"].ToString();
                        txtpronome.Text = dr["PRONOME"].ToString();
                        txtprocust.Text = dr["PROCUST"].ToString();
                        txtpromarg.Text = dr["PROMARG"].ToString();
                        txtprovend.Text = dr["PROVEND"].ToString();
                        txtproesto.Text = dr["PROESTO"].ToString();
                        txtproloca.Text = dr["PROLOCA"].ToString();
                        txtproobs.Text = dr["PROOBS"].ToString();
                        txtprovend.Focus();
                        int i = 0;

                        for (i = 0; i < cbgrunome.Items.Count; i++)
                        {
                            this.cbgrunome.SelectedIndex = i;

                            if (this.cbgrunome.SelectedValue.ToString() == dr["GRUPOCODI"].ToString())
                            {
                                int j = 0;

                                for (j = 0; j < cbuninome.Items.Count; j++)
                                {
                                    this.cbuninome.SelectedIndex = j;

                                    if (this.cbuninome.SelectedValue.ToString() == dr["UNICODI"].ToString())
                                    {
                                        return;
                                    }
                                }
                                MessageBox.Show("Unidade não encontrada!");
                                this.cbuninome.SelectedIndex = 0;
                                txtprocodi.Focus();
                                return;
                            }
                        }
                        MessageBox.Show("Grupo não encontrado!");
                        this.cbgrunome.SelectedIndex = 0;
                        txtprocodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Produto não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtpronome.Text = "";
                            txtprocust.Text = "";
                            txtpromarg.Text = "";
                            txtprovend.Text = "";
                            txtproesto.Text = "";
                            txtproloca.Text = "";
                            txtproobs.Text = "";
                            cbgrunome.SelectedIndex = 0;
                            cbuninome.SelectedIndex = 0;
                            txtpronome.Focus();
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

        private void btincluir_Click(object sender, EventArgs e)
        {
            if (txtpronome.Text != "")
            {
                string strIncluir = 
                    "INSERT INTO PRODUTO VALUES('" + txtprocodi.Text + "', '" + txtpronome.Text +
                    "', " + txtprocust.Text + ", " + txtpromarg.Text + ", " + txtprovend.Text +
                    ", " + txtproesto.Text + ", '" + txtproloca.Text + "', '" + txtproobs.Text + 
                    "', '" + cbgrunome.SelectedValue.ToString() + "', '" + cbuninome.SelectedValue.ToString() + " ')";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtprocodi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM GRUPO";

            cbgrunome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["GRUNOME"].ToString(), Convert.ToInt32(dr["GRUPOCODI"]));
                }
                this.cbgrunome.DataSource = new BindingSource(dict, null);
                this.cbgrunome.DisplayMember = "key";
                this.cbgrunome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            strConsulta = "SELECT * FROM UNIDADE";

            cbuninome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["UNINOME"].ToString(), Convert.ToInt32(dr["UNICODI"]));
                }
                this.cbuninome.DataSource = new BindingSource(dict, null);
                this.cbuninome.DisplayMember = "key";
                this.cbuninome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (txtpronome.Text != "")
            {
                string strExclui = "DELETE FROM PRODUTO WHERE PROCODI = '" + txtprocodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                    txtprocodi.Focus();
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    btexcluir.Enabled = false;
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
            if (txtpronome.Text != "")
            {
                string strAtualiza = "UPDATE PRODUTO SET PRONOME = '" + txtpronome.Text +
                    "', PROCUST = '" + txtprocust.Text + "', PROMARG = '" + txtpromarg.Text + "', PROVEND = '" + txtprovend.Text +
                    "', PROESTO = '" + txtproesto.Text + "', PROLOCA = '" + txtproloca.Text + "', PROOBS = '" + txtproobs.Text +
                    "', GRUPOCODI = '" + cbgrunome.SelectedValue.ToString() + "', UNICODI = '" + cbuninome.SelectedValue.ToString() +
                    "' WHERE PROCODI = '" + txtprocodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtprocodi.Focus();
                    btincluir.Enabled = true;
                    btgravar.Enabled = false;
                    btexcluir.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }
    }
}
