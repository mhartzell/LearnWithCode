namespace PMasta.LearnWithCode.DesignPatterns.Structural.Decorator.Decorators
{
	/// <summary>
	/// A decorator that adds Mage functionality.
	/// </summary>
	/// <remarks>
	/// This class fulfills the role of the Concrete Decorator in the Decorator pattern.
	/// </remarks>
	public class MageDecorator : PlayerDecorator
	{
		private int _power;
		private string _spell;

		public MageDecorator(IPlayer player, StatisticsService statService, string spell, int power) : base(player, statService)
		{
			this._power = power;
			this._spell = spell;
		}

		public override int Attack()
		{
			return base.Attack();
		}

		public override int Defend()
		{
			// Simulate that the decorator does something different from the base component
			this.StatService.SpellsCast++;

			return base.Defend() + this._power;
		}
	}
}
