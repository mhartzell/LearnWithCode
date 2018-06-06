namespace PMasta.LearnWithCode.DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// An interface that defines a generic treasure for a game engine framework.
    /// </summary>
    public interface IFrameworkTreasureBox
    {
        string GenerateLoot();

        string LockType { get; set; }
    }
}
