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
    public partial class frmUnidade : Form
    {
        public frmUnidade()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtunicodi.Clear();
            txtuninome.Clear();
            txtunicodi.Focus();
        }

        private void btincluir_Click(object sender, EventArgs e)
        {
            if (txtuninome.Text != "")
            {
                string strInclui = "INSERT INTO UNIDADE VALUES('" + txtunicodi.Text + "', '" + txtuninome.Text + "')";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strInclui, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limpar();
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
            if (txtuninome.Text != "")
            {
                string strAtualiza = "UPDATE UNIDADE SET UNINOME = '" + txtuninome.Text + "' WHERE UNICODI = '" + txtunicodi.Text + "'";

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(strAtualiza, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso!");
                    limpar();
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
            if (txtuninome.Text != "")
            {
                string strExclui = "DELETE FROM UNIDADE WHERE UNICODI = '" + txtunicodi.Text + "'";

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
