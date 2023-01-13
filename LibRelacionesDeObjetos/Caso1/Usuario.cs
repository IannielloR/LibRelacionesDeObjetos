using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibRelacionesDeObjetos.Caso1
{
    public class Usuario
    {
        public Usuario() { }

        public Cliente cliente { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
