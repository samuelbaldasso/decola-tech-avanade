namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distance;
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalculateDistance()
        {
            //Faz alguma coisa...
            CalculateDistance2();
        }

        private void CalculateDistance2()
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
        }
    }
}