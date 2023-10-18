using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAct
{
    public interface IBebida
    {
        string Descripcion { get; }
        double Costo();
    }
}
