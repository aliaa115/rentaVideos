using System;
using System.Windows.Forms;

namespace FormularioRentaVideos
{
    public partial class Devouciones : Form
    {
        public Devouciones()
        {
            InitializeComponent();
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;

            this.Dgv_PeliculasCliente.Rows.Add();
            Dgv_PeliculasCliente.Rows[0].Cells[0].Value = 1;
            Dgv_PeliculasCliente.Rows[0].Cells[1].Value = false;
            Dgv_PeliculasCliente.Rows[0].Cells[2].Value = "Pitufos";
            Dgv_PeliculasCliente.Rows[0].Cells[3].Value = "12-02-2019";
            Dgv_PeliculasCliente.Rows[0].Cells[4].Value = "20-02-2019";
            Dgv_PeliculasCliente.Rows[0].Cells[5].Value = "0";
            this.Dgv_PeliculasCliente.Rows.Add();
            Dgv_PeliculasCliente.Rows[1].Cells[0].Value = 1;
            Dgv_PeliculasCliente.Rows[1].Cells[1].Value = false;
            Dgv_PeliculasCliente.Rows[1].Cells[2].Value = "Pitufos";
            Dgv_PeliculasCliente.Rows[1].Cells[3].Value = "12-02-2019";
            Dgv_PeliculasCliente.Rows[1].Cells[4].Value = "20-02-2019";
            Dgv_PeliculasCliente.Rows[1].Cells[5].Value = "0";
            this.Dgv_PeliculasCliente.Rows.Add();
            Dgv_PeliculasCliente.Rows[2].Cells[0].Value = 1;
            Dgv_PeliculasCliente.Rows[2].Cells[1].Value = false;
            Dgv_PeliculasCliente.Rows[2].Cells[2].Value = "Pitufos";
            Dgv_PeliculasCliente.Rows[2].Cells[3].Value = "12-02-2019";
            Dgv_PeliculasCliente.Rows[2].Cells[4].Value = "20-02-2019";
            Dgv_PeliculasCliente.Rows[2].Cells[5].Value = "0";
            this.Dgv_PeliculasCliente.Rows.Add();
            Dgv_PeliculasCliente.Rows[3].Cells[0].Value = 1;
            Dgv_PeliculasCliente.Rows[3].Cells[1].Value = false;
            Dgv_PeliculasCliente.Rows[3].Cells[2].Value = "Pitufos";
            Dgv_PeliculasCliente.Rows[3].Cells[3].Value = "12-02-2019";
            Dgv_PeliculasCliente.Rows[3].Cells[4].Value = "20-02-2019";
            Dgv_PeliculasCliente.Rows[3].Cells[5].Value = "0";

            this.Dgv_PeliculasCliente.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_PeliculasCliente.MultiSelect = false;
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = true;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = true;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = true;
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
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;
        }

        private void Dgv_PeliculasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
