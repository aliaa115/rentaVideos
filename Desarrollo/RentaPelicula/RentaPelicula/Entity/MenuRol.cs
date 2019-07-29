using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaPelicula.Entity
{
    public class MenuRol
    {
        private int iIdrol;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;
        private bool bAdministrador;

        public int IIdrol { get => iIdrol; set => iIdrol = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
        public bool BAdministrador { get => bAdministrador; set => bAdministrador = value; }
    }
}
