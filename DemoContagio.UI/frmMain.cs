using DemoContagio.Entities;
using DemoContagio.BusinessLogic;
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
    public partial class frmMain : Form
    {
        List<Ciclo> _list = new List<Ciclo>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _list = CicloBL.Instance.SelectAll().ToList();
           // dataGridView1.DataSource = _list;
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            frmCiclo fn = new frmCiclo();
            fn.ShowDialog();
        }

        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            frmAsignatura asg = new frmAsignatura();
            asg.ShowDialog();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            frmCarrera carr = new frmCarrera();
            carr.ShowDialog();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            frmAula aul = new frmAula();
            aul.ShowDialog();
        }

        private void btnFacultad_Click(object sender, EventArgs e)
        {
            frmFacultad fa = new frmFacultad();
            fa.ShowDialog();
        }
    }
}
