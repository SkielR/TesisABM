using System;
using System.Collections.Generic;

#nullable disable

namespace ApiProyect.Models
{
    public partial class comandoUpdateDevolucion
    {
        public int IdDevolucion { get; set; }
        public int NroDevolucion { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public int Flag { get; set; }

    }
}