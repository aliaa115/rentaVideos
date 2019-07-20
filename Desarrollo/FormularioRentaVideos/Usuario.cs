using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FormularioRentaVideos
{
    public partial class Usuario : Form
    {
        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Usuario_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
         
            //w = this.Width;
            //h = this.Height;

        }
    }
}
