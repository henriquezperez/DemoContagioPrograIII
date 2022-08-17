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
            dataGridView1.DataSource = _list;
        }
    }
}
