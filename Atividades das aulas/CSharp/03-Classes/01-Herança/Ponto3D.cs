namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalculateDistance();
        }

        public static void Calculate()
        {
            //Faz alguma coisa...
        }
        public override void CalculateDistance3()
        {
            //Faz outra coisa ...
            base.CalculateDistance3();
        }
    }
}