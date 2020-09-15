using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnidadesMedidaPOO
{
    public class ConvertirUnidad : Valor
    {
        double miligramo, valorGramo, valorDecagramo; 
        public double convertirUnidad()
        {
            if (this.getUnidad() == "Miligramos")
            {
                this.miligramo = this.getValor() / 1000000;
                return this.miligramo;

            }else if (this.getUnidad() == "Gramos")
            {
                this.valorGramo = this.getValor() * 1000;
                return this.valorGramo;
            }
            else
            {
                this.valorDecagramo = this.getValor() * 100;
                return this.valorDecagramo;
            }
        }

    }
}
