using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLogin
{
    public partial class frmDatos : Form
    {
        int maxIntentos = 0;

        public frmDatos()
        {
            InitializeComponent();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtcontraseña.Text == "@1a")
            {
                if (cmbModulo.SelectedItem == "ADM" || cmbModulo.SelectedItem == "VTA" || cmbModulo.SelectedItem == "COM")
                {
                    frmBienvenido show = new frmBienvenido();
                    this.Hide();
                    show.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El usuario Jhon no tiene acceso al módulo seleccionado",
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                     maxIntentos++;
                }
            }
            
            if (txtUsuario.Text == "Jhon" && txtcontraseña.Text == "*2b")
            {
                if (cmbModulo.SelectedItem == "SIST")
                {
                    frmBienvenido show = new frmBienvenido();
                    this.Hide();
                    show.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El usuario Jhon no tiene acceso al módulo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maxIntentos++;
                }
            }

            if (txtUsuario.Text == "Ceci" && txtcontraseña.Text == "@3c")
            {
                if (cmbModulo.SelectedItem == "ADM" || cmbModulo.SelectedItem == "VTA")
                {
                    frmBienvenido show = new frmBienvenido();
                    this.Hide();
                    show.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El usuario Maria no tiene acceso al módulo seleccionado");
                    maxIntentos++;
                }
            }

            if (txtUsuario.Text == "God" && txtcontraseña.Text == "*@#4d")
            {               
                frmBienvenido show = new frmBienvenido();
                this.Hide();
                show.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario y/o contraseña\r\nincorrectos para el módulo seleccionado");
                maxIntentos++;
            }

            if (maxIntentos == 2)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
