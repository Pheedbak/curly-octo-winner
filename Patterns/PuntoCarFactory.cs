namespace Patterns
{
    public class PuntoCarFactory : CarFactory
    {

        public override Car MakeACar()
        {
            return new Punto();
        }
    }
}