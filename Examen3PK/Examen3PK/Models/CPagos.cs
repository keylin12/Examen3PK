using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen3PK.Models
{
    public class CPagos
    {
        [PrimaryKey, AutoIncrement]
        public int Idpago { get; set; }

        [MaxLength(500)]
        public String descripcion { get; set; }

        public double fecha { get; set; }

        public double monto { get; set; }

        public string imagen { get; set; }

    }
}
