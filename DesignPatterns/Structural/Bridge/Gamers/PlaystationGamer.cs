namespace PMasta.LearnWithCode.DesignPatterns.Structural.Bridge.Gamers
{
    /// <summary>
    /// A concrete implementation of <see cref="IPlatformGamer"/>.
    /// </summary>
    /// <remarks>
    /// This is a concrete implemention of <see cref="IPlatformGamer"/>, where we finally find code and logic to retrieve 
    /// data from a specific platform (in this case, the Playstation platform).
    /// </remarks>
    internal class PlaystationGamer : IPlatformGamer
    {
        // private IPlaystationService _service;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="email">The player's identifying email.</param>
        /// <remarks>
        /// Perhaps this object is injected with a Playstation specific service so that it can do stuff.
        /// </remarks>
        public PlaystationGamer(string email /*, IPlaystationService service */)
        {
            // this._service = service;

            // As an example, call some initialization logic with the Playstation Network to get info
            // IAccountInfo account = this._service.GetAccountInfo(email);
            // this.FirstName = account.FirstName;
            // this.LastName = accountLastName;
            // this.InternalId = account.Id;

            this.FirstName = "Playstation";
            this.LastName = "Gamer";
            this.Platform = Platform.Playstation4;
        }

        public string FirstName { get; set; }
        public object InternalId { get; set; }
        public string LastName { get; set; }
        public Platform Platform { get; set; }

        public int AchievementRewardTotal()
        {
            // Make a request of Playstation
            // return this._service.GetTotalTrophies(this.InternalId);

            return 0;
        }

        public object CalculateAccountScore()
        {
            // Make a request of Playstation
            // return this._service.GetTropyLevel(this.InternalId);

            return 0;
        }
    }
}
