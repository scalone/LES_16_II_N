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
    public partial class frmhorario : Form
    {
        public frmhorario()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txthorcodi.Clear();
            txthormane.Clear();
            txthormans.Clear();
            txthortare.Clear();
            txthortars.Clear();
            txthorcodi.Focus();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmhorario_Load(object sender, EventArgs e)
        {
            string strConsulta = "SELECT * FROM TIPO_HORARIO";

            cbthonome.Items.Clear();
            Conexao.Active(true);

            try
            {
                FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                Dictionary<string, int> dict = new Dictionary<string,int>();

                while (dr.Read())
                {
                    dict.Add(dr["THONOME"].ToString(), Convert.ToInt32(dr["THOCODI"].ToString()));
                }
                this.cbthonome.DataSource = new BindingSource(dict, null);
                this.cbthonome.DisplayMember = "key";
                this.cbthonome.ValueMember = "value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Conexao.Active(false);
        }

        private void txthorcodi_Leave(object sender, EventArgs e)
        {
            if (txthorcodi.Text != "")
            {
                string strConsulta = 
                    "SELECT HORNOME, HORMANE, HORMANS, HORTARE, HORTARS, THOCODI FROM HORARIO WHERE HORCODI = '" + txthorcodi.Text + "'";

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
                        txthornome.Text = dr["HORNOME"].ToString();
                        txthormane.Text = dr["HORMANE"].ToString();
                        txthormans.Text = dr["HORMANS"].ToString();
                        txthortare.Text = dr["HORTARE"].ToString();
                        txthortars.Text = dr["HORTARS"].ToString();
                        txthornome.Focus();
                        int i = 0;

                        for (i = 0; i < cbthonome.Items.Count; i++)
                        {
                            cbthonome.SelectedIndex = i;

                            if (cbthonome.SelectedValue.ToString() == dr["THOCODI"].ToString())
                            {
                                return;
                            }
                        }
                        MessageBox.Show("Tipo de Horário não encontrado!");
                        this.cbthonome.SelectedIndex = 0;
                        txthorcodi.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Horário não encontrado \n deseja cadastra-lo?", "Cadastro",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btincluir.Enabled = true;
                            btgravar.Enabled = false;
                            btexcluir.Enabled = false;
                            txthornome.Text = "";
                            txthornome.Focus();
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
            if (txthornome.Text != "")
            {
                string strInclui = 
                    "INSERT INTO HORARIO VALUES('" + txthorcodi.Text + "', '" + txthornome.Text + "', '" +
                    txthormane.Text + "', '" + txthormans.Text + "', '" + txthortare.Text + "', '" + txthortars.Text + "')";
                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
                    txthorcodi.Focus();
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
            if (txthornome.Text != "")
            {
                string strAtualiza = 
                    "UPDATE HORARIO SET HORNOME = '" + txthornome.Text + "', HORMANE = '" + txthormane.Text + "', HORMANS = '" + 
                    txthormans.Text + "', HORTARE = '" + txthortare.Text + "', HORTARS = '" + txthortars.Text + "' WHERE HORCODI = '" + txthorcodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
                    txthorcodi.Focus();
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
            if (txthornome.Text != "")
            {
                string strExclui = "DETETE FROM HORARIO WHERE HORCODI = '" + txthorcodi.Text + "'";

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
                    txthorcodi.Focus();
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
