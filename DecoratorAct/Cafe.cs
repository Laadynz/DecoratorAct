namespace DecoratorAct
{
    public class Cafe : IBebida
    {
        public string Descripcion => "Café";
        public double Costo() => 45.0;
       
    }
}
