using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Suma : Calculo
    {
        public double sumar()
        {
            return (this.getNumero1() + this.getNumero2());
        }
    }
}
