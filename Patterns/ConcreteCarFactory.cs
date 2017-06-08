namespace Patterns
{
    public class FerrariCarFactory : CarFactory
    {
        public override Car MakeACar()
        {
            return new Ferrari();
        }
    }
}