using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// An interface defining a Dragon enemy.
    /// </summary>
    public interface IDragon : IEnemy
    {
        /// <summary>
        /// True if the dragon spews fire.
        /// </summary>
        bool BreathesFire { get; set; }
    }
}
