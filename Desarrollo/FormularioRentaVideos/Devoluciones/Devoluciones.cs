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

            for(int i = 0; i < 4; i++){
                this.Dgv_ListaClienteNuevo.Rows.Add();
                Dgv_ListaClienteNuevo.Rows[i].Cells[0].Value = i + 1;
                Dgv_ListaClienteNuevo.Rows[i].Cells[1].Value = false;
                Dgv_ListaClienteNuevo.Rows[i].Cells[2].Value = "Pitufos";
                Dgv_ListaClienteNuevo.Rows[i].Cells[3].Value = "12-02-2019";
                Dgv_ListaClienteNuevo.Rows[i].Cells[4].Value = "20-02-2019";
                Dgv_ListaClienteNuevo.Rows[i].Cells[5].Value = "0";

                this.Dgv_ListaClienteRemover.Rows.Add();
                Dgv_ListaClienteRemover.Rows[i].Cells[0].Value = i + 1;
                Dgv_ListaClienteRemover.Rows[i].Cells[1].Value = false;
                Dgv_ListaClienteRemover.Rows[i].Cells[2].Value = "Pitufos";
                Dgv_ListaClienteRemover.Rows[i].Cells[3].Value = "12-02-2019";
                Dgv_ListaClienteRemover.Rows[i].Cells[4].Value = "20-02-2019";
                Dgv_ListaClienteRemover.Rows[i].Cells[5].Value = "0";

                this.Dgv_ListaClienteModificar.Rows.Add();
                Dgv_ListaClienteModificar.Rows[i].Cells[0].Value = i + 1;
                Dgv_ListaClienteModificar.Rows[i].Cells[1].Value = false;
                Dgv_ListaClienteModificar.Rows[i].Cells[2].Value = "Pitufos";
                Dgv_ListaClienteModificar.Rows[i].Cells[3].Value = "12-02-2019";
                Dgv_ListaClienteModificar.Rows[i].Cells[4].Value = "20-02-2019";
                Dgv_ListaClienteModificar.Rows[i].Cells[5].Value = "0";
            }

            this.Dgv_ListaClienteNuevo.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ListaClienteNuevo.MultiSelect = false;
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = true;
            Pnl_Reporte.Visible = false;

            Label_Devoluciones.Text = "DEVOLUCIONES [Remover]";
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = true;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = false;

            Label_Devoluciones.Text = "DEVOLUCIONES [Modificar]";
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Pnl_Nuevo.Visible = false;
            Pnl_Modificar.Visible = false;
            Pnl_Remover.Visible = false;
            Pnl_Reporte.Visible = true;

            Label_Devoluciones.Text = "DEVOLUCIONES [Reporte]";
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

            Label_Devoluciones.Text = "DEVOLUCIONES [Nuevo]";
        }

        private void Dgv_PeliculasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
