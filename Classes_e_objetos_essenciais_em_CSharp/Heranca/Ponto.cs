
namespace Classes_e_objetos_essenciais_em_CSharp.Heranca
{

    public class Ponto
    {

        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            // Faz algum cálculo
        }

        protected void CalcularDistancia2()
        {
            // Faz algum cálculo
        }

        public virtual void CalcularDistancia3()
        {
            // Fal angum cálculo
        }

    }

}