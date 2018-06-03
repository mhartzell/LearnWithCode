﻿namespace PMasta.Learning.DesignPatterns.Creational.FactoryMethod.Products
{
    /// <summary>
    /// A concrete implemenation of a Wizard enemy (concrete Product).
    /// </summary>
    internal class DemonWizard : Enemy, IWizard
    {
        public string AttackSpell { get; set; }
    }
}
