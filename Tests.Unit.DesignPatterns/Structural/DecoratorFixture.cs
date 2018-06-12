using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Structural.Decorator;
using PMasta.LearnWithCode.DesignPatterns.Structural.Decorator.Decorators;
using PMasta.LearnWithCode.DesignPatterns.Structural.Decorator.Players;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Structural
{
	/// <summary>
	/// Tests related to the Decorator pattern.
	/// </summary>
	[TestClass]
	public class DecoratorFixture
    {
		[TestMethod]
		public void ConstructBasicPlayerSucceeds()
		{
			IPlayer player = new BasicPlayer();
			StatisticsService statService = new StatisticsService();

			Assert.IsNotNull(player);
			Assert.IsTrue(player.Attack() == 10);
			Assert.IsTrue(player.Defend() == 10);
			Assert.IsTrue(statService.SpellsCast == 0);
			Assert.IsTrue(statService.WeaponStikes == 0);
		}

		[TestMethod]
		public void ConstructMagePlayerSucceeds()
		{
			StatisticsService statService = new StatisticsService();
			IPlayer mage = new MageDecorator(new BasicPlayer(), statService, "Magic Shield", 15);
			
			Assert.IsNotNull(mage);
			Assert.IsTrue(mage.Attack() == 10);
			Assert.IsTrue(mage.Defend() == 25);
			Assert.IsTrue(statService.SpellsCast == 1);
			Assert.IsTrue(statService.WeaponStikes == 0);
		}

		[TestMethod]
		public void ConstructWarriorPlayerSucceeds()
		{
			StatisticsService statService = new StatisticsService();
			IPlayer warrior = new WarriorDecorator(new BasicPlayer(), statService, "Flame Sword", 15);

			Assert.IsNotNull(warrior);
			Assert.IsTrue(warrior.Attack() == 25);
			Assert.IsTrue(warrior.Defend() == 10);
			Assert.IsTrue(statService.SpellsCast == 0);
			Assert.IsTrue(statService.WeaponStikes == 1);
		}

		[TestMethod]
		public void ConstructWarriorMagePlayerSucceeds()
		{
			StatisticsService statService = new StatisticsService();
			IPlayer player = new BasicPlayer();
			IPlayer mage = new MageDecorator(player, statService, "Magic Shield", 15);
			IPlayer warriorMage = new WarriorDecorator(mage, statService, "Flame Sword", 15);

			Assert.IsNotNull(warriorMage);
			Assert.IsTrue(warriorMage.Attack() == 25);
			Assert.IsTrue(warriorMage.Defend() == 25);
			Assert.IsTrue(statService.SpellsCast == 1);
			Assert.IsTrue(statService.WeaponStikes == 1);
		}
	}
}
