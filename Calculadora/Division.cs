using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Division : Calculo
    {
        public double dividir()
        {
            return (this.getNumero1() / this.getNumero2());
        }
    }
}
