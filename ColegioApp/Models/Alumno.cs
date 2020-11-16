using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioApp.Models
{
    public class Alumno
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public string Codigo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

    }
}
