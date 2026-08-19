using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();

            buscarImagen.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            buscarImagen.Title = "Seleccionar Foto de Perfil";

            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                TxtFoto.Text = buscarImagen.FileName;
                PBUser.Image = Image.FromFile(buscarImagen.FileName);
                PBUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNombre.Text) || string.IsNullOrWhiteSpace(TBApellido.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fechaNacimiento = DTPFechaNacimiento.Value.ToString("dd/MM/yyyy");

            string sexo = RBHombre.Checked ? "Hombre" : "Mujer";

            decimal saldo = 0;
            decimal.TryParse(TSaldo.Text, out saldo);

            Image fotoPerfil = PBUser.Image ?? Properties.Resources.avatar;

            string rutaFoto = TxtFoto.Text;

            int nFila = dataGridView1.Rows.Add(TBApellido.Text, TBNombre.Text, fechaNacimiento, sexo, "Eliminar", saldo.ToString("C"), fotoPerfil, rutaFoto);

            if (saldo < 50)
            {
                dataGridView1.Rows[nFila].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[nFila].DefaultCellStyle.ForeColor = Color.White;
            }

            LimpiarFormulario();
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                TBNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBNombre.Text.ToLower());
            }
        }

        private void TBApellido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBApellido.Text))
            {
                TBApellido.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TBApellido.Text.ToLower());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Broadway", 12, FontStyle.Bold);

            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Broadway", 12, FontStyle.Bold);

            dataGridView1.RowTemplate.Height = 75;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string valorSexo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (valorSexo == "Hombre")
            {
                RBHombre.Checked = true;
            }
            else if (valorSexo == "Mujer")
            {
                RBMujer.Checked = true;
            }
        }

        private void LimpiarFormulario()
        {
            TBNombre.Clear();
            TBApellido.Clear();
            DTPFechaNacimiento.Value = DateTime.Now;
            RBHombre.Checked = true;
            RBMujer.Checked = false;
            TSaldo.Clear();
            PBUser.Image = Properties.Resources.avatar;
            TxtFoto.Clear();
        }
    }
}
