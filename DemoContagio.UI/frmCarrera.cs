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

namespace DemoContagio.UI
{
    public partial class frmCarrera : Form
    {
        //List<Carrera> _list;
        public frmCarrera()
        {
            InitializeComponent();
        }

        private void frmCarrera_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
            UpdateCombox();
        }

        private void UpdateDataGrid()
        {
            var query = (from a in CarreraBL.Instance.SelectAll()
                         from b in FacultadBL.Instance.SelectAll()
                         where a.FacultadId == b.FacultadId
                         select new
                         {
                             ID = a.CarreraId,
                             Carrera = a.Nombre,
                             Facultad = b.Nombre
                         }
                         ).ToList();
            dataGridView1.DataSource = query;
        }

        private void UpdateCombox()
        {
            List<Facultad> _list = FacultadBL.Instance.SelectAll();
            comboBoxFacultad.DataSource = _list;
            comboBoxFacultad.DisplayMember = "Nombre";
            comboBoxFacultad.ValueMember = "FacultadId";
        }

        private void ControlsEnable()
        {
            textBoxNombre.Enabled = true;
            comboBoxFacultad.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            textBoxNombre.Enabled = false;
            textBoxNombre.Text = string.Empty;
            comboBoxFacultad.ValueMember = string.Empty;
            comboBoxFacultad.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ControlsEnable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Carrera entity = new Carrera() { 
                Nombre = textBoxNombre.Text.Trim(),
                FacultadId = (int)comboBoxFacultad.SelectedValue
            };
            CarreraBL.Instance.Insert(entity);
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
    }
}
