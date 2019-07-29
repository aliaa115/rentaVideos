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
    public partial class MenuRol : Form
    {
        public MenuRol()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void Pnl_ventana2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_cerrar2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ayuda2_Click(object sender, EventArgs e)
        {
            Form formulario = new Ayuda();
            formulario.Show();
        }
    }
}
