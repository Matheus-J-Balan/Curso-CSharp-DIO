using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Dio.Models
{
    public class Retangulo
    {
        private double comprimento{ get; set; }
        private double largura { get; set; }
        private bool valido { get; set; }

        public void DefinirMedidas(double comprimento, double largura)
        {
          if(comprimento > 0 && largura > 0) { 
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
          }else
              Console.WriteLine("Valores invalidos");
        }

        public double ObterArea()
        {
          if(valido)  
            return comprimento * largura;
          else{
            Console.WriteLine("Preencha valores validos");
            return 0;
          }  
        }  
    }
}