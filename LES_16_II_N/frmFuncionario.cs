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
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtfuncodi.Clear();
            txtfunnome.Clear();
            txtfunsala.Clear();
            txtfundtna.Clear();
            txtfuncpf.Clear();
            txtfunrg.Clear();
            txtfunfone.Clear();
            txtfuncelu.Clear();
            txtfuncel1.Clear();
            cbendende.SelectedIndex = 0;
            cbfucnome.SelectedIndex = 0;
            cbdeptonome.SelectedIndex = 0;
            cbestadonome.SelectedIndex = 0;
            txtfuncodi.Focus();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM ENDERECO";

            cbendende.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, string> dict = new Dictionary<string, string>();

                while (dr.Read())
                {
                    dict.Add(dr["ENDENDE"].ToString(), dr["ENDCEP"].ToString());
                }
                this.cbendende.DataSource = new BindingSource(dict, null);
                this.cbendende.DisplayMember = "key";
                this.cbendende.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            strConsulta = "SELECT * FROM DEPTO";
            cbdeptonome.Items.Clear();

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["DEPNOME"].ToString(), Convert.ToInt32(dr["DEPCODI"]));
                }
                this.cbdeptonome.DataSource = new BindingSource(dict, null);
                this.cbdeptonome.DisplayMember = "key";
                this.cbdeptonome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            strConsulta = "SELECT * FROM FUNCAO";
            cbfucnome.Items.Clear();

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["FUCNOME"].ToString(), Convert.ToInt32(dr["FUCCODI"]));
                }
                this.cbfucnome.DataSource = new BindingSource(dict, null);
                this.cbfucnome.DisplayMember = "key";
                this.cbfucnome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            strConsulta = "SELECT * FROM ESTADO";
            cbestadonome.Items.Clear();

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["ESTNOME"].ToString(), Convert.ToInt32(dr["ESTCODI"]));
                }
                this.cbestadonome.DataSource = new BindingSource(dict, null);
                this.cbestadonome.DisplayMember = "key";
                this.cbestadonome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Conexao.Active(false);
        }

        private void txtfuncodi_Leave(object sender, EventArgs e)
        {
            if (txtfuncodi.Text != "")
            {
                //string codi = txtfuncodi.Text;
                //limpar();
                //txtfuncodi.Text = codi;
                
                string strConsulta = 
                    "SELECT FUNNOME, FUNSALA, FUNDTNA, FUNCPF, FUNRG, FUNFONE, FUNCELU, FUNCEL1, ENDCEP, FUCCODI, DEPCODI, ESTCODI FROM FUNCIONARIO WHERE FUNCODI = '" 
                    + txtfuncodi.Text + "'";
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
                        txtfunnome.Text = dr["FUNNOME"].ToString();
                        txtfunsala.Text = dr["FUNSALA"].ToString();
                        txtfundtna.Text = dr["FUNDTNA"].ToString();
                        txtfuncpf.Text = dr["FUNCPF"].ToString();
                        txtfunrg.Text = dr["FUNRG"].ToString();
                        txtfunfone.Text = dr["FUNFONE"].ToString();
                        txtfuncelu.Text = dr["FUNCELU"].ToString();
                        txtfuncel1.Text = dr["FUNCEL1"].ToString();
                        txtfunnome.Focus();
                        int i = 0;

                        for (i = 0; i < cbestadonome.Items.Count; i++)
                        {
                            this.cbestadonome.SelectedIndex = i;
                            if (this.cbestadonome.SelectedValue.ToString() == dr["ESTCODI"].ToString())
                            {
                                break;
                            }
                            else
                            {
                                if (i + 1 >= cbestadonome.Items.Count)
                                {
                                    MessageBox.Show("Estado não encontrada!");
                                    this.cbestadonome.SelectedIndex = 0;
                                    cbestadonome.Focus();
                                }
                            }
                        }

                        for (i = 0; i < cbdeptonome.Items.Count; i++)
                        {
                            this.cbdeptonome.SelectedIndex = i;

                            if (this.cbdeptonome.SelectedValue.ToString() == dr["DEPCODI"].ToString())
                            {
                                break;
                            }
                            else
                            {
                                if (i + 1 >= cbdeptonome.Items.Count)
                                {
                                    MessageBox.Show("Departamento não encontrada! - " + this.cbdeptonome.SelectedValue.ToString());
                                    this.cbdeptonome.SelectedIndex = 0;
                                    cbdeptonome.Focus();
                                }
                            }
                        }

                        for (i = 0; i < cbfucnome.Items.Count; i++)
                        {
                            this.cbfucnome.SelectedIndex = i;
                            if (this.cbfucnome.SelectedValue.ToString() == dr["FUCCODI"].ToString())
                            {
                                break;
                            }
                            else
                            {
                                if (i + 1 >= cbfucnome.Items.Count)
                                {
                                    MessageBox.Show("Função não encontrada!");
                                    this.cbfucnome.SelectedIndex = 0;
                                    cbfucnome.Focus();
                                }
                            }
                        }

                        for (i = 0; i < cbendende.Items.Count; i++)
                        {
                            this.cbendende.SelectedIndex = i;
                            if (this.cbendende.SelectedValue.ToString() == dr["ENDCEP"].ToString())
                            {
                                break;
                            }
                            else
                            {
                                if (i + 1 >= cbendende.Items.Count)
                                {
                                    MessageBox.Show("Endereço não encontrado!");
                                    this.cbendende.SelectedIndex = 0;
                                    cbendende.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Funcionário não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtfunnome.Text = "";
                            cbfucnome.SelectedIndex = 0;
                            cbendende.SelectedIndex = 0;
                            cbdeptonome.SelectedIndex = 0;
                            cbestadonome.SelectedIndex = 0;
                            txtfunnome.Focus();
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
            if (txtfunnome.Text != "")
            {
                string strInclui = 
                    "INSERT INTO FUNCIONARIO VALUES('" + txtfuncodi.Text+ "', '" + txtfunnome.Text + "', '" + txtfunsala.Text+ "', '" 
                    + txtfundtna.Text + "', '" + txtfuncpf.Text + "', '" + txtfunrg.Text + "', '" + txtfunfone.Text + "', '" 
                    + txtfuncelu.Text + "', '" + txtfuncel1.Text + "', '" + cbendende.SelectedValue.ToString() + "', '"
                    + cbfucnome.SelectedValue.ToString() + "', '" + cbdeptonome.SelectedValue.ToString() + "')";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtfuncodi.Focus();
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
            if (txtfunnome.Text != "")
            {
                string strAtualiza = "UPDATE FUNCIONARIO SET FUNNOME = '" + txtfunnome.Text +
                    "', FUNSALA = '" + txtfunsala.Text + "', FUNDTNA = '" + txtfundtna.Text + "', FUNCPF = '" + txtfuncpf.Text +
                    "', FUNRG = '" + txtfunrg.Text + "', FUNFONE = '" + txtfunfone.Text +"', FUNCELU = '" + txtfuncelu.Text +
                    "', FUNCEL1 = '" + txtfuncel1.Text + "', ENDCEP = '" + cbendende.SelectedValue.ToString() +
                    "', DEPCODI = '" + cbdeptonome.SelectedValue.ToString() + "'" + " WHERE FUNCODI = '" + cbfucnome.SelectedValue.ToString() + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtfuncodi.Focus();
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

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (txtfunnome.Text != "")
            {
                string strExclui = "DELETE FROM FUNCIONARIO WHERE FUNCODI = '" + txtfuncodi.Text + "'";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strExclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro excluído com sucesso!");
                    limpar();
                    txtfuncodi.Focus();
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

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfuncodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtfuncodi_Leave(sender, e);
            }
        }
    }
}
