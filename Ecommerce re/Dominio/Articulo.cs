using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal precio { get; set; }
        public List<Imagen> ListaImagen { get; set; }
        public int IDmarca { get; set; }
        public int IDcategoria { get; set; }
        public int Stock { get; set; }

    
    }
}
