﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PMasta.LearnWithCode.DesignPatterns.Creational.AbstractFactory.Products
{
    /// <summary>
    /// A concrete implementation of the <see cref="IButter"/> Abstract Product.
    /// </summary>
    internal class ButterTillamook : IButter
    {
        public string Brand => "Tillamook";

        public string Description => "Butter";
    }
}
