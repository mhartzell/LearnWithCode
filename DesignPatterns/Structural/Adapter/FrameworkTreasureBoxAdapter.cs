namespace PMasta.LearnWithCode.DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// An adapter between the custom treasure box used in the game being created and the 
    /// generic treasure box defined by the game engine framework.
    /// </summary>
    /// <remarks>
    /// An adapter converts the intervace of one class into the interface a client expects.  Adapter
    /// lets classes work together that couldn't otherwise because of incompatible interfaces. 
    /// </remarks>
    public class FrameworkTreasureBoxAdapter : IFrameworkTreasureBox
    {
        private string _lockType;
        private MyGameTreasureBox _myBox;

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="myBox">A <see cref="MyGameTreasureBox"/>.</param>
        /// <remarks>
        /// This implementation of Adapter uses the object-composition approach.  While the class implments the 
        /// framework interface, it requires an instance of the custom interface.
        /// </remarks>
        public FrameworkTreasureBoxAdapter(MyGameTreasureBox myBox)
        {
            this._myBox = myBox;
        }

        /// <summary>
        /// The lock type.
        /// </summary>
        /// <remarks>
        /// The game-specific treasure box does not have the concept of a Lock Type, so the functionality must be adapted 
        /// here.  If no value has been provided for this property from other calls from the framework, then the Adapter
        /// supplies a default value the framework will recognize. 
        /// </remarks>
        public string LockType
        {
            get
            {
                if(string.IsNullOrEmpty(this._lockType))
                {
                    return "No Lock";
                }

                return this._lockType;
            }

            set
            {
                this._lockType = value;
            }
        }

        /// <summary>
        /// Provides a method for determining treasure box loot.
        /// </summary>
        /// <returns>The loot.</returns>
        /// <remarks>
        /// While this method is required by the framework interface, the implementation relies upon the nested custom 
        /// treasure box instance to perform the actual work.
        /// </remarks>
        public string GenerateLoot()
        {
            TreasureType treasureType = _myBox.GetTreasure();

            string loot = "";

            switch (treasureType)
            {
                case TreasureType.Normal:
                    loot = "Normal";
                    break;

                case TreasureType.Rare:
                    loot = "Rare";
                    break;

                case TreasureType.Legendary:
                    loot = "Legendary";
                    break;
            }

            return loot;
        }
    }
}
