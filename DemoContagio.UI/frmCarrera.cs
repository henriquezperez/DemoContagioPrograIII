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
        List<Carrera> _list;
        public frmCarrera()
        {
            InitializeComponent();
        }

        private void frmCarrera_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            _list = CarreraBL.Instance.SelectAll();
            dataGridView1.DataSource = _list;
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
