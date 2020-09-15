using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnidadesMedidaPOO
{
    public class Valor
    {
        private double valor;
        private string unidad; 

        //Métodos setter y getter

        public void setValor(double valor)
        {
            this.valor = valor; 
        }

        public void setUnidad(string val)
        {
            this.unidad = val; 
        }

        public double getValor()
        {
            return valor; 
        }

        public string getUnidad()
        {
            return unidad; 
        }
    }
}
