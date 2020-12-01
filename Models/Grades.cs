using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerDBaaS.Models
{
    public class Grades
    {
        public Object _id { get; set; }
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }
        public string Nota { get; set; }
    }
}