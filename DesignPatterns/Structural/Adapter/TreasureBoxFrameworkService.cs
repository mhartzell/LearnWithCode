namespace PMasta.LearnWithCode.DesignPatterns.Structural.Adapter
{
    /// <summary>
    ///  A quick and dirty service offered by a game engine framework.
    /// </summary>
    /// <remarks>
    /// Suppose there is a game engine with a framework-level service for generating loot from a treasure box.
    /// This service provides that functionality.  It expects a generic treasure box of a type specified by the 
    /// framework.
    /// </remarks>
    public class TreasureBoxFrameworkService
    {
        public string OpenTreasureBox(IFrameworkTreasureBox treasure)
        {
            return treasure.GenerateLoot();
        }
    }
}
