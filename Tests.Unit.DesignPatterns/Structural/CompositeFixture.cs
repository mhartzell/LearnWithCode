using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.LearnWithCode.DesignPatterns.Structural.Composite;
using PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Composites;
using PMasta.LearnWithCode.DesignPatterns.Structural.Composite.Leafs;

namespace PMasta.LearnWithCode.Tests.Unit.DesignPatterns.Structural
{
    [TestClass]
    public class CompositeFixture
    {
        [TestMethod]
        public void ConstructionSucceeds()
        {
            IInventoryItem backpack = new InventoryContainer("Backpack", 100);

            Assert.IsNotNull(backpack);
        }

        [TestMethod]
        public void AddLeafItemSucceeds()
        {
            IInventoryItem backpack = new InventoryContainer("Backpack", 100);
            IInventoryItem sword = new Sword("Masamune", 50);

            backpack.AddItem(sword);

            Assert.IsTrue(backpack.Contains(sword));
        }

        [TestMethod]
        public void AddCompositeItemSucceeds()
        {
            IInventoryItem backpack = new InventoryContainer("Backpack", 100);

            IInventoryItem spellBook = new UniqueInventoryContainer("Spellbook", 100);
            backpack.AddItem(spellBook);

            IInventoryItem fireball = new Spell("Fireball", 100);
            spellBook.AddItem(fireball);

            Assert.IsTrue(backpack.Contains(spellBook));
            Assert.IsTrue(spellBook.Contains(fireball));
        }

        [TestMethod]
        public void ParentIsAssignedCorrectly()
        {
            IInventoryItem backpack = new InventoryContainer("Backpack", 100);
            IInventoryItem sword = new Sword("Masamune", 50);

            backpack.AddItem(sword);

            Assert.IsTrue(sword.Parent == backpack);
        }
    }
}
