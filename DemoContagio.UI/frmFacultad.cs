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
    public partial class frmFacultad : Form
    {
        List<Facultad> _list;
        public frmFacultad()
        {
            InitializeComponent();
        }

        private void frmFacultad_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            _list = FacultadBL.Instance.SelectAll();
            dataGridView1.DataSource = _list;
        }

        private void ControlsEnable()
        {
            textBoxNombre.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            btnNew.Enabled = true;
            textBoxNombre.Text = string.Empty;
            textBoxNombre.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ControlsEnable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Facultad entity = new Facultad()
            {
                Nombre = textBoxNombre.Text.Trim()
            };
            FacultadBL.Instance.Insert(entity);
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
        }
    }
}
