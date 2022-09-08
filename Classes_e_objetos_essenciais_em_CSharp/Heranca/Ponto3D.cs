
namespace Classes_e_objetos_essenciais_em_CSharp.Heranca
{

    public class Ponto3D : Ponto
    {

        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            // Faz algum calculo
        }

        public override void CalcularDistancia3()
        {
            // Faz algum calculo
            base.CalcularDistancia3();
        }

    }

}