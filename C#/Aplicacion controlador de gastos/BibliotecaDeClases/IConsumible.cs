using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IConsumible
    {
        string Nombre { get; set; }
        double Monto { get; set; }
        string Categoria { get; set; }
        DateTime Fecha { get; set; }
        bool PagoRealizado { get; set; }
        int Id { get; set; }

    }
}
