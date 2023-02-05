using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonesFB.Dades.Model
{
    public class PersonaObject
    {
        public string nombre { get; set; }
        public string profesion { get; set; }
        public int edad { get; set; }
        public string[] lenguajes { get; set; }
        public bool disponibilidadParaViajar { get; set; }
        public RangoProfesional rangoProfesional { get; set; }

        public class RangoProfesional
        {
            public int aniosDeExperiencia { get; set; }
            public string nivel { get; set; }
        }
    }
    public class PersonaArray
    {
        public string profesion { get; set; }
        public int edad { get; set; }
        public string[] lenguajes { get; set; }
        public bool disponibilidadParaViajar { get; set; }
        public RangoProfesional rangoProfesional { get; set; }

        public class RangoProfesional
        {
            public int aniosDeExperiencia { get; set; }
            public string nivel { get; set; }
        }
    }
}
