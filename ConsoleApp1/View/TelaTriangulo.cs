using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TelaTriangulo
    {

        public void Inserir()
        {
            

            Triangulo triangulo = new Triangulo(6,5,6);
            
            Console.WriteLine(triangulo.TipoTriangulo());
            Console.ReadLine();
            

        }


        

        

    }
}
