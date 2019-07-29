using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RentaPelicula
{
    public partial class CRUD_rol : Form
    {
        public CRUD_rol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        BaseDeDatos bd = new BaseDeDatos();

        private void Pnl_reporte_Paint(object sender, PaintEventArgs e)
        {
            Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            string nuevo = "insert into datos values (" + Txt_id.Text + ",'" + Txt_nombre.Text + "','" + Txt_descricpion.Text + "','" +
                Txt_administrador.Text + "')";

            if (bd.executecommand(nuevo))
            {
                MessageBox.Show("Registro agregado correctamente");
                Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            string remover = "delete datos where id = " + Txt_id.Text;

            if (bd.executecommand(remover))
            {
                MessageBox.Show("Registro eliminado correctamente");
                Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            string modificar = "update datos set nombre = " + Txt_nombre.Text + " where clave = " + Txt_id.Text;

            if (bd.executecommand(modificar))
            {
                MessageBox.Show("Registro actualizado correctamente");
                Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
            }
            else
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string nuevo = "insert into datos values (" + Txt_id.Text + ",'" + Txt_nombre.Text + "','" + Txt_descricpion.Text + "','" +
               Txt_administrador.Text + "')";

            if (bd.executecommand(nuevo))
            {
                MessageBox.Show("Registro agregado correctamente");
                Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
            }
            else
            {
                MessageBox.Show("Error al agregar");
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = Dgv_registro.Rows[e.RowIndex];
            Txt_id.Text = dgv.Cells[0].Value.ToString();
            Txt_nombre.Text = dgv.Cells[1].Value.ToString();
            Txt_descricpion.Text = dgv.Cells[2].Value.ToString();
            Txt_administrador.Text = dgv.Cells[3].Value.ToString();
            
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Form formulario = new Ayuda();
            formulario.Show();
        }

        private void Pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

