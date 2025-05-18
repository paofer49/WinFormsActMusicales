using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsActMusicales.Model
{
    internal class Actividad
    {
        public int IdActividad { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoActividadId { get; set; }
        public string? Lugar { get; set; }
    }
}
