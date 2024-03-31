using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using AccesoDB;

namespace Version2
{
    public partial class Login : Form
    {
        PaneldeControl paneldeControl;
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            AccesoUsuarios us = new AccesoUsuarios();
            try
            {
                user.Name = tbx_usuario.Text;
                user.Password=tbx_contraseña.Text;
                if (us.findUser(user))
                {
                    paneldeControl = new PaneldeControl();
                    paneldeControl.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuario o contraseña incorrecta intente de nuevo");
            }
            //if (tbx_usuario.Text !="" && tbx_contraseña.Text != "")
            //{
            //    if(tbx_usuario.Text== "Admin" && tbx_contraseña.Text== "1234")
            //    {
            //        paneldeControl = new PaneldeControl();
            //        paneldeControl.Show();
            //        this.Hide();
            //    }
            //}
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.btn_Aceptar.PerformClick();
            }
        }
    }
}
