using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validator
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void mnuManEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = new FrmEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuValidacionDocumento_Click(object sender, EventArgs e)
        {
            FrmValidarDocumento frm = new FrmValidarDocumento();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
