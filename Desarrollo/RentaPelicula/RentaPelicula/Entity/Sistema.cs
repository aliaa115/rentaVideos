using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaPelicula.Entity
{
    public class Sistema
    {
        private int iIdsistema;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;

        public int IIdsistema { get => iIdsistema; set => iIdsistema = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
