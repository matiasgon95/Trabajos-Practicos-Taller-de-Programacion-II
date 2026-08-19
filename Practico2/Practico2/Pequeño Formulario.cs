using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit (e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask;

            ask = MessageBox.Show("¿Seguro que desea insertar un nuevo cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            { 
                MessageBox.Show("El cliente: "+ TNombre.Text + " " + TApellido.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                Lmodificar.Text = TApellido.Text + " " + TNombre.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            ask = MessageBox.Show("Está a punto de eliminar el cliente: " + TNombre.Text + " " + TApellido.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {

                MessageBox.Show("El cliente: " + TNombre.Text + " " + TApellido.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                Lmodificar.Text = "";
            }
        }
    }
}
