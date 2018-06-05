namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A abstract representation of a generic enemy (Product).  
    /// </summary>
    internal abstract class Enemy : IEnemy
    {
        public string Name { get; set; }

        public int Strength { get; set; }
    }
}
