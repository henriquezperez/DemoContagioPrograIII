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
    public partial class frmAsignatura : Form
    {
        //List<Asignatura> _list;
        public frmAsignatura()
        {
            InitializeComponent();
        }

        private void frmAsignatura_Load(object sender, EventArgs e)
        {
            ControlsDisable();
            UpdateDataGrid();
            UpdateCombox();
        }

        private void UpdateDataGrid()
        {
            var query = (from a in AsignaturaBL.Instance.SelectAll()
                         from b in AulaBL.Instance.SelectAll()
                         from c in FacultadBL.Instance.SelectAll()
                         from d in CicloBL.Instance.SelectAll()
                         where a.AulaId.Equals(b.AulaId) &&
                         a.CicloId.Equals(d.CicloId) &&
                         a.FacultadId.Equals(c.FacultadId)
                         select new
                         {
                            ID = a.AsignaturaId,
                            Asignatura = a.Nombre,
                            Codigo = a.Codigo,
                            Aula = b.Nombre,
                            Ciclo = d.Nombre,
                            Facultad = c.Nombre
                         }
                         ).ToList();
            dataGridView1.DataSource = query;
        }

        private void UpdateCombox()
        {
            List<Aula> _listAula = AulaBL.Instance.SelectAll();
            comboBoxAula.DataSource = _listAula;
            comboBoxAula.DisplayMember = "Nombre";
            comboBoxAula.ValueMember = "AulaId";
            List<Ciclo> _listCiclo = CicloBL.Instance.SelectAll();
            comboBoxCiclo.DataSource = _listCiclo;
            comboBoxCiclo.DisplayMember = "Nombre";
            comboBoxCiclo.ValueMember = "CicloId";
            List<Facultad> _listFac = FacultadBL.Instance.SelectAll();
            comboBoxFacultad.DataSource = _listFac;
            comboBoxFacultad.DisplayMember = "Nombre";
            comboBoxFacultad.ValueMember = "FacultadId";
        }

        private void ControlsEnable()
        {
            textBoxNombre.Enabled = true;
            textBoxCodigo.Enabled = true;
            comboBoxAula.Enabled = true;
            comboBoxCiclo.Enabled = true;
            comboBoxFacultad.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            textBoxNombre.Text = string.Empty;
            textBoxCodigo.Text = string.Empty;
            comboBoxAula.ValueMember = string.Empty;
            comboBoxCiclo.ValueMember = string.Empty;
            comboBoxFacultad.ValueMember = string.Empty;
            textBoxNombre.Enabled = false;
            textBoxCodigo.Enabled = false;
            comboBoxAula.Enabled = false;
            comboBoxCiclo.Enabled = false;
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
            Asignatura entity = new Asignatura()
            {
                Nombre = textBoxNombre.Text.Trim(),
                Codigo = textBoxCodigo.Text.Trim(),
                AulaId = (int)comboBoxAula.SelectedValue,
                AsignaturaId = (int)comboBoxFacultad.SelectedValue,
                CicloId = (int)comboBoxCiclo.SelectedValue,
                FacultadId = (int)comboBoxFacultad.SelectedValue
            };
            AsignaturaBL.Instance.Insert(entity);
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
