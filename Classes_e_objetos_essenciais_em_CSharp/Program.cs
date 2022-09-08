
using System;
using Classes_e_objetos_essenciais_em_CSharp.Heranca;

namespace Classes_e_objetos_essenciais_em_CSharp
{

    class Program
    {

        static void Main(string[] args)
        {

            Ponto p1 = new Ponto(0, 0);
            p1.CalcularDistancia3();
            p1.x = 0;
            p1.y = 0;

            Ponto3D p2 = new Ponto3D(10, 20, 30);
            p2.CalcularDistancia3();
            p2.x = 0;
            p2.y = 0;
            p2.z = 0;

            // Chamando membro estático da classe
            Ponto3D.Calcular();

        }

    }

}