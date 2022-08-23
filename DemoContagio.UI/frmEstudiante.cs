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
using System.Collections;

namespace DemoContagio.UI
{
    public partial class frmEstudiante : Form
    {
        List<Estudiante> _listaEstudiante;
        List<Carrera> _listCarrera;
        //List<Estado> _listEstados;

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
            // _listaEstudiante = EstudianteBL.Instance.SelectAll();
            //dataGridView1.DataSource = _listaEstudiante;
            var query = (from a in _listaEstudiante = EstudianteBL.Instance.SelectAll()
                         from b in _listCarrera = CarreraBL.Instance.SelectAll()
                         where a.CarreraId == b.CarreraId
                         select new
                         {
                             ID = a.CarreraId,
                             Codigo = a.Codigo,
                             Nombres = a.Nombres,
                             Apellidos = a.Apellidos,
                             Carrera = b.Nombre,
                             Nacimineto = a.Natalicio,
                             Genero = a.Genero,
                             Telefono = a.NumTelefono,
                             Estado = a.EstadoId,
                             Foto = a.Foto
                         }
                         ).ToList();
            dataGridView1.DataSource = query;
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
            //textBoxNacimiento.Enabled = true;
            dateTimePickerNacimiento.Enabled = true;
            textBoxTelefono.Enabled = true;
            comboBoxCarrera.Enabled = true;
            comboBoxGenero.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnFoto.Visible = true;
            //btnEliminarFoto.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxCodigo.Text = "";
            //textBoxNacimiento.Text = "";
            dateTimePickerNacimiento.Value = DateTime.Now.Date;
            textBoxTelefono.Text = "";
            comboBoxCarrera.SelectedValue = 1;
            comboBoxGenero.Text = "M";
            btnFoto.Text = "Buscar foto";
            pictureBoxFoto.Image = Properties.Resources.photoNull;
            textBoxNombres.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxCodigo.Enabled = false;
            //textBoxNacimiento.Enabled = false;
            dateTimePickerNacimiento.Enabled = false;
            textBoxTelefono.Enabled = false;
            comboBoxCarrera.Enabled = false;
            comboBoxGenero.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnFoto.Visible = false;
            btnEliminarFoto.Visible = false;
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
                //Natalicio = textBoxNacimiento.Text.Trim(),
                Natalicio = dateTimePickerNacimiento.Value.ToLongDateString(),
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
                Image img = Image.FromFile(foto.FileName);
                Bitmap newResolution = new Bitmap(img, new Size(120,120));
                pictureBoxFoto.Image = newResolution;
            }
            if(pictureBox1.Image != Properties.Resources.photoNull)
            {
                btnFoto.Text = "Cambiar";
                btnEliminarFoto.Visible = true;
            }
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            /* ArrayList _lista = new ArrayList();
             int c = 0;
             for (int i = 0; i < textBoxApellidos.Text.Length; i++)
             {
                 if (textBoxApellidos.Text[i].ToString() == " ")
                 {
                     // textBoxCodigo.Text += textBoxApellidos.Text[i+1].ToString();  
                     //c++;
                     //_lista.Add(i);
                     //textBoxCodigo.Text += i.ToString();
                     textBoxCodigo.Text += textBoxApellidos.Text.Split(" ".ToCharArray());
                 }
             }
             //textBoxCodigo.Text = c.ToString();
             //textBoxCodigo.Text = _lista.ToString();

             */
            // textBoxCodigo.Text += textBoxApellidos.Text.Split(" ".ToCharArray());
                
               // textBoxCodigo.Text = textBoxApellidos.Text.Substring(0, 1).Trim();
            
            
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.Image = Properties.Resources.photoNull;
            btnEliminarFoto.Visible = false;
            btnFoto.Text = "Buscar foto";
        }
    }
}
