namespace DecoratorAct
{
    public class Leche : DecoradorBebida
    {
        public Leche(IBebida bebidaBase) : base(bebidaBase) { }

        public override string Descripcion => $"{bebidaBase.Descripcion}, Leche";
        public override double Costo() => bebidaBase.Costo() + 0.5;
    }
}
