using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Defines a generic interface for a game world enemy, the generic Product constructed by the Factory Method.
    /// </summary>
    public interface IEnemy
    {
        /// <summary>
        /// The name of the enemy.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The physical strength of the enemy.
        /// </summary>
        int Strength { get; set; }
    }
}
