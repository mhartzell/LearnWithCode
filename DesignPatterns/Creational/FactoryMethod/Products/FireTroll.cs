namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Troll enemy (concrete Product).
    /// </summary>
    internal class FireTroll : Enemy, ITroll
    {
        public bool IsStone { get; set; }
    }
}
