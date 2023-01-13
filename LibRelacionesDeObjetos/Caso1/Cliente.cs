using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibRelacionesDeObjetos.Caso1
{
    public class Cliente
    {
        public Cliente() { }
        
        public Usuario usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
    }
}
