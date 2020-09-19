using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Multiplicacion : Calculo
    {
        public double multiplicar()
        {
            return (this.getNumero1() * this.getNumero2());
        }
    }
}
