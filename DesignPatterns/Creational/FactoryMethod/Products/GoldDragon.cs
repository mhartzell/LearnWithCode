namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Dragon enemy (concrete Product).
    /// </summary>
    internal class GoldDragon : Enemy, IDragon
    {
        public bool BreathesFire { get; set; }
    }
}
