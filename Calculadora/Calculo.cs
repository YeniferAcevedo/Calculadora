using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculo
    {
        private double numero1;
        private double numero2;

        public void setNumero1(double valor)
        {
            this.numero1 = valor;
        }

        public void setNumero2(double valor)
        {
            this.numero2 = valor;
        }

        public double getNumero1()
        {
            return numero1;
        }

        public double getNumero2()
        {
            return numero2;
        }
    }
}
