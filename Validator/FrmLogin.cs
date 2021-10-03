﻿using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (validarUsuario(txtUsuario.Text, txtPassword.Text))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrecta");
                txtUsuario.Focus();
            }

        }

        private Boolean validarUsuario(String login, String clave)
        {
            bool retorno = false;
            if (login == "demo" && clave == "demo")
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
