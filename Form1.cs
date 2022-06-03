using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Clinica
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            n = dtvgRegistro.Rows.Add();

            dtvgRegistro.Rows[n].Cells[0].Value = txtNombre.Text;
            dtvgRegistro.Rows[n].Cells[1].Value = txtApellido.Text;
            dtvgRegistro.Rows[n].Cells[2].Value = txtSexo.Text;
            dtvgRegistro.Rows[n].Cells[3].Value = txtNacionalidad.Text;
            dtvgRegistro.Rows[n].Cells[4].Value = txtEdad.Text;
            dtvgRegistro.Rows[n].Cells[5].Value = txtTelefono.Text;
            dtvgRegistro.Rows[n].Cells[6].Value = txtCorreo.Text;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            txtNacionalidad.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                dtvgRegistro.Rows.RemoveAt(n);      
        }

        private void dtvgRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
