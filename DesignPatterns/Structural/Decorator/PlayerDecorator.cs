namespace PMasta.LearnWithCode.DesignPatterns.Structural.Decorator
{
	/// <summary>
	/// Defines an interface for a Decorator.
	/// </summary>
	/// <remarks>
	/// This interface fulfills the role of Decorator in the Decorator pattern.
	/// </remarks>
	public abstract class PlayerDecorator : IPlayer
	{
		protected IPlayer Player { get; set; }

		protected StatisticsService StatService { get; set; }

		public PlayerDecorator(IPlayer player, StatisticsService statService)
		{
			this.Player = player;
			this.StatService = statService;
		}

		public virtual int Attack()
		{
			return this.Player.Attack();
		}

		public virtual int Defend()
		{
			return this.Player.Defend();
		}
	}
}
