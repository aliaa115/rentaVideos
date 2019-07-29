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
    public partial class CRUD_sistema : Form
    {
        public CRUD_sistema()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void Pnl_registro1_Paint(object sender, PaintEventArgs e)
        {
            Dgv_registro.DataSource = bd.SelectDataTable("select * from datos");
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            string nuevo = "insert into datos values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" +
                textBox4.Text + "')";

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
            string remover = "delete datos where clave = " + textBox1.Text;

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
            string modificar = "update datos set nombre = " + textBox2.Text + " where id = " + textBox1.Text;

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
            string nuevo = "insert into datos values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" +
               textBox4.Text + "')";

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

        private void Btn_cerrar_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Form formulario = new Ayuda();
            formulario.Show();
        }

        private void Btn_nuevo1_Click(object sender, EventArgs e)
        {

        }
    }
}
