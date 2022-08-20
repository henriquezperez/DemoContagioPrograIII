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
    public partial class frmCiclo : Form
    {
        List<Ciclo> _list;
        public frmCiclo()
        {
            InitializeComponent();
        }

        private void frmCiclo_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            ControlsDisable();
        }

        private void UpdateDataGrid()
        {
            _list = CicloBL.Instance.SelectAll();
            dataGridView1.DataSource = _list;
        }

        private void ControlsEnable()
        {
            textBoxName.Enabled = true;
            textBoxYear.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Enabled = false;
        }

        private void ControlsDisable()
        {
            textBoxName.Text = string.Empty;
            textBoxYear.Text = string.Empty;
            textBoxName.Enabled = false;
            textBoxYear.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ControlsEnable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControlsDisable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != string.Empty && textBoxYear.Text != string.Empty)
            {
                Ciclo entity = new Ciclo()
                {
                    Nombre = textBoxName.Text.Trim(),
                    Anio = textBoxYear.Text.Trim()
                };
                CicloBL.Instance.Insert(entity);
               /* if(res != null)
                {
                    MessageBox.Show("Datos ingresados","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }*/
                ControlsDisable();
                UpdateDataGrid();
                MessageBox.Show("El registro se agrego correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Campos vacios!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
