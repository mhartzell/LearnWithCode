namespace PMasta.LearnWithCode.DesignPatterns.Structural.Decorator.Decorators
{
	/// <summary>
	/// A decorator that adds Warrior functionality.
	/// </summary>
	/// <remarks>
	/// This class fulfills the role of the Concrete Decorator in the Decorator pattern.
	/// </remarks>
	public class WarriorDecorator : PlayerDecorator
    {
		private int _power;
		private string _weapon;

		public WarriorDecorator(IPlayer player, StatisticsService statService, string weapon, int power) : base(player, statService)
		{
			this._power = power;
			this._weapon = weapon;
		}

		public override int Attack()
		{
			// Simulate that the decorator does something different from the base component
			this.StatService.WeaponStikes++;

			return base.Attack() + this._power;
		}

		public override int Defend()
		{
			return base.Defend();
		}
	}
}
