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
    public partial class frmestado : Form
    {
        public frmestado()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtestcodi.Clear();
            txtestuf.Clear();
            txtestnome.Clear();
            txtesticms.Clear();
            cbpaisnome.SelectedIndex = 0;
            txtestcodi.Focus();
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmestado_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM PAIS";

            cbpaisnome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["PAINOME"].ToString(), Convert.ToInt32(dr["PAICODI"]));
                }
                this.cbpaisnome.DataSource = new BindingSource(dict, null);
                this.cbpaisnome.DisplayMember = "key";
                this.cbpaisnome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void txtestcodi_Leave(object sender, EventArgs e)
        {
            if (txtestcodi.Text != "")
            {
                string strConsulta = "SELECT ESTCODI, ESTUF, ESTNOME, ESTICMS, PAICODI FROM ESTADO WHERE ESTCODI = '" + txtestcodi.Text + "'";
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
                        txtestcodi.Text = dr["ESTCODI"].ToString();
                        txtestuf.Text = dr["ESTUF"].ToString();
                        txtestnome.Text = dr["ESTNOME"].ToString();
                        txtesticms.Text = dr["ESTICMS"].ToString();
                        txtestnome.Focus();
                        int i = 0;

                        for (i = 0; i < cbpaisnome.Items.Count; i++)
                        {
                            this.cbpaisnome.SelectedIndex = i;

                            if (this.cbpaisnome.SelectedValue.ToString() == dr["PAICODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("País não encontrado!");
                        this.cbpaisnome.SelectedIndex = 0;
                        txtestcodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Estado não encontrado \n deseja cadastra-lo?", "Cadastro", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtestuf.Text = "";
                            txtestnome.Text = "";
                            txtesticms.Text = "";
                            cbpaisnome.SelectedIndex = 0;
                            txtestuf.Focus();
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
            if (txtestnome.Text != "")
            {
                string strIncluir = "INSERT INTO ESTADO VALUES('" + txtestcodi.Text + "', '" + txtestuf.Text + "', '" + txtestnome.Text +
                        "', '" + txtesticms.Text + "', '" + cbpaisnome.SelectedValue.ToString() + "'" + " )";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtestcodi.Focus();
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
            Conexao.Active(true);

            if (txtestnome.Text != "")
            {
                string strAtualiza =
                "UPDATE ESTADO SET ESTUF = '" + txtestuf.Text + "', ESTNOME = '" + txtestnome.Text +
                "', PAICODI = " + cbpaisnome.SelectedValue.ToString() + ", ESTICMS = " + txtesticms.Text + " WHERE ESTCODI = " + txtestcodi.Text + "";

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtestcodi.Focus();
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
            string strDelete = "DELETE FROM ESTADO WHERE ESTCODI = '" + txtestcodi.Text + "' ";
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limpar();
                txtestcodi.Focus();
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

        private void btvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
