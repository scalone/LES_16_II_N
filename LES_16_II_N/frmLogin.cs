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
    public partial class frmLogin : Form
    {
        int contagemSenhaErrada = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckmostrasenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmostrasenha.Checked == true)
            {
                txtususenha.PasswordChar = '\0';
            }
            else
            {
                txtususenha.PasswordChar = '*';
            }
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            Conexao.Active(true);

            try
            {
                string strConsultaUsuario = "SELECT * FROM USUARIO WHERE USUNOME = '" + txtusunome.Text + "'";

                FbCommand cmd = new FbCommand(strConsultaUsuario, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr["USUBLOQ"].ToString() == "N")
                    {
                        if (String.Compare(dr["USUSENHA"].ToString().Trim(), txtususenha.Text) == 0)
                        {
                            contagemSenhaErrada = 0;
                            frmprincipal fPrincipal = new frmprincipal();
                            fPrincipal.Show();
                        }
                        else
                        {
                            contagemSenhaErrada++;
                            MessageBox.Show("Senha inválida!");
                            txtususenha.Clear();
                            txtususenha.Focus();

                            if (contagemSenhaErrada == 3)
                            {
                                string strBloqueiaUsuario = "UPDATE USUARIO SET USUBLOQ = 'S' WHERE USUNOME = '" + txtusunome.Text + "'";

                                FbCommand cmdBloq = new FbCommand(strBloqueiaUsuario, Conexao.FbCnn);
                                cmdBloq.ExecuteNonQuery();
                                contagemSenhaErrada = 0;
                                MessageBox.Show("Usuário bloqueado!");
                                txtusunome.Clear();
                                txtusunome.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário bloqueado!");
                        txtusunome.Clear();
                        txtususenha.Clear();
                        txtusunome.Focus();
                        contagemSenhaErrada = 0;
                    }
                }
                else
                {
                    contagemSenhaErrada = 0;
                    MessageBox.Show("Usuário inválido!");
                    txtusunome.Clear();
                    txtususenha.Clear();
                    txtusunome.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
