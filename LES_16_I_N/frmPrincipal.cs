using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LES_15_II_N
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void enderecoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmendereco fEndereco = new frmendereco();
            fEndereco.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestado fEstado = new frmestado();
            fEstado.ShowDialog();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpais fPais = new frmpais();
            fPais.ShowDialog();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmunicipio fMunicipio = new frmmunicipio();
            fMunicipio.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbairro fBairro = new frmbairro();
            fBairro.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsobre fSobre = new frmsobre();
            fSobre.ShowDialog();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdepto fDepto = new frmdepto();
            fDepto.ShowDialog();
        }

        private void tipoHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipohorario fTipoHorario = new frmtipohorario();
            fTipoHorario.ShowDialog();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhorario fHorario = new frmhorario();
            fHorario.ShowDialog();
        }

        private void funcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncao fFuncao = new frmfuncao();
            fFuncao.ShowDialog();
        }

        private void cboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcbo fCbo = new frmcbo();
            fCbo.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncionario fFuncionario = new frmfuncionario();
            fFuncionario.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
