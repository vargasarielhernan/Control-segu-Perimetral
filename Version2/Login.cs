using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version2
{
    public partial class Login : Form
    {
        PaneldeControl paneldeControl;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (tbx_usuario.Text !="" && tbx_contraseña.Text != "")
            {
                if(tbx_usuario.Text== "Admin" && tbx_contraseña.Text== "1234")
                {
                    paneldeControl = new PaneldeControl();
                    paneldeControl.Show();
                    this.Hide();
                }
            }
        }
    }
}
