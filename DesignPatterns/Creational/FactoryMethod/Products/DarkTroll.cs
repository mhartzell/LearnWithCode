namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Troll enemy (concrete Product).
    /// </summary>
    internal class DarkTroll : Enemy, ITroll
    {
        public bool IsStone { get; set; }
    }
}
