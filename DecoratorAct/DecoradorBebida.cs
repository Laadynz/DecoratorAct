namespace DecoratorAct
{
    public abstract class DecoradorBebida : IBebida
    {
        protected IBebida bebidaBase;

        public DecoradorBebida(IBebida bebidaBase)
        {
            this.bebidaBase = bebidaBase;
        }

        public virtual string Descripcion => bebidaBase.Descripcion;
        public abstract double Costo();
    }
}
