namespace PMasta.Learning.DesignPatterns.Creational.Prototype
{
    public class BasketballPlayer : IBasketballPlayer
    {
        public string Name { get; set; }

        public PositionType Position { get; set; }

        public IBasketballPlayer Clone()
        {
            return this.MemberwiseClone() as IBasketballPlayer;
        }
    }
}
