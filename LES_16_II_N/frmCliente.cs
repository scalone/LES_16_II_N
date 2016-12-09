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
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtclicodi.Clear();
            txtclinome.Clear();
            txtclifant.Clear();
            txtcliapel.Clear();
            txtclilimi.Clear();
            txtclidtin.Clear();
            txtclicnpj.Clear();
            txtcliines.Clear();
            txtcliemai.Clear();
            txtclifone.Clear();
            txtclicelu.Clear();
            txtclicel1.Clear();
            txtclinume.Clear();
            txtclistat.Clear();
            cbramnome.SelectedIndex = 0;
            txtclicodi.Focus();
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtclicodi_Leave(object sender, EventArgs e)
        {
            if (txtclicodi.Text != "")
            {
                string strConsulta = "SELECT * FROM CLIENTE WHERE CLICODI = '" + txtclicodi.Text + "'";
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

                        txtclinome.Text = dr["CLINOME"].ToString();
                        txtclifant.Text = dr["CLIFANT"].ToString();
                        txtcliapel.Text = dr["CLIAPEL"].ToString();
                        txtclilimi.Text = dr["CLILIMI"].ToString();
                        txtclidtin.Text = dr["CLIDTIN"].ToString();
                        txtclicnpj.Text = dr["CLICNPJ"].ToString();
                        txtcliines.Text = dr["CLIINES"].ToString();
                        txtcliemai.Text = dr["CLIEMAI"].ToString();
                        txtclifone.Text = dr["CLIFONE"].ToString();
                        txtclicelu.Text = dr["CLICELU"].ToString();
                        txtclicel1.Text = dr["CLICEL1"].ToString();
                        txtclinume.Text = dr["CLINUME"].ToString();
                        txtclistat.Text = dr["CLISTAT"].ToString();
                        cbramnome.SelectedIndex = 0;
                        txtclinome.Focus();
                        int i = 0;

                        for (i = 0; i < cbramnome.Items.Count; i++)
                        {
                            this.cbramnome.SelectedIndex = i;

                            if (this.cbramnome.SelectedValue.ToString() == dr["RAMOCODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("Ramo não encontrado!");
                        this.cbramnome.SelectedIndex = 0;
                        txtclicodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Cliente não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtclinome.Text = "";
                            txtclifant.Text = "";
                            txtcliapel.Text = "";
                            txtclilimi.Text = "";
                            txtclidtin.Text = "";
                            txtclicnpj.Text = "";
                            txtcliines.Text = "";
                            txtcliemai.Text = "";
                            txtclifone.Text = "";
                            txtclicelu.Text = "";
                            txtclicel1.Text = "";
                            txtclinume.Text = "";
                            txtclistat.Text = "";
                            cbramnome.SelectedIndex = 0;
                            txtclinome.Focus();
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
            if (txtclinome.Text != "")
            {
                string strIncluir =
                    "INSERT INTO CLIENTE VALUES('" + txtclicodi.Text + "', '" + txtclinome.Text +
                    "', '" + txtclifant.Text + "', '" + txtcliapel.Text + "', '" + txtclilimi.Text +
                    "', '" + txtclidtin.Text + "', '" + txtclicnpj.Text + "', '" + txtcliines.Text +
                    "', '" + txtcliemai.Text + "', '" + txtclifone.Text + "', '" + txtclicelu.Text +
                    "', '" + txtclicel1.Text + "', '" + txtclinume.Text + "', '" + txtclistat.Text +
                    "', " + cbramnome.SelectedValue.ToString() + ", '" + cbendereco.SelectedValue.ToString() + "' );";
                MessageBox.Show(strIncluir);
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtclicodi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM RAMO";

            cbramnome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["RAMNOME"].ToString(), Convert.ToInt32(dr["RAMOCODI"]));
                }
                this.cbramnome.DataSource = new BindingSource(dict, null);
                this.cbramnome.DisplayMember = "key";
                this.cbramnome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            strConsulta = "SELECT * FROM ENDERECO";
            cbendereco.Items.Clear();

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> dict = new Dictionary<string, string>();

                while (dr.Read())
                {
                    dict.Add(dr["ENDENDE"].ToString(), dr["ENDCEP"].ToString());
                }
                this.cbendereco.DataSource = new BindingSource(dict, null);
                this.cbendereco.DisplayMember = "key";
                this.cbendereco.ValueMember = "value";
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
            if (txtclinome.Text != "")
            {
                string strExclui = "DELETE FROM CLIENTE WHERE CLICODI = '" + txtclicodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                    txtclicodi.Focus();
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
            if (txtclinome.Text != "")
            {
                string strAtualiza = "UPDATE CLIENTE SET CLINOME = '" + txtclinome.Text +
                    "', CLIFANT = '" + txtclifant.Text + "', CLIAPEL = '" + txtcliapel.Text + "', CLILIMI = '" + txtclilimi.Text +
                    "', CLIDTIN = '" + txtclidtin.Text + "', CLICNPJ = '" + txtclicnpj.Text + "', CLIINES = '" + txtcliines.Text +
                    "', CLIEMAI = '" + txtcliemai.Text + "', CLIFONE = '" + txtclifone.Text + "', CLICELU = '" + txtclicelu.Text +
                    "', CLICEL1 = '" + txtclicel1.Text + "', CLINUME = '" + txtclinume.Text + "', CLISTAT = '" + txtclistat.Text +
                    "', RAMOCODI = '" + cbramnome.SelectedValue.ToString() + "', ENDCEP = '" + cbendereco.SelectedValue.ToString() +
                    "' WHERE CLICODI = '" + txtclicodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtclicodi.Focus();
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

        private void cbramnome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
