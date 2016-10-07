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
    public partial class frmmunicipio : Form
    {
        public frmmunicipio()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtmuncodi.Clear();
            txtmunnome.Clear();
            cbestnome.SelectedIndex = 0;
            txtmuncodi.Focus();
        }

        private void frmmunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmmunicipio_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM ESTADO";

            cbestnome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, int> dict = new Dictionary<string, int>();

                while (dr.Read())
                {
                    dict.Add(dr["ESTNOME"].ToString(), Convert.ToInt16(dr["ESTCODI"]));
                }
                this.cbestnome.DataSource = new BindingSource(dict, null);
                this.cbestnome.DisplayMember = "key";
                this.cbestnome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void txtmuncodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);

            if (txtmuncodi.Text != "")
            {
                string strConsulta = "SELECT MUNCODI, MUNNOME, ESTCODI FROM MUNICIPIO WHERE MUNCODI = '" + txtmuncodi.Text + "'";

                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        btincluir.Enabled = false;
                        btgravar.Enabled = true;
                        btexcluir.Enabled = true;
                        txtmuncodi.Text = dr["MUNCODI"].ToString();
                        txtmunnome.Text = dr["MUNNOME"].ToString();
                        int i = 0;

                        for (i = 0; i < cbestnome.Items.Count; i++)
                        {
                            this.cbestnome.SelectedIndex = i;

                            if (this.cbestnome.SelectedValue.ToString() == dr["ESTCODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("Estado não encontrado!");
                        this.cbestnome.SelectedIndex = 0;
                        txtmuncodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Município não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txtmunnome.Text = "";
                            cbestnome.SelectedIndex = 0;
                            txtmunnome.Focus();
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
            Conexao.Active(true);

            if (txtmunnome.Text != "")
            {
                string strIncluir =
                    "INSERT INTO MUNICIPIO " +
                    "VALUES(" + "'" + txtmuncodi.Text + "', '" + txtmunnome.Text + "', '"  + cbestnome.SelectedValue.ToString() + "'" + " )";

                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txtmuncodi.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Conexao.Active(false);
        }

        private void btgravar_Click(object sender, EventArgs e)
        {
            Conexao.Active(true);

            if (txtmunnome.Text != "")
            {
                string strAtualiza =
                "UPDATE MUNICIPIO SET MUNNOME = '" + txtmunnome.Text +
                "', ESTCODI = " + cbestnome.SelectedValue.ToString() + " WHERE ESTCODI = " + txtmuncodi.Text + "";

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txtmuncodi.Focus();
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
            string strDelete = "DELETE FROM MUNICIPIO WHERE MUNCODI = '" + txtmuncodi.Text + "' ";
            Conexao.Active(true);
            
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limpar();
                txtmuncodi.Focus();
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
