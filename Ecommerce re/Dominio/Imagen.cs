using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        int IDimagen { get; set; }
        int IDproducto { get; set; }
        string Url { get; set; }
        bool Activo { get; set; }
    }
}
