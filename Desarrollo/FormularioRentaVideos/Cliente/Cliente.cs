using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRentaVideos.Cliente
{
    //Conny Barrios 0901 15 4555
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Pnl_Ingresar.Visible = false;
            Pnl_Actualizar.Visible = false;
            Pnl_Eliminar.Visible = false;
            Pnl_Reportes.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Pnl_Ingresar.Visible = false;
            Pnl_Actualizar.Visible = false;
            Pnl_Eliminar.Visible = true;
            Pnl_Reportes.Visible = false;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Pnl_Ingresar.Visible = true;
            Pnl_Actualizar.Visible = false;
            Pnl_Eliminar.Visible = false;
            Pnl_Reportes.Visible = false;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Pnl_Ingresar.Visible = false;
            Pnl_Actualizar.Visible = true;
            Pnl_Eliminar.Visible = false;
            Pnl_Reportes.Visible = false;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
