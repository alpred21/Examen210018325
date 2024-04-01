using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.VISTA;

namespace SistemasVentas.VISTA.Examen2Botones
{
    public partial class opcion1vista : Form
    {
        public opcion1vista()
        {
            InitializeComponent();
        }
        OpcionesBSS bss = new OpcionesBSS();
        private void opcion1vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MostrarOpcion1Bss();
        }
    }
}
