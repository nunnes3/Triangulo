using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangulo
    {
        private double a, b, c;


        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            a = ladoA;
            b = ladoB;
            c = ladoC;
        }


        


        private string EhValido()
        
        {
            string validacao = "";
            

            if ( a < b + c  && b < a + c && c < a + b)
            {
               return validacao = "TRIANGULO_VÁLIDO";
            }

            return validacao = "TRIANGULO_INVÁLIDO";
        }

        public string TipoTriangulo()
        {
            string validacao = "";

            if (EhValido() != "TRIANGULO_INVÁLIDO")
            {


                

                if (a == b && a == c)
                {
                    return validacao = "TRIANGULO_EQUILÁTERO";

                }
                else if (a != b && b != c && a != c)
                {
                    return validacao = "TRIANGULO_ESCALENO";

                }
                else if (a == b || a == c || b == a || b == c || c == a || c == b)
                {
                    return validacao = "TRIANGULO_ISÓCELES";
                }

                

            }
            return EhValido();
        }
    }
}
