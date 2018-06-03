using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMasta.Learning.DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.Tests.Unit.DesignPatterns.Creational
{
    /// <summary>
    /// Tests related to the Abstract Factory pattern.
    /// </summary>
    [TestClass]
    public class AbstractFactoryFixture
    {
        [TestMethod]
        public void CreateAlpenroseButterSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Alpenrose);
            IButter butter = abstractFactory.ConstructButter();

            Assert.IsTrue(butter.Brand == "Alpenrose");
            Assert.IsTrue(butter.Description == "Butter");
        }

        [TestMethod]
        public void CreateAlpenroseEggsSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Alpenrose);
            IEggs eggs = abstractFactory.ConstructEggs();

            Assert.IsTrue(eggs.Brand == "Alpenrose");
            Assert.IsTrue(eggs.Description == "Eggs");
        }

        [TestMethod]
        public void CreateAlpenroseMilkSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Alpenrose);
            IMilk milk = abstractFactory.ConstructMilk();

            Assert.IsTrue(milk.Brand == "Alpenrose");
            Assert.IsTrue(milk.Description == "Milk");
        }

        [TestMethod]
        public void CreateDarigoldButterSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Darigold);
            IButter butter = abstractFactory.ConstructButter();

            Assert.IsTrue(butter.Brand == "Darigold");
            Assert.IsTrue(butter.Description == "Butter");
        }

        [TestMethod]
        public void CreateDarigoldEggsSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Darigold);
            IEggs eggs = abstractFactory.ConstructEggs();

            Assert.IsTrue(eggs.Brand == "Darigold");
            Assert.IsTrue(eggs.Description == "Eggs");
        }

        [TestMethod]
        public void CreateDarigoldMilkSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Darigold);
            IMilk milk = abstractFactory.ConstructMilk();

            Assert.IsTrue(milk.Brand == "Darigold");
            Assert.IsTrue(milk.Description == "Milk");
        }

        [TestMethod]
        public void CreateTillamookButterSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Tillamook);
            IButter butter = abstractFactory.ConstructButter();

            Assert.IsTrue(butter.Brand == "Tillamook");
            Assert.IsTrue(butter.Description == "Butter");
        }

        [TestMethod]
        public void CreateTillamookEggsSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Tillamook);
            IEggs eggs = abstractFactory.ConstructEggs();

            Assert.IsTrue(eggs.Brand == "Tillamook");
            Assert.IsTrue(eggs.Description == "Eggs");
        }

        [TestMethod]
        public void CreateTillamookMilkSucceeds()
        {
            IGroceryItemFactory abstractFactory = GroceryFactoryService.CreateGroceryItemFactory(GroceryProductFamily.Tillamook);
            IMilk milk = abstractFactory.ConstructMilk();

            Assert.IsTrue(milk.Brand == "Tillamook");
            Assert.IsTrue(milk.Description == "Milk");
        }
    }
}
