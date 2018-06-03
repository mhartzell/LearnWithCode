using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// A quick and dirty data object for organizing a game world.
    /// </summary>
    public class GameWorld
    {
        /// <summary>
        /// The world's dragon enemy.
        /// </summary>
        public IDragon Dragon { get; set; }

        /// <summary>
        /// The world's troll enemy.
        /// </summary>
        public ITroll Troll { get; set; }

        /// <summary>
        /// The world's wizard enemy.
        /// </summary>
        public IWizard Wizard { get; set; }
    }
}
