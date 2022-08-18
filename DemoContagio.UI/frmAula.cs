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
    public partial class frmAula : Form
    {
        List<Aula> _list;
        public frmAula()
        {
            InitializeComponent();
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            _list = AulaBL.Instance.SelectAll();
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
            textBoxNombre.Text = string.Empty;
            textBoxNombre.Enabled = false;
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
            Aula entity = new Aula()
            {
                Nombre = textBoxNombre.Text.Trim()
            };
            AulaBL.Instance.Insert(entity);
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
