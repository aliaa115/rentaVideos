using System;
using System.Windows.Forms;

namespace FormularioRentaVideos
{
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = true;
            Pnl_Remover.Dock = DockStyle.Fill;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = true;
            Pnl_Modificar.Dock = DockStyle.Fill;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = true;
            Pnl_Remover.Dock = DockStyle.Fill;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = true;
            Pnl_Nuevo.Dock = DockStyle.Fill;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

        }
    }
}
