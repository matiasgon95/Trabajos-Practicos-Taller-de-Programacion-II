using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BSalir_Click(sender, e);
            }
        }
    }
}
