using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRentaVideos.Renta
{
    public partial class Frm_Renta : Form
    {
        public Frm_Renta()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Pnl_mantenimiento.Visible = true;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Pnl_mantenimiento.Visible = false;
            Pnl_Reporte.Visible = true;
        }
    }
}
