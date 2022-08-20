using DemoContagio.BusinessLogic;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DemoContagio.UI
{
    public partial class frmEstudiante : Form
    {
        List<Estudiante> _listaEstudiante;
        List<Carrera> _listCarrera;
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
            UpdateCombox();
        }

        private void UpdateDataGrid()
        {
            _listaEstudiante = EstudianteBL.Instance.SelectAll();
            dataGridView1.DataSource = _listaEstudiante;
        }

        private void UpdateCombox()
        {
            _listCarrera = CarreraBL.Instance.SelectAll();
            comboBoxCarrera.DataSource = _listCarrera;
            comboBoxCarrera.DisplayMember = "Nombre";
            comboBoxCarrera.ValueMember = "CarreraId";
        }

        private void ControlsEnable()
        {
            textBoxNombres.Enabled = true;
            textBoxApellidos.Enabled = true;
            textBoxCodigo.Enabled = true;
            textBoxNacimiento.Enabled = true;
            textBoxTelefono.Enabled = true;
            comboBoxCarrera.Enabled = true;
            comboBoxGenero.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnFoto.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            textBoxNombres.Text = " ";
            textBoxApellidos.Text = " ";
            textBoxCodigo.Text = "";
            textBoxNacimiento.Text = "";
            textBoxTelefono.Text = "";
            comboBoxCarrera.SelectedValue = 1;
            comboBoxGenero.Text = "M";
            pictureBoxFoto.Image = Properties.Resources.photoNull;

            textBoxNombres.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxCodigo.Enabled = false;
            textBoxNacimiento.Enabled = false;
            textBoxTelefono.Enabled = false;
            comboBoxCarrera.Enabled = false;
            comboBoxGenero.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnFoto.Visible = false;
            btnNew.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ControlsEnable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if(pictureBoxFoto.Image != null)
            {
                pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            
            Estudiante entity = new Estudiante()
            {
                Nombres = textBoxNombres.Text.Trim(),
                Apellidos = textBoxApellidos.Text.Trim(),
                Codigo = textBoxCodigo.Text.Trim(),
                CarreraId = (int)comboBoxCarrera.SelectedValue,
                NumTelefono = textBoxTelefono.Text.Trim(),
                Genero = comboBoxGenero.Text.Trim(),
                Natalicio = textBoxNacimiento.Text.Trim(),
                EstadoId = 1,
                Foto = ms.GetBuffer()
            };
            EstudianteBL.Instance.Insert(entity);
            ControlsDisable();
            UpdateDataGrid();
            MessageBox.Show("El registro se agrego correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControlsDisable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
            UpdateCombox();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Imagen JPG|*.jpg";
            
            if (foto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(foto.FileName);
            }
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            string aul = " ", b;
           
                if (textBoxApellidos.Text == " ")
                {
                    aul = textBoxApellidos.Text.First().ToString().ToLower().ToString();
               }
            
            textBoxCodigo.Text = aul + DateTime.Now.ToShortDateString().ToString();
        }
    }
}
