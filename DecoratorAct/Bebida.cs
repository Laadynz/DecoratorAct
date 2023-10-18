namespace DecoratorAct
{
    public class Bebida : IBebida
    {
        public string Descripcion => "Cafe"();
        public double Costo() => "2.0"();
       
    }
}
