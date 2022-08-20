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
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            frmCiclo frm = new frmCiclo();
           // _instace = frm;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            frmAsignatura fr = null;
            fr = frmAsignatura.Instance;
            fr.MdiParent = this;
            this.TopMost = true;
            fr.Show();
            
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {

            frmCarrera frm = new frmCarrera();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            frmAula frm = new frmAula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFacultad_Click(object sender, EventArgs e)
        {
            frmFacultad frm = new frmFacultad();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiante frm = new frmEstudiante();
            frm.MdiParent = this;
            frm.Show();
        }

        /* private void Windows(EventArgs e, int x)
         {
             if(e.Equals(btnCiclo.Click() == true), x == 1)
             {
                 frmCiclo frm = new frmCiclo();
                 _instace = frm;
                 frm.MdiParent = this;
                 frm.Show();
             }
         }*/
    }
}
