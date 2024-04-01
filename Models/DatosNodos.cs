using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatosNodos
    {
        public int Id {  get; set; }
        public Users users { get; set; }
        public string Empresa { get; set; }
        public string Lugar { get; set;}
        public int IdNodo { get; set;}
        public string Seccion { get; set;}
        public string Estado { get; set;}
        public string Zona { get; set;}
        public DateTime Time { get; set;}
    }
}
